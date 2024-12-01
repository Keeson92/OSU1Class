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

namespace GreenWheels
{
    public partial class HyrFordon : Form // HyrFordon är en form som visar alla fordon som finns i systemet och tillåter användaren att boka ett fordon.
    {
        public HyrFordon() // Konstruktor för HyrFordon
        {
            InitializeComponent();
        }

        // en metod som körs när TillbakaTillUserMenu-knappen klickas på, öppnar user-menyn och stänger denna form
        private void btnTillbakaTillUserMenu_Click(object sender, EventArgs e) 
        {
            UserMenu usermenu = new UserMenu();

            usermenu.Show(); 
            this.Close();

        }

        // en metod som körs när Allégatan-knappen klickas på, öppnar nytt fönster och gömmer detta fönster.
        private void btn_Allégatan_Click(object sender, EventArgs e) 
        {
            Allegatan allegatan = new Allegatan();
            allegatan.Show(); 
            this.Hide();
        }

        // en metod som körs när Stationsgatan-knappen klickas på, öppnar nytt fönster och gömmer detta fönster.
        private void btn_Stationsgatan_Click(object sender, EventArgs e) 
        {
            Stationsgatan stationsgatan = new Stationsgatan();
            stationsgatan.Show(); 
            this.Hide(); 
        }

        // en metod som körs när Fredriksbergsgatan-knappen klickas på, öppnar nytt fönster och gömmer detta fönster.
        private void btn_Fredriksbergsgatan_Click(object sender, EventArgs e) 
        {
            Fredriksbergsgatan fredriksbergsgatan = new Fredriksbergsgatan();
            fredriksbergsgatan.Show(); 
            this.Hide(); 

        }

        // en metod som körs när Solrosvägen-knappen klickas på, öppnar nytt fönster och gömmer detta fönster.
        private void btn_Solrosvägen_Click(object sender, EventArgs e) 
        {
            Solrosvagen solrosvagen = new Solrosvagen();
            solrosvagen.Show(); 
            this.Hide(); 

        }

        private void HyrFordon_Load(object sender, EventArgs e)
        {

        }
    }
}
