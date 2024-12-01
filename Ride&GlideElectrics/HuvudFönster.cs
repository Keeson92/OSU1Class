using Servicelager;
using BusinessEntities;
using System;
using static Servicelager.FordonService;

namespace GreenWheels
{
    public partial class HuvudFönster : Form // HuvudFönster är en WinForm som visar en inloggningssida och tillåter användaren att logga in som antingen administratör eller användare.
    {
        public HuvudFönster() // Konstruktor för HuvudFönster
        {
            InitializeComponent(); // Initialiserar WinForms komponenter
        }

        private void label_UserName_Click(object sender, EventArgs e) // en metod som körs när användarnamnet klickas på
        {

        }
        // en metod som körs när logga in-knappen klickas på
        #region LogIn_Click
        private void btnLogIn_Click(object sender, EventArgs e) 
        {
            // Hämta användarnamn och lösenord från textboxarna
            int userID = 0;
            try
            {
                userID = int.Parse(txtUsername.Text); // Konverterar texten till int
            }
            catch (FormatException)
            {
                MessageBox.Show("Ange ett giltigt ID-nummer.");
                return; // Avbryt om det inte går att konvertera
            }
            string password = txtPassword.Text;


            // Skapa en instans av AnvandareService
            var anvandareService = new AnvandareService();

            // Försök logga in användaren
            if (anvandareService.Login(userID, password, out User user))
            {

                // Kontrollera om användaren är admin eller vanlig användare
                if (user.Behörighetsgrad == 1)
                {
                    MessageBox.Show("Inloggning lyckades som admin!");

                    // Öppna AdminFordon-formuläret
                    AdminFordon adminFordon = new AdminFordon();
                    adminFordon.Show();
                }
                else
                {
                    MessageBox.Show($"Inloggning lyckades som användare {user.Fornamn} {user.Efternamn}!");

                    // Öppna UserMenu-formuläret
                    UserMenu usermenu = new UserMenu();
                    usermenu.Show();
                }

                // Dölj inloggningsformuläret
                this.Hide();
            }
            else
            {
                // Visa felmeddelande om inloggningen misslyckades
                MessageBox.Show("Felaktigt användarnamn eller lösenord.");
            }

        }
        #endregion
        private void HuvudFönster_Load(object sender, EventArgs e) // en metod som körs när huvudfönstret laddas
        {

        }
    }
}
