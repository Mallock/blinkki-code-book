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
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Blinkki_CB
{
    public partial class WindowsApp : DockContent
    {

        public WindowsApp()
        {
            InitializeComponent();
        }

        public void OpenCalc()
        {
           
            Process p = Process.Start("Calc.exe");

        }

        internal void OpenMsc()
        {
            Process p = Process.Start("msconfig.exe");
        }
    }
}
