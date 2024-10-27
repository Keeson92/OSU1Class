using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicelager;
using BusinessEntities;

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
            UserMenu usermenu = new UserMenu();

            usermenu.Show();
            this.Close();

        }

        private void btn_Allégatan_Click(object sender, EventArgs e)
        {

        }

        private void btn_Stationsgatan_Click(object sender, EventArgs e)
        {

        }

        private void btn_Fredriksbergsgatan_Click(object sender, EventArgs e)
        {

        }

        private void btn_Solrosvägen_Click(object sender, EventArgs e)
        {

        }
    }
}
