namespace Ride_GlideElectrics
{
    partial class AdminMenu
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
            label2 = new Label();
            LoggaUt = new Button();
            Redigera = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            FordonStatusStationGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)FordonStatusStationGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 190);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Fordon";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(515, 56);
            label2.MaximumSize = new Size(164, 30);
            label2.Name = "label2";
            label2.Size = new Size(164, 30);
            label2.TabIndex = 1;
            label2.Text = "ADMIN MENY";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            LoggaUt.AccessibleName = "LoggaUt";
            LoggaUt.Location = new Point(36, 505);
            LoggaUt.Name = "button1";
            LoggaUt.Size = new Size(108, 53);
            LoggaUt.TabIndex = 3;
            LoggaUt.Text = "Logga ut";
            LoggaUt.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            Redigera.Location = new Point(990, 505);
            Redigera.Name = "button2";
            Redigera.Size = new Size(87, 53);
            Redigera.TabIndex = 4;
            Redigera.Text = "Redigera";
            Redigera.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(561, 190);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(881, 190);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "Station";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(536, 543);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 7;
            label5.Text = "Fordon Uppdatrades!";
            // 
            // FordonStatusStationGrid
            // 
            FordonStatusStationGrid.AccessibleName = "FordonStatusStationGrid";
            FordonStatusStationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FordonStatusStationGrid.Location = new Point(245, 227);
            FordonStatusStationGrid.Name = "FordonStatusStationGrid";
            FordonStatusStationGrid.Size = new Size(680, 270);
            FordonStatusStationGrid.TabIndex = 8;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 608);
            Controls.Add(FordonStatusStationGrid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Redigera);
            Controls.Add(LoggaUt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminMenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)FordonStatusStationGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button LoggaUt;
            private void LoggaUt_Click(object sender, EventArgs e)
            {
             HuvudFönster huvudFönster = new HuvudFönster(); // Skapar en instans av inloggningsfönstret
             huvudFönster.Show(); // Öppnar det nya fönstret
             this.Close(); // Stänger det aktuella fönstret
            }

        private Button Redigera;
        private void Redigera_Click(object sender, EventArgs e)
        {
            HuvudFönster RedigeraFordon = new HuvudFönster(); // Skapar en instans av inloggningsfönstret
            RedigeraFordon.Show(); // Öppnar det nya fönstret
            
        }

        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView FordonStatusStationGrid;
    }
}