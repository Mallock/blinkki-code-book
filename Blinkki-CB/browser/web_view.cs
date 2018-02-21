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
namespace Blinkki_CB
{
    public partial class web_view : DockContent
    {
        
        private string url { get; set; }
        public string loadedUrl { get; set; }
        public string title { get; set; }
        private Blinkki frm { get; set; }
        private ChromiumWebBrowser browser;
        public web_view(Blinkki window, string url)
        {
            this.url = url;
            this.frm = window;

            InitializeComponent();
            if (!Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                this.url = "https://www.google.com/?gws_rd=ssl#q=" + Uri.EscapeDataString(url);
            }
            this.Text = url;
            this.title = url;
        }

        private ChromiumWebBrowser CefBrowser(string url)
        {

            ChromiumWebBrowser cwb = new ChromiumWebBrowser(url)
            {
                Dock = DockStyle.Fill
            };

            return cwb;
        }


        private void AddBrowserToPanel(ChromiumWebBrowser brw)
        {
            browser = brw;
            this.pnlBrowser.Controls.Add(browser);
            while (!this.IsHandleCreated) // added
                System.Threading.Thread.Sleep(100); //added
            frm.BeginInvoke(((Action)(() => frm.CurrentUrl(this.loadedUrl))));
            UpdateIcon(this.loadedUrl);
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
                Image tmpimg = null;
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create("http://www.google.com/s2/favicons?domain=" + url);
                HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream stream = httpWebReponse.GetResponseStream();
                tmpimg = Image.FromStream(stream);
                Bitmap bitmap = new Bitmap(tmpimg);
                bitmap.SetResolution(16, 16);
                Icon icon = System.Drawing.Icon.FromHandle(bitmap.GetHicon());
                this.Icon = icon;
            }
            catch
            {
            }
        }

        public void ShowContextMenu(string link)
        {
            //openLinkInToolStripMenuItem.Tag = link;
            //browserContextMenu.Show(Control.MousePosition);
            LoadUrl(link);
        }

        private void web_view_Load(object sender, EventArgs e)
        {
            UpdateIcon(this.url);
        }

        private void openLinkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm.BeginInvoke(((Action)(() => frm.OpenNewTab(openLinkInToolStripMenuItem.Tag.ToString()))));
            LoadUrl(openLinkInToolStripMenuItem.Tag.ToString());
        }

    }
 

    class MyClient : WebClient
    {
        public bool HeadOnly { get; set; }
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest req = base.GetWebRequest(address);
            if (HeadOnly && req.Method == "GET")
            {
                req.Method = "HEAD";
            }
            return req;
        }
    }

}
