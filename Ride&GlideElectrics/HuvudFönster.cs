using Servicelager;
using BusinessEntities;
using System;
using static Servicelager.FordonService;

namespace GreenWheels
{
    public partial class HuvudF�nster : Form // HuvudF�nster �r en WinForm som visar en inloggningssida och till�ter anv�ndaren att logga in som antingen administrat�r eller anv�ndare.
    {
        public HuvudF�nster() // Konstruktor f�r HuvudF�nster
        {
            InitializeComponent(); // Initialiserar WinForms komponenter
        }

        private void label_UserName_Click(object sender, EventArgs e) // en metod som k�rs n�r anv�ndarnamnet klickas p�
        {

        }
        // en metod som k�rs n�r logga in-knappen klickas p�
        #region LogIn_Click
        private void btnLogIn_Click(object sender, EventArgs e) 
        {
            // H�mta anv�ndarnamn och l�senord fr�n textboxarna
            int userID = 0;
            try
            {
                userID = int.Parse(txtUsername.Text); // Konverterar texten till int
            }
            catch (FormatException)
            {
                MessageBox.Show("Ange ett giltigt ID-nummer.");
                return; // Avbryt om det inte g�r att konvertera
            }
            string password = txtPassword.Text;


            // Skapa en instans av AnvandareService
            var anvandareService = new AnvandareService();

            // F�rs�k logga in anv�ndaren
            if (anvandareService.Login(userID, password, out User user))
            {

                // Kontrollera om anv�ndaren �r admin eller vanlig anv�ndare
                if (user.Beh�righetsgrad == 1)
                {
                    MessageBox.Show("Inloggning lyckades som admin!");

                    // �ppna AdminFordon-formul�ret
                    AdminFordon adminFordon = new AdminFordon();
                    adminFordon.Show();
                }
                else
                {
                    MessageBox.Show($"Inloggning lyckades som anv�ndare {user.Fornamn} {user.Efternamn}!");

                    // �ppna UserMenu-formul�ret
                    UserMenu usermenu = new UserMenu();
                    usermenu.Show();
                }

                // D�lj inloggningsformul�ret
                this.Hide();
            }
            else
            {
                // Visa felmeddelande om inloggningen misslyckades
                MessageBox.Show("Felaktigt anv�ndarnamn eller l�senord.");
            }

        }
        #endregion
        private void HuvudF�nster_Load(object sender, EventArgs e) // en metod som k�rs n�r huvudf�nstret laddas
        {

        }
    }
}
