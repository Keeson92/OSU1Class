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
          
         
           // H�mta anv�ndarnamn och l�senord fr�n textboxarna
           string username = txtUsername.Text;
           string password = txtPassword.Text;

           // En enkel inloggningslogik (byt ut detta med riktig validering om du har det)
           if (username == "admin" && password == "password123")
           {
               MessageBox.Show("Inloggning lyckades!");
               // Eventuellt �ppna ett nytt f�nster eller formul�r efter inloggning
           }
           else
           {
              MessageBox.Show("Felaktigt anv�ndarnamn eller l�senord.");
           }
        }
    }
}
