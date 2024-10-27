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
    public partial class RedigeraFordon : Form
    {
        private Fordon _selectedFordon;

        public RedigeraFordon(Fordon selectedFordon)
        {
            InitializeComponent();
            _selectedFordon = selectedFordon;
            InitializeData();
        }

        private void InitializeData()
        {
            // Fyll i kontrollerna med data från _selectedFordon
            txtFordonsID.Text = _selectedFordon.FordonsID.ToString();
            txtPosition.Text = _selectedFordon.Position;
            txtStatus.Text = _selectedFordon.Status;
            txtFordonsTyp.Text = _selectedFordon.FordonsTyp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Uppdatera _selectedFordon med nya värden från kontrollerna
            _selectedFordon.Position = txtPosition.Text;
            _selectedFordon.Status = txtStatus.Text;
            _selectedFordon.FordonsTyp = txtFordonsTyp.Text;

            // Stäng fönstret
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
