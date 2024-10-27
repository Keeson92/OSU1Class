using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicelager;
using BusinessEntities;

namespace Ride_GlideElectrics
{
    public partial class RedigeraFordon : Form
    {
        private Fordon _selectedFordon;
        private DataGridView _dataGridView;
        private Button Bekräfta; // Added definition for Bekräfta button

        public RedigeraFordon(Fordon selectedFordon, DataGridView dataGridView)
        {
            _selectedFordon = selectedFordon;
            _dataGridView = dataGridView;
            // Removed 'this' to avoid ambiguity
        }

        private void InitializeComponent()
        {
            Bekräfta = new Button();
            Backa = new Button();
            button2 = new Button();
            ID = new TextBox();
            FordonsTyp = new TextBox();
            Lokation = new TextBox();
            Tillstånd = new TextBox();
            label1 = new Label();
            FordonsID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Bekräfta
            // 
            Bekräfta.Location = new Point(0, 0);
            Bekräfta.Name = "Bekräfta";
            Bekräfta.Size = new Size(75, 23);
            Bekräfta.TabIndex = 0;
            Bekräfta.Click += Bekräfta_Click;
            // 
            // Backa
            // 
            Backa.AccessibleName = "Backa";
            Backa.Location = new Point(70, 414);
            Backa.Name = "Backa";
            Backa.Size = new Size(102, 54);
            Backa.TabIndex = 0;
            Backa.Text = "button1";
            Backa.UseVisualStyleBackColor = true;
            Backa.Click += button1_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "Bekräfta";
            button2.Location = new Point(797, 414);
            button2.Name = "button2";
            button2.Size = new Size(102, 54);
            button2.TabIndex = 1;
            button2.Text = "Bekräfta";
            button2.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            ID.AccessibleName = "ID";
            ID.Location = new Point(149, 150);
            ID.Name = "ID";
            ID.Size = new Size(116, 23);
            ID.TabIndex = 2;
            // 
            // FordonsTyp
            // 
            FordonsTyp.AccessibleName = "FordonsTyp";
            FordonsTyp.Location = new Point(149, 274);
            FordonsTyp.Name = "FordonsTyp";
            FordonsTyp.Size = new Size(176, 23);
            FordonsTyp.TabIndex = 3;
            // 
            // Lokation
            // 
            Lokation.AccessibleName = "Lokation";
            Lokation.Location = new Point(575, 150);
            Lokation.Name = "Lokation";
            Lokation.Size = new Size(173, 23);
            Lokation.TabIndex = 4;
            // 
            // Tillstånd
            // 
            Tillstånd.AccessibleName = "Tillstånd";
            Tillstånd.Location = new Point(575, 274);
            Tillstånd.Name = "Tillstånd";
            Tillstånd.Size = new Size(173, 23);
            Tillstånd.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 52);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 6;
            label1.Text = "Redigera fordon";
            label1.Click += label1_Click;
            // 
            // FordonsID
            // 
            FordonsID.AccessibleName = "ID";
            FordonsID.AutoSize = true;
            FordonsID.Location = new Point(149, 132);
            FordonsID.Name = "FordonsID";
            FordonsID.Size = new Size(61, 15);
            FordonsID.TabIndex = 7;
            FordonsID.Text = "FordonsID";
            // 
            // label2
            // 
            label2.AccessibleName = "FordonsTyp";
            label2.AutoSize = true;
            label2.Location = new Point(149, 257);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 8;
            label2.Text = "FordonsTyp";
            // 
            // label3
            // 
            label3.AccessibleName = "Lokation";
            label3.AutoSize = true;
            label3.Location = new Point(578, 130);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 9;
            label3.Text = "Lokation";
            // 
            // label4
            // 
            label4.AccessibleName = "Tillstånd";
            label4.AutoSize = true;
            label4.Location = new Point(578, 257);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 10;
            label4.Text = "Tilstånd";
            label4.Click += label4_Click;
            // 
            // RedigeraFordon
            // 
            ClientSize = new Size(930, 511);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(FordonsID);
            Controls.Add(label1);
            Controls.Add(Tillstånd);
            Controls.Add(Lokation);
            Controls.Add(FordonsTyp);
            Controls.Add(ID);
            Controls.Add(button2);
            Controls.Add(Backa);
            Name = "RedigeraFordon";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Bekräfta_Click(object sender, EventArgs e)
        {
            // Update the selected Fordon object with new values from text boxes
            // _selectedFordon.FordonsID = int.Parse(txtFordonsID.Text); // Removed this line as FordonsID is read-only
            _selectedFordon.Position = txtPosition.Text;
            _selectedFordon.Status = txtStatus.Text;
            _selectedFordon.FordonsTyp = txtFordonsTyp.Text;

            // Refresh the DataGridView to show updated values
            _dataGridView.Refresh();

            // Close the RedigeraFordon form
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
