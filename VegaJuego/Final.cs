﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegaJuego
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void Final_FormClossed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Level1_FormClossed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
