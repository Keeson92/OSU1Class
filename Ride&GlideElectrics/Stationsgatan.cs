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
    public partial class Stationsgatan : Form
    {
        private UthyrningsDataRepository _uthyrningsRepo = new UthyrningsDataRepository();




        private List<Fordon> _fordonLista;
        public Stationsgatan()
        {
            InitializeComponent();
            _uthyrningsRepo = new UthyrningsDataRepository(); // Initialize the repository
            _fordonLista = new List<Fordon>(); // Initialize the list
            InitializeData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeData() // kopplar listan till datagrid
        {
            // Initialize the list from in-memory data source
            _fordonLista = FordonRepository.GetAllFordon();

            // Filter the list to include only vehicles where Position contains "Stationsgatan"
            var filteredFordonLista = _fordonLista.Where(f => f.Position.Contains("Stationsgatan") && f.Status == "Ledig").ToList();

            // Set the filtered list as the DataSource for the DataGridView
            dataGridView1.DataSource = filteredFordonLista;

            // Set header text for the columns
            dataGridView1.Columns["FordonsID"].HeaderText = "ID";
            dataGridView1.Columns["Position"].HeaderText = "Station";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["FordonsTyp"].HeaderText = "Typ utav fordon";
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void LoadUthyrningData()
        {
            dataGridView1.DataSource = null; // Nollställ datakällan för att förbereda för uppdatering
            dataGridView1.DataSource = _uthyrningsRepo.GetAllUthyrningsData(); // Binda den uppdaterade listan
        }
    



    private void button2_Click(object sender, EventArgs e)
        {
            UserMenu usermenu = new UserMenu();
            usermenu.Show();
           // UserMenu userMenu = new UserMenu();

           // userMenu.Show();
            this.Hide();
        }
    }
}
