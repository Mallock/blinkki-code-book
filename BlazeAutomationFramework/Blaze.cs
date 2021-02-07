using BlazeAutomationFramework.Editor;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace BlazeAutomationFramework
{
    public partial class Blaze : Form
    {
        public string SettingsPath = System.IO.Directory.GetCurrentDirectory() + "\\Settings.ini";

        public Blaze()
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
            dockPanel.Theme = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            DockPaneStripSkin dockPaneSkin = new DockPaneStripSkin();
            dockPaneSkin.DocumentGradient.DockStripGradient.LinearGradientMode = LinearGradientMode.Vertical;
            dockPaneSkin.DocumentGradient.DockStripGradient.StartColor = Color.Silver;
            dockPaneSkin.DocumentGradient.DockStripGradient.EndColor = Color.White;

            dockPaneSkin.DocumentGradient.ActiveTabGradient.StartColor = Color.White;
            dockPaneSkin.DocumentGradient.ActiveTabGradient.EndColor = Color.White;
            dockPaneSkin.DocumentGradient.ActiveTabGradient.TextColor = Color.FromArgb(32, 32, 32);
            
            dockPaneSkin.DocumentGradient.InactiveTabGradient.LinearGradientMode = LinearGradientMode.Vertical;
            dockPaneSkin.DocumentGradient.InactiveTabGradient.StartColor = Color.Silver;
            dockPaneSkin.DocumentGradient.InactiveTabGradient.EndColor = Color.WhiteSmoke;
            dockPaneSkin.DocumentGradient.InactiveTabGradient.TextColor = Color.White;



            dockPanel.ShowDocumentIcon = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlazeEditor bedit= new BlazeEditor();
            bedit.Show(dockPanel);
        }



        private void nordeaStockTraderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trading.NordeaStock nStock = new Trading.NordeaStock();
            nStock.Show(dockPanel);
        }
    }
}
