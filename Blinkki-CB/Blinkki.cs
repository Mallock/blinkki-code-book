﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blinkki_CB
{
    public partial class Blinkki : Form
    {
        public Blinkki()
        {
            InitializeComponent();
        }

        public void Title(string title)
        {
            this.Text = title;

        }

        public void CurrentUrl(string url)
        {

        }

    }
}
