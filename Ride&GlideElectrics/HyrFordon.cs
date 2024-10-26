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
                listBoxFordon.Items.Add($"{fordon.FordonsTyp}  -  {fordon.Status}  (ID:  {fordon.FordonsID})");
            }

            listBoxFordon.Tag = fordonPåAllegatan; // Spara fordonslistan för vidare hantering
        }

        private void btn_Stationsgatan_Click(object sender, EventArgs e)
        {
            listBoxFordon.Items.Clear();
            var fordonPåStationsgatan = _affärslager.GetFordonByStation("Stationsgatan");

            foreach (var fordon in fordonPåStationsgatan)
            {
                listBoxFordon.Items.Add($"{fordon.FordonsTyp} - {fordon.Status} (ID: {fordon.FordonsID})");
            }

            listBoxFordon.Tag = fordonPåStationsgatan; // Spara fordonslistan för vidare hantering
        }

        private void btn_Fredriksbergsgatan_Click(object sender, EventArgs e)
        {
            listBoxFordon.Items.Clear();
            var fordonPåFredriksbergsgatan = _affärslager.GetFordonByStation("Fredriksbergsgatan");

            foreach (var fordon in fordonPåFredriksbergsgatan)
            {
                listBoxFordon.Items.Add($"{fordon.FordonsTyp} - {fordon.Status} (ID: {fordon.FordonsID})");
            }

            listBoxFordon.Tag = fordonPåFredriksbergsgatan; // Spara fordonslistan för vidare hantering
        }
        private void btn_Solrosvägen_Click(object sender, EventArgs e)
        {
            listBoxFordon.Items.Clear();
            var fordonPåSolrosvägen = _affärslager.GetFordonByStation("Solrosvägen");

            foreach (var fordon in fordonPåSolrosvägen)
            {
                listBoxFordon.Items.Add($"{fordon.FordonsTyp} - {fordon.Status} (ID: {fordon.FordonsID})");
            }

            listBoxFordon.Tag = fordonPåSolrosvägen; // Spara fordonslistan för vidare hantering
        }
        private void btn_StartaUthyrning_Click(object sender, EventArgs e)
        {
            // Kontrollera om ett fordon är valt
            if (listBoxFordon.SelectedIndex == -1)
            {
                MessageBox.Show("Vänligen välj ett fordon från listan.");
                return;
            }

            // Hämta det valda fordonet baserat på indexet i listBoxFordon
            var fordonLista = (List<Fordon>)listBoxFordon.Tag;
            var valtFordon = fordonLista[listBoxFordon.SelectedIndex];

            // Sätt uthyrningsinformationen - exempelvis nuvarande tid som start
            var uthyrningStart = DateTime.Now;
            var uthyrningSlut = uthyrningStart.AddHours(2); // Exempel på hyresperiod, här 2 timmar

            // Starta uthyrningen
            _affärslager.StartaUthyrning(valtFordon.FordonsID, uthyrningStart, uthyrningSlut);

            // Skapa en ny UthyrningsData och spara i uthyrningshistoriken
            var uthyrningData = new UthyrningsData(uthyrningStart, uthyrningSlut, valtFordon.FordonsID);
            var uthyrningsRepo = new UthyrningsDataRepository();
            uthyrningsRepo.GetAllUthyrningsData().Add(uthyrningData); // Lägg till i uthyrningslistan

            MessageBox.Show($"Uthyrning startad för fordon {valtFordon.FordonsTyp} med ID: {valtFordon.FordonsID}.");
        }
    }
}
