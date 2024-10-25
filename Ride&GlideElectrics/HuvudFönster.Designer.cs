using System;
using Windows;
using System.Windows.Forms;

namespace Ride_GlideElectrics
{
    partial class HuvudFönster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserName = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            Password = new Label();
            btnLogIn = new Button();
            btnRegistrering = new Button();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.BackColor = Color.Transparent;
            UserName.Location = new Point(8, 10);
            UserName.Name = "UserName";
            UserName.Size = new Size(92, 15);
            UserName.TabIndex = 0;
            UserName.Text = "Användarnamn:";
            UserName.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(106, 7);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(106, 36);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 2;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(12, 39);
            Password.Name = "Password";
            Password.Size = new Size(59, 15);
            Password.TabIndex = 3;
            Password.Text = "Lösenord:";
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(117, 77);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(75, 23);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Logga in";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnRegistrering
            // 
            btnRegistrering.Location = new Point(12, 77);
            btnRegistrering.Name = "btnRegistrering";
            btnRegistrering.Size = new Size(88, 23);
            btnRegistrering.TabIndex = 5;
            btnRegistrering.Text = "Registrering";
            btnRegistrering.UseVisualStyleBackColor = true;
            // 
            // HuvudFönster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 164);
            Controls.Add(btnRegistrering);
            Controls.Add(btnLogIn);
            Controls.Add(Password);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(UserName);
            Name = "HuvudFönster";
            Text = "Ride&Glide Electrics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label UserName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label Password;
        private Button btnLogIn;
        private Button btnRegistrering;
    }
}
