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
                return cwb;
            }
            
 
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
                DateTime dateTime;
                if (DateTime.TryParse(SettingsReadWrite.INIRead(CurrentStockSettings, "SETTINGS", "start"), out dateTime))
                {
                    dtpStart.Value=dateTime;
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

            foreach(HtmlNode node in nodes)
            {
                txtCurrentStockPrice.Text = node.InnerText;
                var dataValue = node.InnerText.Replace("&nbsp;","|");
                var dataValues = dataValue.Split('|');
                txtCurrentStockPrice.Text = dataValues[1];
            }
        }
    }
}
