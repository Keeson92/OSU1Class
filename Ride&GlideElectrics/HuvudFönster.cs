using Servicelager;
using BusinessEntities;
using System;

namespace Ride_GlideElectrics
{
    public partial class HuvudF�nster : Form // HuvudF�nster �r en form som visar en inloggningssida och till�ter anv�ndaren att logga in som antingen administrat�r eller anv�ndare.
    {
        public HuvudF�nster() // Konstruktor f�r HuvudF�nster
        {
            InitializeComponent(); // Initialize the formens konponenter
        }

        private void label_UserName_Click(object sender, EventArgs e) // en metod som k�rs n�r anv�ndarnamnet klickas p�
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e) // en metod som k�rs n�r logga in-knappen klickas p�
        {
            // H�mta anv�ndarnamn och l�senord fr�n textboxarna
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // En enkel inloggningslogik 
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Inloggning lyckades!");

                AdminFordon adminFordon = new AdminFordon(); // Skapar en ny instans av AdminFordon 

                // visar adminfordonformen
                adminFordon.Show();
                this.Hide(); // g�mmer inloggningsformen
            }
            else if (username == "user" && password == "123") // om anv�ndaren �r en anv�ndare
            {
                MessageBox.Show("Inloggning lyckades!");

                UserMenu usermenu = new UserMenu(); // Skapar en ny instans av UserMenu

                // visa usermeny och g�m inloggningsformen
                usermenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Felaktigt anv�ndarnamn eller l�senord.");
            }
        }

        private void HuvudF�nster_Load(object sender, EventArgs e) // en metod som k�rs n�r huvudf�nstret laddas
        {

        }
    }
}
