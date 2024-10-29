using Servicelager;
using BusinessEntities;
using System;

namespace Ride_GlideElectrics
{
    public partial class HuvudFönster : Form // HuvudFönster är en form som visar en inloggningssida och tillåter användaren att logga in som antingen administratör eller användare.
    {
        public HuvudFönster() // Konstruktor för HuvudFönster
        {
            InitializeComponent(); // Initialize the formens konponenter
        }

        private void label_UserName_Click(object sender, EventArgs e) // en metod som körs när användarnamnet klickas på
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e) // en metod som körs när logga in-knappen klickas på
        {
            // Hämta användarnamn och lösenord från textboxarna
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // En enkel inloggningslogik 
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Inloggning lyckades!");

                AdminFordon adminFordon = new AdminFordon(); // Skapar en ny instans av AdminFordon 

                // visar adminfordonformen
                adminFordon.Show();
                this.Hide(); // gömmer inloggningsformen
            }
            else if (username == "user" && password == "123") // om användaren är en användare
            {
                MessageBox.Show("Inloggning lyckades!");

                UserMenu usermenu = new UserMenu(); // Skapar en ny instans av UserMenu

                // visa usermeny och göm inloggningsformen
                usermenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn eller lösenord.");
            }
        }

        private void HuvudFönster_Load(object sender, EventArgs e) // en metod som körs när huvudfönstret laddas
        {

        }
    }
}
