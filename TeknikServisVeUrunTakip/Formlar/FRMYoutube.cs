﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMYoutube : Form
    {
        public FRMYoutube()
        {
            InitializeComponent();
        }

        private void FRMYoutube_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("youtube.com");
        }
    }
}
