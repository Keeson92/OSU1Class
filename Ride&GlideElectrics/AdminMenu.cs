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
            InitializeComponent();
            InitializeData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HuvudFönster frm = new(); // gå tillbaka till inloggning
            frm.Show(); // öppna inloggningsfönster
        }

        private void label2_Click(object sender, EventArgs e)
        {
            RedigeraFordon frm = new(); // här vill vi även ha med vilket fordon vi redigerar ifrån föregående form när det är redo
            frm.Show();
        }

        private void InitializeData() // kopplar listan till datagrid
        {

           dataGridView1.DataSource = fordonLista;
           dataGridView1.Columns["fordonsID"].HeaderText = "ID";
           dataGridView1.Columns["position"].HeaderText = "Station";
           dataGridView1.Columns["Status"].HeaderText = "Status";
           dataGridView1.Columns["fordonsTyp"].HeaderText = "Typ utav fordon";
        }

        

    }
}
