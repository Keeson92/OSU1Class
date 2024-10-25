using System;
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
    public partial class HyrFordon : Form
    {
        public HyrFordon()
        {
            InitializeComponent();
        }

        private void btnTillbakaTillUserMenu_Click(object sender, EventArgs e)
        {
            HuvudFönster huvudfönster = new HuvudFönster();

            huvudfönster.Show();
            this.Close();

        }
    }
}
