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
    public partial class UserMenu : Form // UserMenu är en form som visar användaren olika valen de kan göra.
    {
        public UserMenu() // Konstruktor för UserMenu
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) // en metod som körn när label 1 klickas på               
        {

        }

        private void btnHyrFordon_Click(object sender, EventArgs e) // en metod som körs när knappen HyrFordon klickas på
        {

            HyrFordon hyrfordon = new HyrFordon();
            hyrfordon.Show();// visar HyrFordon
            this.Hide();// stänger nuvarande fönster
        }

        private void UserMenu_Load(object sender, EventArgs e) // en metod som körs när UserMenu laddas
        {

        }

        private void button1_Click(object sender, EventArgs e) // en metod som körs när knappen avsluta klickas på                         
        {
            Environment.Exit(0); // avslutar programmet
        }

       
        
        private void btn_LogOut_Click(object sender, EventArgs e) // Metod som körs när logga ut
        {
                HuvudFönster huvudFönster = new HuvudFönster(); // visa nytt fönster och stäng det gamla
                huvudFönster.Show();
                this.Hide();
        }
        
    }
}
