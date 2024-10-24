using ClassLibrary1;
using Data;

namespace Ride_GlideElectrics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Hämta användarnamn och lösenord från textboxarna

            // Simple login logic (replace this with actual validation logic if available)
            int searchID;

            // Convert the username to an ID (assuming it's an ID you're using for login)
            if (!int.TryParse(username, out searchID))
            {
                MessageBox.Show("Felaktig inmatning. Mata in ett giltigt AnvändarID.", "Inloggningsfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create an instance of the user repository
            AnvandareRepository anvandareRepository = new AnvandareRepository();

            // Fetch all users from the repository
            List<AnvandareData> anvandareLista = anvandareRepository.GetAllAnvandare();

            // Search for a user by their ID
            var foundUser = anvandareLista.FirstOrDefault(u => u.AnvandarID == searchID);

            if (foundUser != null)
            {
                // User found, validate the password
                if (foundUser.Password == password)
                {
                    // Login successful, show message and optionally open a new form
                    MessageBox.Show($"{foundUser.Fornamn} {foundUser.Efternamn} är nu inloggad.", "Inloggning lyckades", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Store the permission level (if needed)
                    int behorighetsgrad = foundUser.Behorighetsgrad;

                    // Open the menu or the next window (you'll need to define Meny as a form or a method)

                }
                else
                {
                    // Invalid password
                    MessageBox.Show("Felaktigt lösenord!", "Inloggningsfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // No user found with the given ID
                MessageBox.Show($"AnvändarID {searchID} hittades inte!", "Inloggningsfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

           // En enkel inloggningslogik (byt ut detta med riktig validering om du har det)
           
           }
        }

