
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
    public partial class Allegatan : Form // Allegatan är en form som visar alla fordon som finns på Allégatan och tillåter användaren att boka ett fordon.
    {
        private List<Fordon> _fordonLista;
        private UthyrningsDataRepository _uthyrningsRepo = new UthyrningsDataRepository();
        public Allegatan()
        {
            InitializeComponent(); // Initialize formens konponenter
            _fordonLista = new List<Fordon>(); 
            InitializeData(); // Initialize formens data
        }


        private void InitializeData() // kopplar listan till datagrid
        {
                      
            _fordonLista = FordonRepository.GetAllFordon();

            // Filtera listan för att visa endast fordon på Allégatan som är lediga
            var filteredFordonLista = _fordonLista.Where(f => f.Position.Contains("Allégatan") && f.Status == "Ledig").ToList();

            // skicka den fitlerade listan till datagrid
            dataGridView1.DataSource = filteredFordonLista;

            // bestämmer column Rubriker
            dataGridView1.Columns["FordonsID"].HeaderText = "ID";
            dataGridView1.Columns["Position"].HeaderText = "Station";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["FordonsTyp"].HeaderText = "Typ utav fordon";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // en metod som körs när en cell i datagridview klickas på
        {

        }


        private void LoadUthyrningData() // Uppdaterar DataGridView med den senaste uthyrningsdatan
        {
            dataGridView1.DataSource = null; // Nollställ datakällan för att förbereda för uppdatering
            dataGridView1.DataSource = _uthyrningsRepo.GetAllUthyrningsData(); // Binda den uppdaterade listan
        }



        private void boka_Click(object sender, EventArgs e) // knappen Boka kör denna metod
        {

            if (dataGridView1.SelectedRows.Count == 0) //felhantring för att se om raden är giltig
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

        private void huvudmeny_Click(object sender, EventArgs e) // Metod som körs när knappen Huvudmeny trycks
        {
            UserMenu userMenu = new UserMenu(); //öppmar usermenu och stänger detta fönster

            userMenu.Show();
            this.Hide();
        }
    }
}
