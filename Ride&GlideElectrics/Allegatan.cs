﻿using Servicelager;
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
using Ride_GlideElectrics;

namespace Presentationslager
{
    public partial class Allegatan : Form
    {
        private List<Fordon> _fordonLista;
        private UthyrningsDataRepository _uthyrningsRepo = new UthyrningsDataRepository();
        public Allegatan()
        {
            InitializeComponent();
            InitializeData();
        }


        private void InitializeData() // kopplar listan till datagrid
        {
            // Initialize the list from in-memory data source
            // Initialize the list from in-memory data source
            _fordonLista = FordonRepository.GetAllFordon();


            // Filter the list to include only vehicles where Position contains "Allegatan"
            var filteredFordonLista = _fordonLista.Where(f => f.Position.Contains("Allégatan") && f.Status == "Ledig").ToList();

            // Set the filtered list as the DataSource for the DataGridView
            dataGridView1.DataSource = filteredFordonLista;

            // Set header text for the columns
            dataGridView1.Columns["FordonsID"].HeaderText = "ID";
            dataGridView1.Columns["Position"].HeaderText = "Station";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["FordonsTyp"].HeaderText = "Typ utav fordon";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


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
            UserMenu userMenu = new UserMenu();

            userMenu.Show();
            this.Hide();
        }
    }
}
