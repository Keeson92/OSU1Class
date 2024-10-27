namespace Ride_GlideElectrics
{
    partial class RedigeraFordon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Redigera = new Button();
            label1 = new Label();
            Tillbaka = new Button();
            txtFordonsID = new TextBox();
            txtPosition = new TextBox();
            txtStatus = new TextBox();
            txtFordonsTyp = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // Redigera
            // 
            Redigera.Location = new Point(636, 361);
            Redigera.Name = "Redigera";
            Redigera.Size = new Size(75, 23);
            Redigera.TabIndex = 0;
            Redigera.Text = "Bekräfta ändring";
            Redigera.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 51);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "Redigera valt fordon";
            // 
            // Tillbaka
            // 
            Tillbaka.AccessibleName = "Tillbaka";
            Tillbaka.Location = new Point(36, 361);
            Tillbaka.Name = "Tillbaka";
            Tillbaka.Size = new Size(75, 23);
            Tillbaka.TabIndex = 2;
            Tillbaka.Text = "tillbaka";
            Tillbaka.UseVisualStyleBackColor = true;
            // 
            // txtFordonsID
            // 
            txtFordonsID.AccessibleName = "txtFordonsID";
            txtFordonsID.Location = new Point(108, 175);
            txtFordonsID.Name = "txtFordonsID";
            txtFordonsID.Size = new Size(67, 23);
            txtFordonsID.TabIndex = 3;
            // 
            // txtPosition
            // 
            txtPosition.AccessibleName = "txtPosition";
            txtPosition.Location = new Point(361, 175);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(168, 23);
            txtPosition.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.AccessibleName = "txtStatus";
            txtStatus.Location = new Point(108, 273);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 5;
            txtStatus.TextChanged += textBox3_TextChanged;
            // 
            // txtFordonsTyp
            // 
            txtFordonsTyp.AccessibleName = "txtFordonsTyp";
            txtFordonsTyp.Location = new Point(361, 273);
            txtFordonsTyp.Name = "txtFordonsTyp";
            txtFordonsTyp.Size = new Size(168, 23);
            txtFordonsTyp.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 157);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 157);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 255);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 255);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 10;
            label5.Text = "typ utav fordon";
            // 
            // RedigeraFordon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFordonsTyp);
            Controls.Add(txtStatus);
            Controls.Add(txtPosition);
            Controls.Add(txtFordonsID);
            Controls.Add(Tillbaka);
            Controls.Add(label1);
            Controls.Add(Redigera);
            Name = "RedigeraFordon";
            Text = "RedigeraFordon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Redigera;
        private Label label1;
        private Button Tillbaka;
        private TextBox txtFordonsID;
        private TextBox txtPosition;
        private TextBox txtStatus;
        private TextBox txtFordonsTyp;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}