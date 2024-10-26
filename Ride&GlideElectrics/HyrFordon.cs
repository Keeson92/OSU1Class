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
        private readonly Affärslager _affärslager;

        public HyrFordon()
        {
            InitializeComponent();
            _affärslager = new Affärslager();

        }

        private void btnTillbakaTillUserMenu_Click(object sender, EventArgs e)
        {
            UserMenu usermenu = new UserMenu();

            usermenu.Show();
            this.Close();

        }

        private void btn_Allégatan_Click(object sender, EventArgs e)
        {
            listBoxFordon.Items.Clear();
            var fordonPåAllegatan = _affärslager.GetFordonByStation("Allégatan");

            foreach (var fordon in fordonPåAllegatan)
            {
                listBoxFordon.Items.Add($"{fordon.Typ} - {fordon.Status} (ID: {fordon.ID})");
            }

            listBoxFordon.Tag = fordonPåAllegatan; // Spara fordonslistan för vidare hantering
        }

        private void btn_Stationsgatan_Click(object sender, EventArgs e)
        {
            listBoxFordon.Items.Clear();
            var fordonPåStationsgatan = _affärslager.GetFordonByStation("Stationsgatan");

            foreach (var fordon in fordonPåStationsgatan)
            {
                listBoxFordon.Items.Add($"{fordon.Typ} - {fordon.Status} (ID: {fordon.ID})");
            }

            listBoxFordon.Tag = fordonPåStationsgatan; // Spara fordonslistan för vidare hantering
        }

        private void btn_Fredriksbergsgatan_Click(object sender, EventArgs e)
        {
            listBoxFordon.Items.Clear();
            var fordonPåFredriksbergsgatan = _affärslager.GetFordonByStation("Fredriksbergsgatan");

            foreach (var fordon in fordonPåFredriksbergsgatan)
            {
                listBoxFordon.Items.Add($"{fordon.Typ} - {fordon.Status} (ID: {fordon.ID})");
            }

            listBoxFordon.Tag = fordonPåFredriksbergsgatan; // Spara fordonslistan för vidare hantering
        }
        private void btn_Solrosvägen_Click(object sender, EventArgs e)
        {
            listBoxFordon.Items.Clear();
            var fordonPåSolrosvägen = _affärslager.GetFordonByStation("Solrosvägen");

            foreach (var fordon in fordonPåSolrosvägen)
            {
                listBoxFordon.Items.Add($"{fordon.Typ} - {fordon.Status} (ID: {fordon.ID})");
            }

            listBoxFordon.Tag = fordonPåSolrosvägen; // Spara fordonslistan för vidare hantering
        }

    }
}
