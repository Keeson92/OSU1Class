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
        private UthyrningsDataRepository _uthyrningsRepo;
        private List<Fordon> _fordonLista;

        public AdminFordon()
        {
            InitializeComponent();
            _uthyrningsRepo = new UthyrningsDataRepository(); // Initialize the repository
            _fordonLista = new List<Fordon>(); // Initialize the list
            InitializeData();
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeData()
        {
            _fordonLista = FordonRepository.GetAllFordon();
            var filteredFordonLista = _fordonLista.ToList();

            if (filteredFordonLista.Any())
            {
                dataGridView1.DataSource = filteredFordonLista;

                // Ensure DataGridView is properly initialized and columns exist
                if (dataGridView1.Columns.Contains("FordonsID") &&
                    dataGridView1.Columns.Contains("Position") &&
                    dataGridView1.Columns.Contains("Status") &&
                    dataGridView1.Columns.Contains("FordonsTyp"))
                {
                    dataGridView1.Columns["FordonsID"].HeaderText = "ID";
                    dataGridView1.Columns["Position"].HeaderText = "Station";
                    dataGridView1.Columns["Status"].HeaderText = "Status";
                    dataGridView1.Columns["FordonsTyp"].HeaderText = "Typ utav fordon";
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedRow.Cells["fordonsIDDataGridViewTextBoxColumn"].Value.ToString();
                textBox2.Text = selectedRow.Cells["positionDataGridViewTextBoxColumn"].Value.ToString();
                textBox3.Text = selectedRow.Cells["statusDataGridViewTextBoxColumn"].Value.ToString();
                textBox4.Text = selectedRow.Cells["fordonsTypDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HuvudFönster huvudFönster = new HuvudFönster();
            huvudFönster.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}

