using GreenWheels;
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
using static System.Net.WebRequestMethods;

namespace GreenWheels
{
    public partial class AdminFordon : Form // AdminFordon är en form som visar alla fordon som finns i systemet och tllåter administratör att redigera dem.
    {
        private UthyrningsDataRepository _uthyrningsRepo; // Repository for data access
        private List<Fordon> _fordonLista;//FordonListan som innehåller alla fordon som finns i systemet

        public AdminFordon()//Konstruktor för AdminFordon
        {
            InitializeComponent(); // Initialize the formens konponenter
            _uthyrningsRepo = new UthyrningsDataRepository();
            _fordonLista = new List<Fordon>();
            InitializeData(); // initialize formens Data
            this.button1.Click += new System.EventHandler(this.Button1_Click);// registrera knapptryckning knapp 1 och 2
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged); // registrera rad-ändring i datagridview
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // en metod som körs när en cell i datagridview klickas på
        {

        }




        private void InitializeData() // olika data som andvänds i formen
        {
            _fordonLista = FordonRepository.GetAllFordon();
            var filteredFordonLista = _fordonLista.ToList();

            if (filteredFordonLista.Any())
            {
                dataGridView1.DataSource = filteredFordonLista; // Binder data till DataGridView


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

        private void Button1_Click(object sender, EventArgs e) // Metod som körs när knapp 1 trycks (knapp 1 är logga ut) 
        {
            HuvudFönster huvudFönster = new HuvudFönster(); // visa nytt fönster och stäng det gamla
            huvudFönster.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)// Metod som körs när knapp 2 trycks (knapp 2 är redigera)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Om en rad är vald i datagridview 
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["fordonsIDDataGridViewTextBoxColumn"].Value = textBox1.Text;
                selectedRow.Cells["positionDataGridViewTextBoxColumn"].Value = textBox2.Text;
                selectedRow.Cells["statusDataGridViewTextBoxColumn"].Value = textBox3.Text;
                selectedRow.Cells["fordonsTypDataGridViewTextBoxColumn"].Value = textBox4.Text;


                var fordon = _fordonLista.FirstOrDefault(f => f.FordonsID.ToString() == textBox1.Text); // Hämta fordon från listan samt felhantering för nullvärden.  
                if (fordon != null)
                {
                    fordon.Position = textBox2.Text;
                    fordon.Status = textBox3.Text;
                    fordon.FordonsTyp = textBox4.Text;
                }

                // Refresha datagridview för att via nya värden
                dataGridView1.Refresh();
            }
        }

        private void AdminFordon_Load(object sender, EventArgs e)
        {

        }
    }
}

