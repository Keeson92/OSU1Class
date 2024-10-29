using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentationslager
{
    public partial class BokaFordon : Form // BokaFordon är en form som tillåter användaren att boka ett fordon.
    {
        private TextBox txtFordon;

        public BokaFordon() // Konstruktor för BokaFordon
        {
            InitializeComponent(); // Initialize form-konponenter
            InitializeData(); // Initialize data
        }
        private void InitializeData() 
        {
            this.txtFordon = new TextBox(); // Initialize TextBox

            // Configure våran TextBox
            this.txtFordon.Multiline = true; // tillåt för flera rader
            this.txtFordon.Dock = DockStyle.Fill; // fyll ut formen

            // Controller för att visa texten i TextBox
            this.Controls.Add(this.txtFordon);
            this.Text = "Boka Fordon"; // välj fordonsbokning som titel
        }


        private void textBox1_TextChanged(object sender, EventArgs e) // en metod som körs när texten i TextBox ändras
        {
            MessageBox.Show("You entered: " + txtFordon.Text);

        }
        public void SetFordon(string selectedFordon) // en metod som sätter texten i TextBox
        {
            if (txtFordon != null) // ser till att TextBox är initialiserad
            {
                txtFordon.Text = selectedFordon; // bestämmer texten i TextBox
            }
            else
            {
                MessageBox.Show("TextBox is not initialized."); // Debug medelande
            }
        }

    }
}
