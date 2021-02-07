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

namespace BlazeAutomationFramework.Trading
{
    public partial class NordeaStock : DockContent
    {
        private ChromiumWebBrowser browser;

        public NordeaStock()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBrowserToPanel(CefBrowser("https://www.google.com/"));
        }

        private void AddBrowserToPanel(ChromiumWebBrowser brw)
        {
            browser = brw;
            this.pnlBrowser.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            while (!this.IsHandleCreated) // added
                System.Threading.Thread.Sleep(100); //added
        }

        private ChromiumWebBrowser CefBrowser(string url)
        {
            ChromiumWebBrowser cwb = new ChromiumWebBrowser(url);
            return cwb;
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
    }
}
