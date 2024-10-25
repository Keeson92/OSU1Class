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
            label1 = new Label();
            btn_Allégatan = new Button();
            btn_Stationsgatan = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 15);
            label1.TabIndex = 0;
            label1.Text = "Från vilken station vill du hyra från?";
            label1.Click += this.label1_Click;
            // 
            // btn_Allégatan
            // 
            btn_Allégatan.Location = new Point(20, 34);
            btn_Allégatan.Name = "btn_Allégatan";
            btn_Allégatan.Size = new Size(75, 23);
            btn_Allégatan.TabIndex = 1;
            btn_Allégatan.Text = "Allégatan";
            btn_Allégatan.UseVisualStyleBackColor = true;
            // 
            // btn_Stationsgatan
            // 
            btn_Stationsgatan.Location = new Point(20, 63);
            btn_Stationsgatan.Name = "btn_Stationsgatan";
            btn_Stationsgatan.Size = new Size(94, 24);
            btn_Stationsgatan.TabIndex = 2;
            btn_Stationsgatan.Text = "Stationsgatan";
            btn_Stationsgatan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(20, 93);
            button1.Name = "button1";
            button1.Size = new Size(127, 26);
            button1.TabIndex = 3;
            button1.Text = "Fredriksbergsgatan";
            button1.UseVisualStyleBackColor = true;
            // 
            // HyrFordon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(402, 193);
            Controls.Add(button1);
            Controls.Add(btn_Stationsgatan);
            Controls.Add(btn_Allégatan);
            Controls.Add(label1);
            Name = "HyrFordon";
            Text = "HyrFordon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Allégatan;
        private Button btn_Stationsgatan;
        private Button button1;
    }
}