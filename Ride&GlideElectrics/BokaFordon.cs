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
    public partial class BokaFordon : Form
    {
        private TextBox txtFordon;

        public BokaFordon()
        {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            this.txtFordon = new TextBox(); // Initialize the TextBox

            // Configure the TextBox
            this.txtFordon.Multiline = true; // Allow multiple lines if needed
            this.txtFordon.Dock = DockStyle.Fill; // Fill the form with the TextBox

            // Adding controls to the form
            this.Controls.Add(this.txtFordon);
            this.Text = "Boka Fordon"; // Set the title of the form
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You entered: " + txtFordon.Text);

        }
        public void SetFordon(string selectedFordon)
        {
            if (txtFordon != null) // Check if txtFordon is initialized
            {
                txtFordon.Text = selectedFordon; // Set the text in the TextBox
            }
            else
            {
                MessageBox.Show("TextBox is not initialized."); // Debug message
            }
        }

    }
}
