using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using CefSharp;
using CefSharp.WinForms;
using System.Threading;
using System.Net;
using System.IO;
using System.Globalization;
using Blinkki_CB.api.internet;
using System.Drawing.Drawing2D;

namespace Blinkki_CB
{
    public partial class web_view : DockContent
    {

        private string url { get; set; }
        public string loadedUrl { get; set; }
        public string title { get; set; }
        private Blinkki frm { get; set; }
        private ChromiumWebBrowser browser;
        private SearchSuggestionsAPI searchAPI = new SearchSuggestionsAPI();
        Favourites favs = new Favourites();
        private List<DownloadDialog> listOfDownloadItems = new List<DownloadDialog> { };
        private bool bUrlFocused = false;

        public web_view(Blinkki window, string url, bool hideTools = true)
        {
            this.url = url;
            this.frm = window;

            InitializeComponent();

            this.txtToolUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtToolUrl_KeyUp);
            this.txtToolUrl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtToolUrl_MouseUp);
            this.txtToolUrl.TextChanged += new System.EventHandler(this.txtToolUrl_TextChanged);
            this.txtToolUrl.Leave += TxtToolUrl_Leave;

            this.browserTools.Visible = hideTools;
            if (!Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute) && !url.Contains("/fav.html"))
            {
                this.url = "https://www.google.com/?gws_rd=ssl#q=" + Uri.EscapeDataString(url);
            }
            this.Text = url;
            this.title = url;

            browserTools.Renderer = new MainFormToolStripRenderer();
            favs.LoadFavTable();
            btnFav.DropDownItemClicked += new ToolStripItemClickedEventHandler(btnFav_DropDownItemClicked);
        }

        private void TxtToolUrl_Leave(object sender, EventArgs e)
        {
            bUrlFocused = false;
        }

        private void btnFav_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frm.OpenNewTab(e.ClickedItem.Tag.ToString());

            favs.UpdateFavLink(e.ClickedItem.Tag.ToString());
        }

        private ChromiumWebBrowser CefBrowser(string url)
        {

            ChromiumWebBrowser cwb = new ChromiumWebBrowser(url);
            
            
            IcatLifespanHandler life = new IcatLifespanHandler();
            DownloadHandler download = new DownloadHandler();

            download.OnBeforeDownloadFired += Download_OnBeforeDownloadFired;
            download.OnDownloadUpdatedFired += Download_OnDownloadUpdatedFired;
            download.OnDownloadUpdatedFiredCallBack += Download_OnDownloadUpdatedFiredCallBack;

            life.frm = this.frm;
            cwb.DownloadHandler = download;
            cwb.LifeSpanHandler = life;
            cwb.AddressChanged += Cwb_AddressChanged;
            cwb.TitleChanged += Cwb_TitleChanged;
            return cwb;
        }

        private void Download_OnDownloadUpdatedFiredCallBack(object sender, IDownloadItemCallback e)
        {
            foreach (DownloadDialog dwnload in listOfDownloadItems)
            {
                if (dwnload.Visible == false)
                {
                    e.Cancel();
                }
            }
        }

        private void Download_OnDownloadUpdatedFired(object sender, DownloadItem e)
        {
            bool allComplete = false;
            foreach (DownloadDialog dwnload in listOfDownloadItems)
            {
                dwnload.UpdateDownloadStatus(e);
                if (e.IsCancelled || e.IsComplete)
                {
                    allComplete = true;
                }else
                {
                    allComplete = false;
                }
                if (dwnload.Visible==false)
                {
                    if (e.FullPath == dwnload.dItem.FullPath)
                    {
                        e.IsCancelled = true;
                    }
                } 
            }

            if (allComplete)
            {
                listOfDownloadItems.Clear();
            }
        }

        private void Download_OnBeforeDownloadFired(object sender, DownloadItem e)
        {
            DownloadDialog download = new DownloadDialog(e);
            listOfDownloadItems.Add(download);
            frm.AddDownloadDock(download);
        }

        private void Cwb_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            if (this.browser != null)
            {
                this.BeginInvoke(((Action)(() => this.Text = e.Title)));
            }   
        }

        private void Cwb_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.loadedUrl = e.Address;
            while (!this.IsHandleCreated) // added
                System.Threading.Thread.Sleep(100); //added
            this.BeginInvoke(((Action)(() => this.txtToolUrl.Text = this.loadedUrl)));
            this.BeginInvoke((Action)(() => UpdateIcon(this.loadedUrl)));
        }

        private void AddBrowserToPanel(ChromiumWebBrowser brw)
        {
            browser = brw;
            this.pnlBrowser.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            while (!this.IsHandleCreated) // added
                System.Threading.Thread.Sleep(100); //added
            frm.BeginInvoke(((Action)(() => this.CurrentUrl(this.loadedUrl))));
            this.BeginInvoke((Action)(() => UpdateIcon(this.loadedUrl)));
        }

        private void CurrentUrl(string url)
        {
            if (url != null)
            {
                if (url.Equals("file:///" + System.IO.Directory.GetCurrentDirectory().Replace("\\", "/") + "/fav.html"))
                {
                    this.txtToolUrl.Text = "";
                    this.txtToolUrl.Focus();
                }
                else
                {
                    this.txtToolUrl.Text = url;
                    CheckFavIcon();
                }
            }
        }

        private void web_view_Shown(object sender, EventArgs e)
        {
            if (Cef.IsInitialized)
            {
                AddBrowserToPanel(CefBrowser(this.url));
            }
        }


        public void LoadUrl(string url)
        {

            if (!url.StartsWith("http") && !url.Contains("."))
            {
                url = "https://www.google.com/?gws_rd=ssl#q=" + Uri.EscapeDataString(url);
            }
            browser.Load(url);
        }


        public void Stop()
        {
            browser.Stop();
        }

        public void Print()
        {
            browser.Print();
        }

        public void ShowDevTools()
        {
            browser.ShowDevTools();
        }

        public void Back()
        {
            if (browser.CanGoBack)
            {
                browser.Back();
            }
        }

        public void Forward()
        {
            browser.Forward();
        }

        public void RefreshPage()
        {
            browser.Reload();
        }

        public void UpdateIcon(string url)
        {
            try
            {
                if (url != null && !url.Contains("file:/"))
                {
                    Image tmpimg = null;
                    HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create("http://www.google.com/s2/favicons?domain=" + url);
                    HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    Stream stream = httpWebReponse.GetResponseStream();
                    tmpimg = Image.FromStream(stream);
                    Bitmap bitmap = new Bitmap(tmpimg);
                    bitmap.SetResolution(16, 16);
                    Icon icon = System.Drawing.Icon.FromHandle(bitmap.GetHicon());
                    this.Icon = icon;
                    CheckFavIcon();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ShowContextMenu(string link)
        {            
            LoadUrl(link);
        }

        private void web_view_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() => UpdateIcon(this.loadedUrl)));
            this.Refresh();
        }

        private void openLinkInToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            LoadUrl(openLinkInToolStripMenuItem.Tag.ToString());
        }

        private void txtToolUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstSuggestions.Visible = false;
                LoadUrl(txtToolUrl.Text);
                lstSuggestions.Items.Clear();
                lstSuggestions.Visible = false;
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (e.KeyCode == Keys.Up && this.lstSuggestions.SelectedIndex - 1 > -1)
                {
                    lstSuggestions.SelectedIndex--;
                }
                else
                {
                    lstSuggestions.SelectedIndex = lstSuggestions.Items.Count - 1;
                }
            }
            if (e.KeyCode == Keys.Down && this.lstSuggestions.SelectedIndex + 1 < this.lstSuggestions.Items.Count)
            {
                lstSuggestions.SelectedIndex++;
            }
        }

        private void txtToolUrl_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtToolUrl.SelectedText == "" && bUrlFocused == false)
            {
                txtToolUrl.SelectAll();
                bUrlFocused = true;
            }
        }

        private void txtToolUrl_TextChanged(object sender, EventArgs e)
        {
            if (txtToolUrl.Focused)
            {
                if (lstSuggestions.SelectedItem == null)
                {
                    this.BeginInvoke(((Action)(() => searchAPI.StartSearchSuggestions(txtToolUrl.Text, this))));
                }
            }
        }

        public void UpdateSearchSuggestions(string[] suggestions)
        {
            if (suggestions.Length > 0)
            {
                lstSuggestions.Visible = true;
                lstSuggestions.Items.Clear();
                lstSuggestions.Items.AddRange(suggestions.ToArray());
            }
            else
            {
                lstSuggestions.Visible = false;
                lstSuggestions.Items.Clear();
                lstSuggestions.Items.AddRange(suggestions.ToArray());
            }
        }

        private void lstSuggestions_MouseDown(object sender, MouseEventArgs e)
        {
            int index = lstSuggestions.IndexFromPoint(e.Location);
            lstSuggestions.SelectedIndex = index;

            LoadUrl(lstSuggestions.SelectedItem.ToString());

            lstSuggestions.Items.Clear();
            lstSuggestions.Visible = false;
        }

        private void lstSuggestions_MouseHover(object sender, EventArgs e)
        {
            int index = lstSuggestions.IndexFromPoint(lstSuggestions.PointToClient(Cursor.Position));
            lstSuggestions.SelectedIndex = index;
        }

        private void lstSuggestions_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstSuggestions.IndexFromPoint(lstSuggestions.PointToClient(Cursor.Position));
            lstSuggestions.SelectedIndex = index;
        }

        private void lstSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSuggestions.SelectedItem != null)
            {
                txtToolUrl.Text = lstSuggestions.SelectedItem.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Back();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            this.Forward();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.RefreshPage();
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            if (browser != null)
            {
                if (this.loadedUrl != "" && this.Text != "")
                {
                    favs.SaveFavLink(this.loadedUrl, this.Text, this.Icon, 1);
                }
            }
            CheckFavIcon();
            favs.SaveFavTable();
        }

        private void CheckFavIcon()
        {
            if (favs.IsFav(this.txtToolUrl.Text))
            {
                btnFav.Image = Properties.Resources.fav;
            }
            else
            {
                btnFav.Image = Properties.Resources.no_fav;
            }
        }

        private void btnFav_MouseHover(object sender, EventArgs e)
        {
            if (btnFav.DropDown.Visible == false)
            {
                DataRowCollection rc = favs.GetFavs();
                btnFav.DropDownItems.Clear();
                foreach (DataRow r in rc)
                {
                    ToolStripItem tItem = new ToolStripMenuItem();
                    tItem.Tag = r[0].ToString();
                    tItem.Text = truncateString(r[1].ToString(), 100);
                    tItem.ImageScaling = ToolStripItemImageScaling.None;
                    Bitmap ico = favs.BytesToBitmap((byte[])r[2]);
                    tItem.Image = ico;
                    btnFav.DropDownItems.Add(tItem);
                }
                btnFav.ShowDropDown();
            }
        }

        public static string truncateString(string originalString, int length)
        {
            if (string.IsNullOrEmpty(originalString))
            {
                return originalString;
            }
            if (originalString.Length > length)
            {
                return originalString.Substring(0, length) + "...";
            }
            else
            {
                return originalString;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (File.Exists(System.IO.Directory.GetCurrentDirectory() + "/fav.html"))
            {
                LoadUrl(System.IO.Directory.GetCurrentDirectory() + "/fav.html");
            }
        }

        private void web_view_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.pnlBrowser.Controls.Remove(browser);            
            browser = null;
            Thread.Sleep(200); //Prevent browser close freezing
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            frm.OpenNewTab("https://www.google.com/");
        }
    }


    public class MainFormToolStripRenderer : ToolStripProfessionalRenderer
    {

        public MainFormToolStripRenderer()
        {
            this.RoundedEdges = false;

        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
        }


        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            //you may want to change this based on the toolstrip's dock or layout style
            LinearGradientMode mode = LinearGradientMode.Vertical;

            using (LinearGradientBrush b = new LinearGradientBrush(e.AffectedBounds, Color.White, Color.White, mode))
            {
                e.Graphics.FillRectangle(b, e.AffectedBounds);
            }
        }
    }


    class IcatLifespanHandler : ILifeSpanHandler
    {

        public Blinkki frm { get; set; }

        public bool DoClose(IWebBrowser browserControl, IBrowser browser)
        {
            return true;
        }

        public void OnAfterCreated(IWebBrowser browserControl, IBrowser browser)
        {

        }

        public void OnBeforeClose(IWebBrowser browser)
        {

        }

        public void OnBeforeClose(IWebBrowser browserControl, IBrowser browser)
        {

        }

        public bool OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            if (!targetUrl.Contains("oauth"))
            {
                frm.BeginInvoke(((Action)(() => frm.OpenNewTab(targetUrl))));
                newBrowser = null;

                return true;
            }
            else
            {
                newBrowser = null;

                return false;
            }
        }
    }

    public class DownloadHandler : IDownloadHandler
    {
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;
        
        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        public event EventHandler<IDownloadItemCallback> OnDownloadUpdatedFiredCallBack;


        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            var handler = OnBeforeDownloadFired;

            if (handler != null)
            {
                handler(this, downloadItem);
            }

            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    callback.Continue(downloadItem.SuggestedFileName, showDialog: true);
                }
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            var handler = OnDownloadUpdatedFired;

            if (handler != null)
            {
                handler(this, downloadItem);
                var cDownloadCallback = OnDownloadUpdatedFiredCallBack;
                if (callback != null) { cDownloadCallback(this, callback); }
            }
        }
    }
}



