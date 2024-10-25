namespace Ride_GlideElectrics
{
    partial class UserMeny
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
            HyraFordon = new Button();
            VisaHyreshistorik = new Button();
            VisaBetalningsmetod = new Button();
            LoggaUt = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // HyraFordon
            // 
            HyraFordon.Location = new Point(12, 65);
            HyraFordon.Name = "HyraFordon";
            HyraFordon.Size = new Size(114, 28);
            HyraFordon.TabIndex = 0;
            HyraFordon.Text = "Hyra Fordon";
            HyraFordon.UseVisualStyleBackColor = true;
            // 
            // VisaHyreshistorik
            // 
            VisaHyreshistorik.Location = new Point(170, 63);
            VisaHyreshistorik.Name = "VisaHyreshistorik";
            VisaHyreshistorik.Size = new Size(132, 33);
            VisaHyreshistorik.TabIndex = 1;
            VisaHyreshistorik.Text = "Visa Hyreshistorik";
            VisaHyreshistorik.UseVisualStyleBackColor = true;
            // 
            // VisaBetalningsmetod
            // 
            VisaBetalningsmetod.Location = new Point(12, 115);
            VisaBetalningsmetod.Name = "VisaBetalningsmetod";
            VisaBetalningsmetod.Size = new Size(140, 28);
            VisaBetalningsmetod.TabIndex = 2;
            VisaBetalningsmetod.Text = "Visa Betalningsmetod";
            VisaBetalningsmetod.UseVisualStyleBackColor = true;
            // 
            // LoggaUt
            // 
            LoggaUt.Location = new Point(170, 120);
            LoggaUt.Name = "LoggaUt";
            LoggaUt.Size = new Size(75, 23);
            LoggaUt.TabIndex = 3;
            LoggaUt.Text = "Logga Ut";
            LoggaUt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(290, 15);
            label1.TabIndex = 4;
            label1.Text = "Välkommen till  ditt konto för Ride and Glide Electrics!";
            label1.Click += this.label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 36);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 5;
            label2.Text = "Vad vill du göra idag?";
            // 
            // UserMeny
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 177);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoggaUt);
            Controls.Add(VisaBetalningsmetod);
            Controls.Add(VisaHyreshistorik);
            Controls.Add(HyraFordon);
            Name = "UserMeny";
            Text = "UserMenu";
            Load += this.UserMeny_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HyraFordon;
        private Button VisaHyreshistorik;
        private Button VisaBetalningsmetod;
        private Button LoggaUt;
        private Label label1;
        private Label label2;
    }
}