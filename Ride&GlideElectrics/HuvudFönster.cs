using Servicelager;
using BusinessEntities;
using System;

namespace Ride_GlideElectrics
{
    public partial class HuvudF�nster : Form
    {
        public HuvudF�nster()
        {
            InitializeComponent();
        }

        private void label_UserName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
          
         
           // H�mta anv�ndarnamn och l�senord fr�n textboxarna
           string username = txtUsername.Text;
           string password = txtPassword.Text;

            // En enkel inloggningslogik (byt ut detta med riktig validering om du har det)
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Inloggning lyckades!");

                AdminMenu AdminMenu = new AdminMenu();

                // Show the second form
                AdminMenu.Show();
                this.Hide();



            }
            else if (username == "user" && password == "123")
            {
                MessageBox.Show("Inloggning lyckades!");

                UserMenu usermenu = new UserMenu();

                // Show the second form
                usermenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Felaktigt anv�ndarnamn eller l�senord.");
            }
        }
    }
}
