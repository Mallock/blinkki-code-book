using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using CefSharp;
using CefSharp.WinForms;
using System.Globalization;
using System.Drawing.Drawing2D;

namespace Blinkki_CB
{
    public partial class Blinkki : Form
    {
        public Blinkki()
        {
            InitializeComponent();

            CefSettings settings = new CefSettings();
            settings.CachePath = System.IO.Path.GetTempPath();
            settings.Locale = CultureInfo.CurrentCulture.Name;
            Cef.Initialize(settings);

            dockPanel.DocumentStyle = DocumentStyle.DockingWindow;
            dockPanel.Theme = new WeifenLuo.WinFormsUI.Docking.VS2012LightTheme();
            DockPaneStripSkin dockPaneSkin = new DockPaneStripSkin();
            dockPaneSkin.DocumentGradient.DockStripGradient.LinearGradientMode = LinearGradientMode.Vertical;
            dockPaneSkin.DocumentGradient.DockStripGradient.StartColor = Color.Silver;
            dockPaneSkin.DocumentGradient.DockStripGradient.EndColor = Color.White;

            dockPaneSkin.DocumentGradient.ActiveTabGradient.StartColor = Color.White;
            dockPaneSkin.DocumentGradient.ActiveTabGradient.EndColor = Color.White;
            dockPaneSkin.DocumentGradient.ActiveTabGradient.TextColor = Color.FromArgb(32, 32, 32);
            //dockPaneSkin.DocumentGradient.ActiveTabGradient.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            dockPaneSkin.DocumentGradient.InactiveTabGradient.LinearGradientMode = LinearGradientMode.Vertical;
            dockPaneSkin.DocumentGradient.InactiveTabGradient.StartColor = Color.Silver;
            dockPaneSkin.DocumentGradient.InactiveTabGradient.EndColor = Color.WhiteSmoke;
            dockPaneSkin.DocumentGradient.InactiveTabGradient.TextColor = Color.White;

           

            dockPanel.ShowDocumentIcon = true;

        }

        public void Title(string title)
        {
            this.Text = title;

        }

        public void CurrentUrl(string url)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStackOveflow_Click(object sender, EventArgs e)
        {
            OpenNewTab("https://stackoverflow.com/");
        }

        public void OpenNewTab(string url)
        {
            web_view web = new web_view(this, url);
            web.Show(dockPanel);
        }

        public void OpenNewChat(string url)
        {
            web_view web = new web_view(this, url, false);
            web.Show(dockPanel, DockState.DockLeft);
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            OpenNewTab("https://www.google.com/");
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            OpenNewTab("https://github.com/");
        }

        private void Blinkki_Shown(object sender, EventArgs e)
        {
            OpenNewTab("https://www.google.com/");
        }

        private void btnIconFinder_Click(object sender, EventArgs e)
        {
            OpenNewTab("https://www.iconfinder.com/");
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            OpenNewChat("https://tlk.io/blinkki-cb");
        }
    }
}
