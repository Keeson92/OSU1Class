﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ride_GlideElectrics
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHyrFordon_Click(object sender, EventArgs e)
        {

            HyrFordon hyrfordon = new HyrFordon();
            hyrfordon.Show();
            this.Hide();
        }
    }
}
