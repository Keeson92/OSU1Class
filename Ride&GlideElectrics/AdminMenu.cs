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
        private List<Fordon> fordonLista;
        public AdminMenu() // startar winforms + hämtar listor
        {
            InitializeAdminMenu();
            InitializeData();
        }

        private void InitializeData() // kopplar listan till datagrid
        {

            dataGridView1.DataSource = fordonLista;
            dataGridView1.Columns["fordonsID"].HeaderText = "ID";
            dataGridView1.Columns["position"].HeaderText = "Station";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["fordonsTyp"].HeaderText = "Typ utav fordon";
        }

        private void btn_LoggaUt_click(object sender, EventArgs e)
        {
            HuvudFönster huvudFönster = new HuvudFönster(); // Skapar en instans av inloggningsfönstret
            huvudFönster.Show(); // Öppnar det nya fönstret
            this.Close(); // Stänger det aktuella fönstret
        }

        private void btn_Redigera_click(object sender, EventArgs e)
        {
            HuvudFönster RedigeraFordon = new HuvudFönster(); // Skapar en instans av inloggningsfönstret
            RedigeraFordon.Show(); // Öppnar det nya fönstret

        }
    }
}
