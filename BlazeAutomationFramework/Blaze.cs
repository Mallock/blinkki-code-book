using BlazeAutomationFramework.Editor;
using Blinkki_CB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace BlazeAutomationFramework
{
    public partial class Blaze : Form
    {
        public Blaze()
        {
            InitializeComponent();
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

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web_view web = new web_view(null, "https://www.google.com/");
            web.Show(dockPanel);
        }
    }
}
