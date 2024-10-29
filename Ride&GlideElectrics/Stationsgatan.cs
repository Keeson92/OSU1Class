using BusinessEntities;
using Ride_GlideElectrics;
using Servicelager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentationslager
{
    public partial class Stationsgatan : Form // Stationsgatan är en form som visar alla fordon som finns på Stationsgatan och tillåter användaren att boka ett fordon.
    {
        private UthyrningsDataRepository _uthyrningsRepo = new UthyrningsDataRepository(); // Repository for data access

        private List<Fordon> _fordonLista;
        public Stationsgatan() // Konstruktor för Stationsgatan
        {
            InitializeComponent();
            _uthyrningsRepo = new UthyrningsDataRepository(); // Initialize the repository
            _fordonLista = new List<Fordon>(); // Initialize the list
            InitializeData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // en metod som körs när en cell i datagridview klickas på
        {

        }
        private void InitializeData() // kopplar listan till datagrid
        {
            // initialize listan med fordon
            _fordonLista = FordonRepository.GetAllFordon();

            // visa bara värden som innehåller "Stationsgatan" och är lediga
            var filteredFordonLista = _fordonLista.Where(f => f.Position.Contains("Stationsgatan") && f.Status == "Ledig").ToList();

            // den sorterade listan skickas till datagrid
            dataGridView1.DataSource = filteredFordonLista;

            // Rubriker för kolumner
            dataGridView1.Columns["FordonsID"].HeaderText = "ID";
            dataGridView1.Columns["Position"].HeaderText = "Station";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["FordonsTyp"].HeaderText = "Typ utav fordon";
        }


        private void LoadUthyrningData() // Uppdaterar DataGridView med den senaste uthyrningsdatan
        {
            dataGridView1.DataSource = null; // Nollställ datakällan för att förbereda för uppdatering
            dataGridView1.DataSource = _uthyrningsRepo.GetAllUthyrningsData(); // Binda den uppdaterade listan
        }



        private void huvudmeny_Click(object sender, EventArgs e) // en metod som körs när huvudmeny-knappen klickas på
        {
            UserMenu usermenu = new UserMenu();
            usermenu.Show(); // öppnar huvudmenyn och stänger denna form                     
            this.Hide();
        }

        private void boka_Click(object sender, EventArgs e) // en metod som körs när boka-knappen klickas på
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vänligen välj ett fordon från listan.");
                return;
            }

            // Hämta valt fordon från DataGridView
            var valtFordon = (Fordon)dataGridView1.SelectedRows[0].DataBoundItem;
            var uthyrningStart = DateTime.Now;
            var uthyrningSlut = uthyrningStart.AddHours(2);
            var prisPerMinut = 10;

            // Skapa en ny UthyrningsData-instans
            var uthyrningData = new UthyrningsData(uthyrningStart, uthyrningSlut, valtFordon.FordonsID, prisPerMinut);

            // Lägg till uthyrningData i repository
            _uthyrningsRepo.AddUthyrningsData(uthyrningData);

            // Bekräfta för användaren
            MessageBox.Show($"Uthyrning startad för fordon {valtFordon.FordonsTyp} med ID: {valtFordon.FordonsID}.");

            // Uppdatera DataGridView för att visa den nya uthyrningen
            LoadUthyrningData();
        }
    }
}
