namespace Ride_GlideElectrics
{
    public partial class HuvudFönster : Form
    {
        public HuvudFönster()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
          
         
           // Hämta användarnamn och lösenord från textboxarna
           string username = txtUsername.Text;
           string password = txtPassword.Text;

           // En enkel inloggningslogik (byt ut detta med riktig validering om du har det)
           if (username == "admin" && password == "123")
           {
               MessageBox.Show("Inloggning lyckades!");
               // Eventuellt öppna ett nytt fönster eller formulär efter inloggning
           }
           else
           {
              MessageBox.Show("Felaktigt användarnamn eller lösenord.");
           }
        }
    }
}
