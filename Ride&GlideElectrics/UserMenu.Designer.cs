namespace Ride_GlideElectrics
{
    partial class UserMenu
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
            label_WelcomeText = new Label();
            label_MakeChoice = new Label();
            btn_HyrFordon = new Button();
            btn_HyrHistorik = new Button();
            btn_BetalMetod = new Button();
            btn_LogOut = new Button();
            SuspendLayout();
            // 
            // label_WelcomeText
            // 
            label_WelcomeText.AutoSize = true;
            label_WelcomeText.Location = new Point(38, 9);
            label_WelcomeText.Name = "label_WelcomeText";
            label_WelcomeText.Size = new Size(287, 15);
            label_WelcomeText.TabIndex = 0;
            label_WelcomeText.Text = "Välkommen till ditt konto för Ride and Glide Electrics!";
            // 
            // label_MakeChoice
            // 
            label_MakeChoice.AutoSize = true;
            label_MakeChoice.Location = new Point(96, 36);
            label_MakeChoice.Name = "label_MakeChoice";
            label_MakeChoice.Size = new Size(119, 15);
            label_MakeChoice.TabIndex = 1;
            label_MakeChoice.Text = "Vad vill du göra idag?";
            // 
            // btn_HyrFordon
            // 
            btn_HyrFordon.BackColor = Color.Lime;
            btn_HyrFordon.Location = new Point(12, 71);
            btn_HyrFordon.Name = "btn_HyrFordon";
            btn_HyrFordon.Size = new Size(104, 28);
            btn_HyrFordon.TabIndex = 2;
            btn_HyrFordon.Text = "Hyra Fordon";
            btn_HyrFordon.UseVisualStyleBackColor = false;
            // 
            // btn_HyrHistorik
            // 
            btn_HyrHistorik.BackColor = Color.Turquoise;
            btn_HyrHistorik.ForeColor = Color.Black;
            btn_HyrHistorik.Location = new Point(141, 71);
            btn_HyrHistorik.Name = "btn_HyrHistorik";
            btn_HyrHistorik.Size = new Size(119, 29);
            btn_HyrHistorik.TabIndex = 3;
            btn_HyrHistorik.Text = "Visa Hyreshistorik";
            btn_HyrHistorik.UseVisualStyleBackColor = false;
            // 
            // btn_BetalMetod
            // 
            btn_BetalMetod.BackColor = Color.MediumPurple;
            btn_BetalMetod.Location = new Point(12, 118);
            btn_BetalMetod.Name = "btn_BetalMetod";
            btn_BetalMetod.Size = new Size(116, 27);
            btn_BetalMetod.TabIndex = 4;
            btn_BetalMetod.Text = "Betalningsmetod";
            btn_BetalMetod.UseVisualStyleBackColor = false;
            // 
            // btn_LogOut
            // 
            btn_LogOut.BackColor = Color.Pink;
            btn_LogOut.Location = new Point(145, 121);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new Size(75, 23);
            btn_LogOut.TabIndex = 5;
            btn_LogOut.Text = "Logga Ut";
            btn_LogOut.UseVisualStyleBackColor = false;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(356, 188);
            Controls.Add(btn_LogOut);
            Controls.Add(btn_BetalMetod);
            Controls.Add(btn_HyrHistorik);
            Controls.Add(btn_HyrFordon);
            Controls.Add(label_MakeChoice);
            Controls.Add(label_WelcomeText);
            Name = "UserMenu";
            Text = "UserMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_WelcomeText;
        private Label label_MakeChoice;
        private Button btn_HyrFordon;
        private Button btn_HyrHistorik;
        private Button btn_BetalMetod;
        private Button btn_LogOut;
    }
}