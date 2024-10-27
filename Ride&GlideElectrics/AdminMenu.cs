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
    public partial class AdminMenu : Form
    {
        private List<Fordon> _fordonLista;

        public AdminMenu() // startar winforms + hämtar listor
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData() // kopplar listan till datagrid
        {
            // Initialize the list from in-memory data source
            _fordonLista = FordonRepository.GetAllFordon();

            dataGridView1.DataSource = _fordonLista;
            dataGridView1.Columns["FordonsID"].HeaderText = "ID";
            dataGridView1.Columns["Position"].HeaderText = "Station";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["FordonsTyp"].HeaderText = "Typ utav fordon";
        }

        private void btn_LoggaUt_click(object sender, EventArgs e)
        {
            HuvudFönster HuvudFönster = new HuvudFönster(); // Skapar en instans av inloggningsfönstret
            HuvudFönster.Show(); // Öppnar det nya fönstret
            this.Close(); // Stänger det aktuella fönstret
        }

        private void btn_Redigera_click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hämta det valda objektet från DataGridView
                var selectedFordon = (Fordon)dataGridView1.SelectedRows[0].DataBoundItem;

                // Skapa en instans av RedigeraFordon och skicka det valda objektet
                RedigeraFordon redigeraFordon = new RedigeraFordon(selectedFordon);
                redigeraFordon.Show(); // Öppnar det nya fönstret
            }
            else
            {
                MessageBox.Show("Vänligen välj ett fordon att redigera."); // lägg till message box
            }
        }

        // Add the missing event handler method
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle the cell content click event here
        }
    }
}
