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
    public partial class Fredriksbergsgatan : Form // Fredriksbergsgatan är en form som visar alla fordon som finns på Fredriksbergsgatan och tillåter användaren att boka ett fordon.
    {
        private List<Fordon> _fordonLista;
        private UthyrningsDataRepository _uthyrningsRepo = new UthyrningsDataRepository();
        public Fredriksbergsgatan() // Konstruktor för Fredriksbergsgatan
        {
            InitializeComponent(); // Initialize formens konponenter
            _fordonLista = new List<Fordon>(); // Initializear listan för fordon
            InitializeData();// Initialize formens data
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // en metod som körs när en cell i datagridview klickas på
        {

        }
        private void InitializeData() // kopplar listan till datagrid
        {         
            
            _fordonLista = FordonRepository.GetAllFordon(); // Hämtar alla fordon från databasen


            // Filter the list to include only vehicles where Position contains "Allegatan"
            var filteredFordonLista = _fordonLista.Where(f => f.Position.Contains("Fredriksbergsgatan") && f.Status == "Ledig").ToList();

            // Set the filtered list as the DataSource for the DataGridView
            dataGridView1.DataSource = filteredFordonLista;

            // Set header text for the columns
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




        private void boka_Click(object sender, EventArgs e) // en metod som körs när boka-knappen klickas på
        {

            if (dataGridView1.SelectedRows.Count == 0) // Kontrollera att användaren har valt ett fordon
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

        private void huvudmeny_Click(object sender, EventArgs e) // en metod som körs när huvudmeny-knappen klickas på
        {
            UserMenu userMenu = new UserMenu();

            userMenu.Show();
            this.Hide();
        }
    }
}
