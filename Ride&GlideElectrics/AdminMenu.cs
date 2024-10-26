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
            RedigeraFordon RedigeraFordon = new RedigeraFordon(); // Skapar en instans av inloggningsfönstret
            RedigeraFordon.Show(); // Öppnar det nya fönstret
        }
    }

}
