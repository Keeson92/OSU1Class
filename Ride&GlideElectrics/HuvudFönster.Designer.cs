using System;
using Windows;
using System.Windows.Forms;

namespace GreenWheels
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
            UserName.Location = new Point(11, 17);
            UserName.Margin = new Padding(4, 0, 4, 0);
            UserName.Name = "UserName";
            UserName.Size = new Size(137, 25);
            UserName.TabIndex = 0;
            UserName.Text = "Användarnamn:";
            UserName.Click += label_UserName_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(151, 12);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(141, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 60);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(141, 31);
            txtPassword.TabIndex = 2;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(17, 65);
            Password.Margin = new Padding(4, 0, 4, 0);
            Password.Name = "Password";
            Password.Size = new Size(90, 25);
            Password.TabIndex = 3;
            Password.Text = "Lösenord:";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Salmon;
            btnLogIn.Location = new Point(167, 128);
            btnLogIn.Margin = new Padding(4, 5, 4, 5);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(107, 38);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Logga in";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnRegistrering
            // 
            btnRegistrering.BackColor = Color.Bisque;
            btnRegistrering.Location = new Point(17, 128);
            btnRegistrering.Margin = new Padding(4, 5, 4, 5);
            btnRegistrering.Name = "btnRegistrering";
            btnRegistrering.Size = new Size(126, 38);
            btnRegistrering.TabIndex = 5;
            btnRegistrering.Text = "Registrering";
            btnRegistrering.UseVisualStyleBackColor = false;
            // 
            // HuvudFönster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(396, 273);
            Controls.Add(btnRegistrering);
            Controls.Add(btnLogIn);
            Controls.Add(Password);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(UserName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HuvudFönster";
            Text = "GreenWheels";
            Load += HuvudFönster_Load;
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
