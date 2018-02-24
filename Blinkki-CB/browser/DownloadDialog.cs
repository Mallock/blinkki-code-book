using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;

namespace Blinkki_CB
{
    public partial class DownloadDialog : Form
    {
        private DownloadItem dItem;
        public DownloadDialog(CefSharp.DownloadItem e)
        {
            InitializeComponent();
            dItem = e;
            pbDownload.Maximum = 100;
        }

        internal void UpdateDownloadStatus(DownloadItem e)
        {
            this.Text = e.FullPath;
            if(e.PercentComplete > 0 && e.PercentComplete <= 100)
            {
                pbDownload.Value = e.PercentComplete;
            }
        }

        
    }
}
