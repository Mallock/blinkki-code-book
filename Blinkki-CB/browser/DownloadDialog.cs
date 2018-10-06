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
using WeifenLuo.WinFormsUI.Docking;

namespace Blinkki_CB
{
    public partial class DownloadDialog : DockContent
    {
        public DownloadItem dItem;
        public DownloadDialog() { }

            
        public DownloadDialog(CefSharp.DownloadItem e)
        {
            InitializeComponent();
            dItem = e;
            pbDownload.Maximum = 100;
           
        }

        static double ConvertBytesToMegabytes(long bytes)
        {
            return Math.Round((bytes / 1024f) / 1024f,2);
        }

        internal void UpdateDownloadStatus(DownloadItem e)
        {
            if(e.PercentComplete > 0 && e.PercentComplete <= 100)
            {
                pbDownload.Value = e.PercentComplete;
            }
            this.dItem = e;
            lblSpeed.Text = ConvertBytesToMegabytes(e.CurrentSpeed) + " MB/s";
            lblSize.Text = ConvertBytesToMegabytes(e.ReceivedBytes) + "/" + ConvertBytesToMegabytes(e.TotalBytes) + " MB";
            lblFile.Text = e.FullPath; 
        }

        
    }
}
