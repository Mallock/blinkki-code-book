using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using CefSharp;
using CefSharp.WinForms;
using System.Threading;
using System.IO;
using BlazeAutomationFramework.Settings;
using HtmlAgilityPack;

namespace BlazeAutomationFramework.Trading
{
    public partial class NordeaStock : DockContent
    {
        private ChromiumWebBrowser browser;
        private string SettingsPath = System.IO.Directory.GetCurrentDirectory();
        NativeINIReadWrite SettingsReadWrite = new NativeINIReadWrite();
        public string CurrentStockSettings { get; private set; }
        public string loadedUrl { get; private set; }

        private AutoTrade autoTrade = new AutoTrade();
        private bool sell;

        public NordeaStock()
        {
            InitializeComponent();
        }

        private void AddBrowserToPanel(ChromiumWebBrowser brw)
        {
            if (browser != null)
            {
                browser.Load(txtAddress.Text);
            }
            else
            {
                browser = brw;
                this.pnlBrowser.Controls.Add(browser);
                browser.Dock = DockStyle.Fill;
                while (!this.IsHandleCreated) // added
                    System.Threading.Thread.Sleep(100); //added
            }

        }

        private ChromiumWebBrowser CefBrowser(string url)
        {
            if (browser != null)
            {
                return browser;
            }
            else
            {
                ChromiumWebBrowser cwb = new ChromiumWebBrowser(url);
                cwb.AddressChanged += Cwb_AddressChanged;
                cwb.LoadingStateChanged += Cwb_LoadingStateChanged;
                return cwb;
            }


        }

        private void Cwb_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            //Wait for the Page to finish loading
            if (e.IsLoading == false)
            {
                if (picRunning.Visible)
                {
                    this.BeginInvoke((Action)(() => Trade()));
                }
            }
        }

        private void Trade()
        {
            LoadStockDataAsync();
            CalculateValueChange();
            autoTrade.SettingsReadWrite = this.SettingsReadWrite;
            autoTrade.CurrentStockSettings = this.CurrentStockSettings;
            autoTrade.UpdateData(txtCurrentStockPrice.Text,txtByingPrice.Text,txtStockSellingPrice.Text,txtStockValueChange.Text,txtOwnedStocks.Text);
            autoTrade.Analyze();
            if (autoTrade.Buy())
            {
                this.BeginInvoke((Action)(() => BuyStock()));
            }
            if (autoTrade.Sell())
            {
                this.BeginInvoke((Action)(() => SellStock()));
            }
            SaveSettings();
        }

        private void Cwb_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.loadedUrl = e.Address;
            while (!this.IsHandleCreated) // added
                System.Threading.Thread.Sleep(100); //added
            this.BeginInvoke(((Action)(() => this.txtUrl.Text = this.loadedUrl)));
        }

        private void NordeaStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (browser != null)
            {
                this.pnlBrowser.Controls.Remove(browser);
                browser.Dispose();
                browser = null;
                Thread.Sleep(200); //Prevent browser close freezing
            }

        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!Directory.Exists(SettingsPath + "\\stocks\\"))
            {
                Directory.CreateDirectory(SettingsPath + "\\stocks\\");
            }

            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = SettingsPath + "\\stocks\\",
                Title = "Save Stock Details To file",
                CheckPathExists = true,
                DefaultExt = "ini",
                Filter = "ini files|*.ini",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(sfd.FileName))
                {
                    File.WriteAllText(sfd.FileName, "[SETTINGS]");
                }
            }

            this.CurrentStockSettings = sfd.FileName;
            SaveSettings();
        }

        private void SaveSettings()
        {
            if (this.CurrentStockSettings != null)
            {
                SettingsReadWrite.INIWrite(CurrentStockSettings, "SETTINGS", "name", txtStockName.Text);
                SettingsReadWrite.INIWrite(CurrentStockSettings, "SETTINGS", "address", txtAddress.Text);
                SettingsReadWrite.INIWrite(CurrentStockSettings, "SETTINGS", "start", dtpStart.Value.ToShortTimeString());
                SettingsReadWrite.INIWrite(CurrentStockSettings, "SETTINGS", "end", dtpEnd.Value.ToShortTimeString());
                SettingsReadWrite.INIWrite(CurrentStockSettings, "SETTINGS", "currentprice", txtCurrentStockPrice.Text);
                SettingsReadWrite.INIWrite(CurrentStockSettings, "SETTINGS", "txtBalance", txtBalance.Text);
                SettingsReadWrite.INIWrite(CurrentStockSettings, "SETTINGS", "txtOwnedStocks", txtOwnedStocks.Text);
                SettingsReadWrite.INIWrite(CurrentStockSettings, "SETTINGS", "txtCurrentStockValue", txtCurrentStockValue.Text);
                SettingsReadWrite.INIWrite(CurrentStockSettings, "SETTINGS", "txtByingPrice", txtByingPrice.Text);
                SettingsReadWrite.INIWrite(CurrentStockSettings, "SETTINGS", "txtStockValueChange", txtStockValueChange.Text);
                SettingsReadWrite.INIWrite(CurrentStockSettings, "SETTINGS", "txtStockSellingPrice", txtStockSellingPrice.Text);
            }
        }

        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openStockSettings.ShowDialog();

            this.CurrentStockSettings = openStockSettings.FileName;

            LoadSettings();
        }

        private void LoadSettings()
        {
            if (this.CurrentStockSettings != null)
            {
                txtStockName.Text = SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "name");
                txtAddress.Text = SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "address");
                txtCurrentStockPrice.Text = SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "currentprice");
                txtBalance.Text = SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "txtBalance");
                txtOwnedStocks.Text = SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "txtOwnedStocks");
                txtCurrentStockValue.Text = SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "txtCurrentStockValue");
                txtByingPrice.Text = SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "txtByingPrice");
                txtStockValueChange.Text = SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "txtStockValueChange");
                txtStockSellingPrice.Text = SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "txtStockSellingPrice");
                DateTime dateTime;
                if (DateTime.TryParse(SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "start"), out dateTime))
                {
                    dtpStart.Value = dateTime;
                }
                if (DateTime.TryParse(SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "end"), out dateTime))
                {
                    dtpEnd.Value = dateTime;
                }
                AddBrowserToPanel(CefBrowser(txtAddress.Text));
            }
        }

        private void btnLoadStockData_Click(object sender, EventArgs e)
        {
            LoadStockDataAsync();

        }

        private async Task LoadStockDataAsync()
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            var htmlSource = await browser.GetSourceAsync();
            doc.LoadHtml(htmlSource);
            IEnumerable<HtmlNode> nodes = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("dashboard_v2"));

            foreach (HtmlNode node in nodes)
            {
                txtCurrentStockPrice.Text = node.InnerText;
                var dataValue = node.InnerText.Replace("&nbsp;", "|");
                var dataValues = dataValue.Split('|');
                txtCurrentStockPrice.Text = dataValues[1];
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            BuyStock();

        }

        private void BuyStock()
        {
            if (txtBalance.Text != "")
            {
                double balance = double.Parse(txtBalance.Text);
                double currentStockPrice = double.Parse(txtCurrentStockPrice.Text);
                double amountToBuy = Math.Round(balance / currentStockPrice, 0, MidpointRounding.AwayFromZero);
                double buyingPrice = amountToBuy * currentStockPrice;
                double balanceLeft = balance - buyingPrice;
                if(balanceLeft < 0)
                {
                    amountToBuy -= 1;
                    buyingPrice = amountToBuy * currentStockPrice;
                    balanceLeft = balance - buyingPrice;
                }

                txtBalance.Text = balanceLeft.ToString();
                txtOwnedStocks.Text = amountToBuy.ToString();
                txtCurrentStockValue.Text = buyingPrice.ToString();
                txtByingPrice.Text = currentStockPrice.ToString();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SellStock();
        }

        private void SellStock()
        {
            if (txtBalance.Text != "")
            {
                double balance = double.Parse(txtBalance.Text);
                double currentStockPrice = double.Parse(txtCurrentStockPrice.Text);
                double amountSell = double.Parse(txtOwnedStocks.Text);
                double sellingPrice = amountSell * currentStockPrice;
                double balanceLeft = balance + sellingPrice;
                txtBalance.Text = balanceLeft.ToString();
                txtOwnedStocks.Text = "0";
                txtCurrentStockValue.Text = "0";
                txtStockSellingPrice.Text = currentStockPrice.ToString();
            }
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            CalculateValueChange();
        }

        private void CalculateValueChange()
        {
            double currentStockPrice = double.Parse(txtCurrentStockPrice.Text);
            double owned = double.Parse(txtOwnedStocks.Text);
            double currentValue = owned * currentStockPrice;

            double originalStockPrice = double.Parse(txtByingPrice.Text);
            double originalValue = owned * originalStockPrice;

            double valueChange = currentValue - originalValue;

            txtCurrentStockValue.Text = currentValue.ToString();

            txtStockValueChange.Text = valueChange.ToString();

        }

        private void btnStartAutoTrade_Click(object sender, EventArgs e)
        {
            stockTimer.Start();
            picRunning.Visible = true;
            //testTimer.Start();
        }

        private void btnStopAutoTrade_Click(object sender, EventArgs e)
        {
            picRunning.Visible = false;
            stockTimer.Stop();
            //testTimer.Stop();
        }

        private void stockTimer_Tick(object sender, EventArgs e)
        {
            AnalyzeStockData();
        }

        private void AnalyzeStockData()
        {
            browser.Reload();
            
           
           
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            if (sell)
            {
                SellStock();
                sell = false;
            }
            else
            {
                BuyStock();
                sell = true;
            }
        }
    }
}
