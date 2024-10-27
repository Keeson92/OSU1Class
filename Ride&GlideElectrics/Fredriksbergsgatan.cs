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
    public partial class Fredriksbergsgatan : Form
    {
        private List<Fordon> _fordonLista;
        public Fredriksbergsgatan()
        {
            InitializeComponent();
            InitializeData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeData() // kopplar listan till datagrid
        {
            // Initialize the list from in-memory data source
            // Initialize the list from in-memory data source
            _fordonLista = FordonRepository.GetAllFordon();


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

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vänligen välj ett fordon från listan.");
                return;
            }

            // Retrieve the selected Fordon from the DataGridView
            var valtFordon = (Fordon)dataGridView1.SelectedRows[0].DataBoundItem;

            // Set rental information - current time as start
            var uthyrningStart = DateTime.Now;
            var uthyrningSlut = uthyrningStart.AddHours(2); // Example rental period of 2 hours
            var prisPerMinut = 10; // You may retrieve this from the Fordon object if needed

            // Create a new UthyrningsData instance
            var uthyrningData = new UthyrningsData(uthyrningStart, uthyrningSlut, valtFordon.FordonsID, prisPerMinut);

            // Create an instance of UthyrningsDataRepository
            var uthyrningsRepo = new UthyrningsDataRepository();

            // Ensure that GetAllUthyrningsData() returns a modifiable collection
            var uthyrningsList = uthyrningsRepo.GetAllUthyrningsData();

            // Add the newly created uthyrningData to the list
            uthyrningsList.Add(uthyrningData);

            // Optionally, display a message to the user
            MessageBox.Show($"Uthyrning startad för fordon {valtFordon.FordonsTyp} med ID: {valtFordon.FordonsID}. Uthyrning start: {uthyrningStart}, Slut: {uthyrningSlut}, Pris per minut: {prisPerMinut}.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu();

            userMenu.Show();
            this.Hide();
        }
    }
}
