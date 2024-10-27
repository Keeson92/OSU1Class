namespace Ride_GlideElectrics
{
    partial class HyrFordon
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
            btn_Allégatan = new Button();
            btn_Stationsgatan = new Button();
            btn_Fredriksbergsgatan = new Button();
            btn_Solrosvägen = new Button();
            btnTillbakaTillUserMenu = new Button();
            label_StationsVal = new Label();
            SuspendLayout();
            // 
            // btn_Allégatan
            // 
            btn_Allégatan.BackColor = Color.Gold;
            btn_Allégatan.Location = new Point(86, 57);
            btn_Allégatan.Margin = new Padding(4, 5, 4, 5);
            btn_Allégatan.Name = "btn_Allégatan";
            btn_Allégatan.Size = new Size(107, 38);
            btn_Allégatan.TabIndex = 1;
            btn_Allégatan.Text = "Allégatan";
            btn_Allégatan.UseVisualStyleBackColor = false;
            btn_Allégatan.Click += btn_Allégatan_Click;
            // 
            // btn_Stationsgatan
            // 
            btn_Stationsgatan.BackColor = Color.YellowGreen;
            btn_Stationsgatan.Location = new Point(76, 105);
            btn_Stationsgatan.Margin = new Padding(4, 5, 4, 5);
            btn_Stationsgatan.Name = "btn_Stationsgatan";
            btn_Stationsgatan.Size = new Size(134, 40);
            btn_Stationsgatan.TabIndex = 2;
            btn_Stationsgatan.Text = "Stationsgatan";
            btn_Stationsgatan.UseVisualStyleBackColor = false;
            btn_Stationsgatan.Click += btn_Stationsgatan_Click;
            // 
            // btn_Fredriksbergsgatan
            // 
            btn_Fredriksbergsgatan.BackColor = Color.PaleTurquoise;
            btn_Fredriksbergsgatan.Location = new Point(54, 155);
            btn_Fredriksbergsgatan.Margin = new Padding(4, 5, 4, 5);
            btn_Fredriksbergsgatan.Name = "btn_Fredriksbergsgatan";
            btn_Fredriksbergsgatan.Size = new Size(181, 43);
            btn_Fredriksbergsgatan.TabIndex = 3;
            btn_Fredriksbergsgatan.Text = "Fredriksbergsgatan";
            btn_Fredriksbergsgatan.UseVisualStyleBackColor = false;
            btn_Fredriksbergsgatan.Click += btn_Fredriksbergsgatan_Click;
            // 
            // btn_Solrosvägen
            // 
            btn_Solrosvägen.BackColor = Color.Plum;
            btn_Solrosvägen.Location = new Point(69, 208);
            btn_Solrosvägen.Margin = new Padding(4, 5, 4, 5);
            btn_Solrosvägen.Name = "btn_Solrosvägen";
            btn_Solrosvägen.Size = new Size(141, 43);
            btn_Solrosvägen.TabIndex = 4;
            btn_Solrosvägen.Text = "Solrosvägen";
            btn_Solrosvägen.UseVisualStyleBackColor = false;
            btn_Solrosvägen.Click += btn_Solrosvägen_Click;
            // 
            // btnTillbakaTillUserMenu
            // 
            btnTillbakaTillUserMenu.BackColor = Color.DarkBlue;
            btnTillbakaTillUserMenu.ForeColor = SystemColors.ButtonFace;
            btnTillbakaTillUserMenu.Location = new Point(86, 298);
            btnTillbakaTillUserMenu.Margin = new Padding(4, 5, 4, 5);
            btnTillbakaTillUserMenu.Name = "btnTillbakaTillUserMenu";
            btnTillbakaTillUserMenu.Size = new Size(107, 38);
            btnTillbakaTillUserMenu.TabIndex = 5;
            btnTillbakaTillUserMenu.Text = "Tillbaka";
            btnTillbakaTillUserMenu.UseVisualStyleBackColor = false;
            btnTillbakaTillUserMenu.Click += btnTillbakaTillUserMenu_Click;
            // 
            // label_StationsVal
            // 
            label_StationsVal.AutoSize = true;
            label_StationsVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_StationsVal.Location = new Point(17, 15);
            label_StationsVal.Margin = new Padding(4, 0, 4, 0);
            label_StationsVal.Name = "label_StationsVal";
            label_StationsVal.Size = new Size(277, 25);
            label_StationsVal.TabIndex = 6;
            label_StationsVal.Text = "Vilken station vill du hyra från?";
            // 
            // HyrFordon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(350, 357);
            Controls.Add(label_StationsVal);
            Controls.Add(btnTillbakaTillUserMenu);
            Controls.Add(btn_Solrosvägen);
            Controls.Add(btn_Fredriksbergsgatan);
            Controls.Add(btn_Stationsgatan);
            Controls.Add(btn_Allégatan);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HyrFordon";
            Text = "HyrFordon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_StationsVal;
        private Button btn_Allégatan;
        private Button btn_Stationsgatan;
        private Button btn_Fredriksbergsgatan;
        private Button btn_Solrosvägen;
        private Button btnTillbakaTillUserMenu;
    }
}