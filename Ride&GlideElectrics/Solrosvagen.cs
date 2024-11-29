using BusinessEntities;
using GreenWheels;
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
    public partial class Solrosvagen : Form // Solrosvagen är en form som visar alla fordon som finns på Solrosvägen och tillåter användaren att boka ett fordon.
    {
        private UthyrningsHistorikRepository _uthyrningsRepo;
        private AnvandareRepository _anvandareRepo;  // Skapa fält för AnvandareRepository
        private List<Fordon> _fordonLista;
        private BusinessEntities.User loggedInUser;


        public Solrosvagen() // Konstruktor för Solrosvagen
        {
            InitializeComponent();
            _anvandareRepo = new AnvandareRepository();
            _uthyrningsRepo = new UthyrningsHistorikRepository(_anvandareRepo);
            _fordonLista = new List<Fordon>(); // Initialize the list
            InitializeData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // en metod som körs när en cell i datagridview klickas på
        {

        }
        private void InitializeData() // kopplar listan till datagrid
        {
            //initializear listan för fordon
            _fordonLista = FordonRepository.GetAllFordon();


            // filtrerar listan så bara fordon ifrån "alegatan" visas
            var filteredFordonLista = _fordonLista.Where(f => f.Position.Contains("Solrosvägen")).ToList();

            // fordonslistan skickas till datagrid
            dataGridView1.DataSource = filteredFordonLista;

        }

        private void boka_Click(object sender, EventArgs e) // en metod som körs när boka-knappen klickas på
        {
            if (dataGridView1.SelectedRows.Count == 0) // Kontrollera att ett fordon är valt
            {
                MessageBox.Show("Vänligen välj ett fordon från listan.");
                return;
            }

            // Hämta valt fordon från DataGridView
            // Hämta valt fordon från DataGridView
            var valtFordon = (Fordon)dataGridView1.SelectedRows[0].DataBoundItem;
            var anvandareRepository = new AnvandareRepository();
            var uthyrningsHistorikRepo = new UthyrningsHistorikRepository(anvandareRepository);


            // Skapa en instans av FordonService 
            var fordonService = new FordonService(new FordonRepository(), uthyrningsHistorikRepo);

            // Anropa BokaFordon-metoden för att boka fordonet
            bool bokad = fordonService.BokaFordon(
                loggedInUser,                          // Användaren som bokar
                valtFordon.FordonsID,          // Fordonets ID
                DateTime.Now,                  // Starttid för uthyrningen
                DateTime.Now.AddHours(2),      // Sluttid för uthyrningen
                10
                        );

            if (bokad)
            {
                // Bekräftelsemeddelande
                MessageBox.Show($"Uthyrning startad för {valtFordon.FordonsTyp} (ID {valtFordon.FordonsID}).");

                // Uppdatera datagrid med lediga fordon
                InitializeData();
            }
            else
            {
                MessageBox.Show($"Fordon {valtFordon.FordonsTyp} med ID {valtFordon.FordonsID} är inte ledig och går inte att boka");
            }
        }

        private void huvudmeny_Click(object sender, EventArgs e) // en metod som körs när huvudmeny-knappen klickas på
        {
            UserMenu userMenu = new UserMenu();

            userMenu.Show();// visa UserMenu
            this.Hide();// stänger nuvarande fönster
        }

        private void Solrosvagen_Load(object sender, EventArgs e)
        {

        }
    }
}
