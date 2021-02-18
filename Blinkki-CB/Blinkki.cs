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
using System.IO;

namespace Blinkki_CB
{
    public partial class Blinkki : Form
    {
        public Blinkki()
        {
            InitializeComponent();
            Cef.EnableHighDPISupport();
            Cef.AddDisposable(this);

            CefSettings settings = new CefSettings();
            settings.CachePath = System.IO.Path.GetTempPath();

            //settings.CefCommandLineArgs.Add("enable-npapi", "1");
            settings.Locale = CultureInfo.CurrentCulture.Name;
            settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:68.0) Gecko/20100101 Firefox/68.0";

            Cef.Initialize(settings);

            dockPanel.DocumentStyle = DocumentStyle.DockingWindow;
            //dockPanel.DocumentTabStripLocation = DocumentTabStripLocation.Bottom;

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

            Font theFont = new Font("SegoeUI", 10.0F, FontStyle.Regular );

            foreach (Control theControl in (GetAllControls(this)))
            {
                theControl.Font = theFont;
            }

        }
        public static IEnumerable<Control> GetAllControls(Control aControl)
        {
            Stack<Control> stack = new Stack<Control>();

            stack.Push(aControl);

            while (stack.Any())
            {
                var nextControl = stack.Pop();

                foreach (Control childControl in nextControl.Controls)
                {
                    stack.Push(childControl);
                }

                yield return nextControl;
            }
        }
        public void Title(string title)
        {
            this.Text = title;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnChat_Click(object sender, EventArgs e)
        {
            OpenNewChat("https://tlk.io/blinkki-cb");
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsApp app = new WindowsApp();
            app.OpenCalc();
        }

        internal void AddDownloadDock(DownloadDialog download)
        {
            download.Show();
            ///download.Show(dockPanel, DockState.DockBottom);
        }

        private void microsoftMangementConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsApp app = new WindowsApp();
            app.OpenMsc();
        }

        private void Blinkki_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void btnBlinkki_Click(object sender, EventArgs e)
        {
            OpenNewTab("https://code.blinkki.com/");
        }

        private void btnFavs_Click(object sender, EventArgs e)
        {
            if (File.Exists(System.IO.Directory.GetCurrentDirectory() + "/fav.html"))
            {
                OpenNewTab(System.IO.Directory.GetCurrentDirectory() + "/fav.html");
            }
        }


        private void Blinkki_Shown(object sender, EventArgs e)
        {
            
            OpenNewTab("https://code.blinkki.com/");
            LoadFavouriteTools();
        }

        private void LoadFavouriteTools()
        {
            Favourites favs = new Favourites();
            favs.LoadFavTable();
            DataRowCollection rc = favs.GetFavs();
            foreach (DataRow r in rc)
            {
                ToolStripItem tItem = new ToolStripButton();
                tItem.Tag = r[0].ToString();
                tItem.Text = "";
                tItem.ToolTipText = r[0].ToString();
                tItem.ImageScaling = ToolStripItemImageScaling.None;
                Bitmap ico = favs.BytesToBitmap((byte[])r[2]);
                tItem.Image = ico;
                tItem.Click += TItem_Click;
                mainTools.Items.Add(tItem);  
            }
        }

        private void TItem_Click(object sender, EventArgs e)
        {
            ToolStripItem tItem = (ToolStripItem)sender;
            OpenNewTab(tItem.Tag.ToString());
        }

        private void registryEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsApp app = new WindowsApp();
            app.OpenRegEdit();
        }
    }
}
