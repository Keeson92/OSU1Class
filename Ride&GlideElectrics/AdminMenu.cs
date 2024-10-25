using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BuissnessEnteties.Fordon;
using static Servicelager.Datalayer;

namespace Ride_GlideElectrics
{
    public partial class AdminMenu : Form
    {
        private List<Fordon> fordonsLista;
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
            RedigeraFordon frm = new(); // här vill vi även ha med villket fordon vi redigerar ifrån föregånede form när det är redo
            frm.Show();
        }

        private void InitializeData() // koplar listan till datagrid
        {

            FordonStatusStationGrid.DataSource = fordonsLista;
            FordonStatusStationGrid.Colums["fordonsID"].HeaderText = "ID";
            FordonStatusStationGrid.Colums["position"].HeaderText = "Station";
            FordonStatusStationGrid.Colums["Status"].HeaderText = "Status";
            FordonStatusStationGrid.Colums["fordonsTyp"].HeaderText = "Typ utav fordon";
        }

        

    }
}
