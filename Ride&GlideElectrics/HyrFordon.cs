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
using Presentationslager;

namespace Ride_GlideElectrics
{
    public partial class HyrFordon : Form // HyrFordon är en form som visar alla fordon som finns i systemet och tillåter användaren att boka ett fordon.
    {
        public HyrFordon() // Konstruktor för HyrFordon
        {
            InitializeComponent();
        }

        private void btnTillbakaTillUserMenu_Click(object sender, EventArgs e) // en metod som körs när knappen Tillbaka till UserMenu klickas på
        {
            UserMenu usermenu = new UserMenu();

            usermenu.Show(); // Visa UserMenu
            this.Close();// stänger nuvarande fönster

        }

        private void btn_Allégatan_Click(object sender, EventArgs e) // knappen allegatan kör denna metod
        {
            Allegatan allegatan = new Allegatan();
            allegatan.Show(); // visa allegatan
            this.Hide();// stänger nuvarande fönster
        }

        private void btn_Stationsgatan_Click(object sender, EventArgs e) // knappen Stationsgatan kör denna metod
        {
            Stationsgatan stationsgatan = new Stationsgatan();
            stationsgatan.Show(); // visar Stationsgatan
            this.Hide(); // stänger nuvarande fönster
        }

        private void btn_Fredriksbergsgatan_Click(object sender, EventArgs e) // knappen Fredriksbergsgatan kör denna metod
        {
            Fredriksbergsgatan fredriksbergsgatan = new Fredriksbergsgatan();
           fredriksbergsgatan.Show(); //visar Fredriksbergsgatan
            this.Hide(); // stänger nuvarande fönster

        }

        private void btn_Solrosvägen_Click(object sender, EventArgs e) //knappen Solrosvägen kör denna metod
        {
           Solrosvagen solrosvagen = new Solrosvagen();
           solrosvagen.Show(); // visar Solrosvägen
            this.Hide(); // stänger nuvarande fönster
            
        }
    }
}
