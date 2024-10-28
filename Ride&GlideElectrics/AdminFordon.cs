using Ride_GlideElectrics;
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
    public partial class AdminFordon : Form
    {
        private UthyrningsDataRepository _uthyrningsRepo = new UthyrningsDataRepository();




        private List<Fordon> _fordonLista;
        public AdminFordon()
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


            private void button1_click(object? sender, EventArgs e)
            {
                this.Close();
                HuvudFönster huvudFönster = new HuvudFönster();
                huvudFönster.Show();
            }
        
    }
}
