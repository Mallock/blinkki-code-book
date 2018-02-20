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
       
        Hashtable browserStack = new Hashtable();
        
        private string url { get; set; }
        public string loadedUrl { get; set; }
        public string title { get; set; }
        private Blinkki frm { get; set; }
        private int stackCount = 0;

        public web_view(Blinkki window, string url)
        {
            this.url = url;
            this.frm = window;

            InitializeComponent();
            if (!Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute) && !url.Contains("fav.html"))
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

                        
            if (!browserStack.ContainsKey(stackCount))
            {
                browserStack.Add(stackCount, cwb);
            }
            else
            {
                stackCount++;
                browserStack.Add(stackCount, cwb);
            }
            return cwb;
        }


        private void AddBrowserToPanel(int stackNo)
        {
            ((ChromiumWebBrowser)browserStack[stackNo]).Visible = true;
            this.pnlBrowser.Controls.Add(((ChromiumWebBrowser)browserStack[stackNo]));
            ((ChromiumWebBrowser)browserStack[stackNo]).ResumeLayout();
            if (((ChromiumWebBrowser)browserStack[stackNo]).GetBrowser().MainFrame.Url != null)
            {
                this.BeginInvoke(((Action)(() => this.Text = ((ChromiumWebBrowser)browserStack[stackNo]).GetBrowser().MainFrame.Url)));
                frm.BeginInvoke(((Action)(() => frm.Title(((ChromiumWebBrowser)browserStack[stackNo]).GetBrowser().MainFrame.Url))));
            }
            this.loadedUrl = ((ChromiumWebBrowser)browserStack[stackNo]).Address;
            while (!this.IsHandleCreated) // added
                System.Threading.Thread.Sleep(100); //added
            frm.BeginInvoke(((Action)(() => frm.CurrentUrl(this.loadedUrl))));
            UpdateIcon(this.loadedUrl);
        }

        private void RemoveBrowserFromPanel(int stackNo)
        {
            ((ChromiumWebBrowser)browserStack[stackNo]).Visible = false;
            this.pnlBrowser.Controls.Remove(((ChromiumWebBrowser)browserStack[stackNo]));
            ((ChromiumWebBrowser)browserStack[stackNo]).SuspendLayout();
        }

        private void web_view_Shown(object sender, EventArgs e)
        {

            if (Cef.IsInitialized)
            {
                CefBrowser(this.url);
                AddBrowserToPanel(stackCount);
            }
        }


        public void LoadUrl(string url, bool newBrowser)
        {

            if (!url.StartsWith("http") && !url.Contains("."))
            {
                url = "https://www.google.com/?gws_rd=ssl#q=" + Uri.EscapeDataString(url);
            }
            if (newBrowser)
            {
                CefBrowser(url);
                RemoveBrowserFromPanel(stackCount - 1);
                AddBrowserToPanel(stackCount);
            }
            else
            {
                ((ChromiumWebBrowser)browserStack[stackCount]).Load(url);
            }
            
        }


        public void Stop()
        {
            ((ChromiumWebBrowser)browserStack[stackCount]).Stop();
        }

        public void Print()
        {
            ((ChromiumWebBrowser)browserStack[stackCount]).Print();
        }

        public void ShowDevTools()
        {
            ((ChromiumWebBrowser)browserStack[stackCount]).ShowDevTools();
        }

        public void Back()
        {
            if (((ChromiumWebBrowser)browserStack[stackCount]).CanGoBack)
            {
                ((ChromiumWebBrowser)browserStack[stackCount]).Back();
            }
            else
            {
                if (browserStack.ContainsKey(stackCount - 1))
                {
                    RemoveBrowserFromPanel(stackCount);
                    AddBrowserToPanel(stackCount - 1);
                    ((ChromiumWebBrowser)browserStack[stackCount]).Dispose();
                    browserStack.Remove(stackCount);
                    stackCount--;
                }
                else
                {
                    ((ChromiumWebBrowser)browserStack[stackCount]).Back();
                }
            }
        }

        public void Forward()
        {
            ((ChromiumWebBrowser)browserStack[stackCount]).Forward();
        }

        public void RefreshPage()
        {
            ((ChromiumWebBrowser)browserStack[stackCount]).Reload();
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
            LoadUrl(link,true);
        }

        private void web_view_Load(object sender, EventArgs e)
        {
            UpdateIcon(this.url);
        }

        private void openLinkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm.BeginInvoke(((Action)(() => frm.OpenNewTab(openLinkInToolStripMenuItem.Tag.ToString()))));
            LoadUrl(openLinkInToolStripMenuItem.Tag.ToString(),true);
        }

        private void web_view_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.frm = null;
            pnlBrowser.Controls.Remove(((ChromiumWebBrowser)browserStack[stackCount]));
            Thread.Sleep(100);
            for (int i = 0; i < browserStack.Count; i++)
            {
                ((ChromiumWebBrowser)browserStack[i]).Dispose();
            }   
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
