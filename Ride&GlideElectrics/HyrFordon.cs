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
            InitializeHyrFordon();
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

            // Filtrera för att bara visa fordon som är "Ledig"
            var ledigaFordon = fordonPåAllegatan
                                .Where(fordon => fordon.Status == "Ledig")
                                .ToList();

            // Kolla om det finns några lediga fordon
            if (ledigaFordon.Count == 0)
            {
                MessageBox.Show("Inga lediga fordon på Allégatan.");
                listBoxFordon.Tag = null; // Ingen fordon att välja
                return; // Avsluta metoden
            }

            foreach (var fordon in ledigaFordon)
            {
                listBoxFordon.Items.Add($"{fordon.FordonsTyp} - {fordon.Status} (ID: {fordon.FordonsID})");
            }

            listBoxFordon.Tag = ledigaFordon; // Spara den filtrerade fordonslistan för vidare hantering

        }

        private void btn_Stationsgatan_Click(object sender, EventArgs e)
        {
            listBoxFordon.Items.Clear();
            var fordonPåStationsgatan = _affärslager.GetFordonByStation("Stationsgatan");

            // Filtrera för att bara visa fordon som är "Ledig"
            var ledigaFordon = fordonPåStationsgatan
                                .Where(fordon => fordon.Status == "Ledig")
                                .ToList();

            // Kolla om det finns några lediga fordon
            if (ledigaFordon.Count == 0)
            {
                MessageBox.Show("Inga lediga fordon på Stationsgatan.");
                listBoxFordon.Tag = null; // Ingen fordon att välja
                return; // Avsluta metoden
            }

            foreach (var fordon in ledigaFordon)
            {
                listBoxFordon.Items.Add($"{fordon.FordonsTyp} - {fordon.Status} (ID: {fordon.FordonsID})");
            }

            listBoxFordon.Tag = ledigaFordon; // Spara den filtrerade fordonslistan för vidare hantering
        }

        private void btn_Fredriksbergsgatan_Click(object sender, EventArgs e)
        {
            listBoxFordon.Items.Clear();
            var fordonPåFredriksbergsgatan = _affärslager.GetFordonByStation("Fredriksbergsgatan");

            // Filtrera för att bara visa fordon som är "Ledig"
            var ledigaFordon = fordonPåFredriksbergsgatan
                                .Where(fordon => fordon.Status == "Ledig")
                                .ToList();

            // Kolla om det finns några lediga fordon
            if (ledigaFordon.Count == 0)
            {
                MessageBox.Show("Inga lediga fordon på Fredriksbergsgatan.");
                listBoxFordon.Tag = null; // Ingen fordon att välja
                return; // Avsluta metoden
            }

            foreach (var fordon in ledigaFordon)
            {
                listBoxFordon.Items.Add($"{fordon.FordonsTyp} - {fordon.Status} (ID: {fordon.FordonsID})");
            }

            listBoxFordon.Tag = ledigaFordon; // Spara den filtrerade fordonslistan för vidare hantering
        }
        private void btn_Solrosvägen_Click(object sender, EventArgs e)
        {
            listBoxFordon.Items.Clear();
            var fordonPåSolrosvägen = _affärslager.GetFordonByStation("Solrosvägen");

            // Filtrera för att bara visa fordon som är "Ledig"
            var ledigaFordon = fordonPåSolrosvägen
                                .Where(fordon => fordon.Status == "Ledig")
                                .ToList();

            // Kolla om det finns några lediga fordon
            if (ledigaFordon.Count == 0)
            {
                MessageBox.Show("Inga lediga fordon på Solrosvägen.");
                listBoxFordon.Tag = null; // Ingen fordon att välja
                return; // Avsluta metoden
            }

            foreach (var fordon in ledigaFordon)
            {
                listBoxFordon.Items.Add($"{fordon.FordonsTyp} - {fordon.Status} (ID: {fordon.FordonsID})");
            }

            listBoxFordon.Tag = ledigaFordon; // Spara den filtrerade fordonslistan för vidare hantering
        }
        private void btn_StartaUthyrning_Click(object sender, EventArgs e)
        {
            if (listBoxFordon.SelectedIndex == -1)
            {
                MessageBox.Show("Vänligen välj ett fordon från listan.");
                return;
            }

            // Hämta det valda fordonet baserat på indexet i listBoxFordon
            var fordonList = listBoxFordon.Tag as List<Fordon>; // Använd as för att undvika exception
            if (fordonList == null || fordonList.Count == 0)
            {
                MessageBox.Show("Inga fordon valda.");
                return;
            }

            var valtFordon = fordonList[listBoxFordon.SelectedIndex];

            // Sätt uthyrningsinformationen - exempelvis nuvarande tid som start
            var uthyrningStart = DateTime.Now;
            var uthyrningSlut = uthyrningStart.AddHours(2); // Exempel på hyresperiod, här 2 timmar

            // Skapa en ny UthyrningsData och spara i uthyrningshistoriken
            var uthyrningData = new UthyrningsData(uthyrningStart, uthyrningSlut, valtFordon.FordonsID);
            var uthyrningsRepo = new UthyrningsDataRepository();
            uthyrningsRepo.GetAllUthyrningsData().Add(uthyrningData); // Lägg till i uthyrningslistan

            MessageBox.Show($"Uthyrning startad för fordon {valtFordon.FordonsTyp} med ID: {valtFordon.FordonsID}.");
        }
    }
}
