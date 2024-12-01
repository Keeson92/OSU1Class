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


namespace GreenWheels
{
    public partial class UserMenu : Form // UserMenu är en WinForm som visar användaren olika valen de kan göra.
    {
        public UserMenu() // Konstruktor för UserMenu
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) // en metod som körs när label 1 klickas på               
        {

        }

        // en metod som körs när knappen HyrFordon klickas på, visar fönster HyrFordon och gömmer nuvarande fönster.
        private void btnHyrFordon_Click(object sender, EventArgs e) 
        {

            HyrFordon hyrfordon = new HyrFordon();
            hyrfordon.Show();
            this.Hide();
        }

        private void UserMenu_Load(object sender, EventArgs e) // en metod som körs när UserMenu laddas
        {

        }

        // en metod som körs när knappen avsluta klickas på, avslutar programmet.
        private void button1_Click(object sender, EventArgs e)                         
        {
            Environment.Exit(0); 
        }


        // Metod som körs när användare väljer knappen "Logga ut", Skickar tillbaka till HuvudFönster och stänger nuvarande.
        private void btn_LogOut_Click(object sender, EventArgs e) 
        {
                HuvudFönster huvudFönster = new HuvudFönster(); 
                huvudFönster.Show();
                this.Close();
        }
        
    }
}
