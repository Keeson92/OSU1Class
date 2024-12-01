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
    public partial class Fredriksbergsgatan : Form // Fredriksbergsgatan är en WinForm som visar alla fordon som finns på Fredriksbergsgatan och tillåter användaren att boka ett fordon.
    {
        private UthyrningsHistorikRepository _uthyrningsRepo;
        private AnvandareRepository _anvandareRepo;  // Skapa fält för AnvandareRepository
        private List<Fordon> _fordonLista;
        private BusinessEntities.User loggedInUser;
        private FordonRepository _fordonRepo;


        public Fredriksbergsgatan() // Konstruktor för Fredriksbergsgatan
        {
            InitializeComponent(); // Initialiserar WinForms komponenter
            _anvandareRepo = new AnvandareRepository();
            _fordonRepo = new FordonRepository(); // Instansiera FordonRepository
            _uthyrningsRepo = new UthyrningsHistorikRepository(_anvandareRepo, _fordonRepo);
            _fordonLista = new List<Fordon>(); // Initialiserar listan

            InitializeData();// Initialiserar WinForms data
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // en metod som körs när en cell i datagridview klickas på
        {

        }
        private void InitializeData() // kopplar listan till datagrid
        {

            _fordonLista = FordonRepository.GetAllFordon(); // Hämtar alla fordon från databasen


            // Filtrerar listan till att innehålla endast fordon som har sin Position som "Allégatan"
            var filteredFordonLista = _fordonLista.Where(f => f.Position.Contains("Fredriksbergsgatan")).ToList();

            // Skickar den filtrerade listan till DataGridView:n
            dataGridView1.DataSource = filteredFordonLista;

        }
        // en metod som körs när boka-knappen klickas på
        #region Boka_Click
        private void boka_Click(object sender, EventArgs e) 
        {

            if (dataGridView1.SelectedRows.Count == 0) // Kontrollera att ett fordon är valt
            {
                MessageBox.Show("Vänligen välj ett fordon från listan.");
                return;
            }

            // Hämta valt fordon från DataGridView
            var valtFordon = (Fordon)dataGridView1.SelectedRows[0].DataBoundItem;
            var anvandareRepository = new AnvandareRepository();
            var fordonRepository = new FordonRepository();
            var uthyrningsHistorikRepo = new UthyrningsHistorikRepository(anvandareRepository, fordonRepository);



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
                MessageBox.Show($"Fordon {valtFordon.FordonsTyp} med ID {valtFordon.FordonsID} är inte ledig och går inte att boka.");
            }
        }
        #endregion

        // en metod som körs när huvudmeny-knappen klickas på, öppnar user-menyn och stänger denna form
        private void huvudmeny_Click(object sender, EventArgs e) 
        {
            UserMenu userMenu = new UserMenu();

            userMenu.Show();
            this.Close();
        }

        private void Fredriksbergsgatan_Load(object sender, EventArgs e)
        {

        }
    }
}
