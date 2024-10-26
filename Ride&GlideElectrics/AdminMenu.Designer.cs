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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 165);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Fordon";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(490, 52);
            label2.MaximumSize = new Size(164, 30);
            label2.Name = "label2";
            label2.Size = new Size(164, 30);
            label2.TabIndex = 1;
            label2.Text = "ADMIN MENY";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.AccessibleName = "LoggaUt";
            button1.Location = new Point(36, 505);
            button1.Name = "button1";
            button1.Size = new Size(108, 53);
            button1.TabIndex = 3;
            button1.Text = "Logga ut";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(990, 505);
            button2.Name = "button2";
            button2.Size = new Size(87, 53);
            button2.TabIndex = 4;
            button2.Text = "Redigera";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(555, 165);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(881, 165);
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
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "FordonStatusStationGrid";
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(245, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(680, 270);
            dataGridView1.TabIndex = 8;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 608);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Redigera);
            Controls.Add(LoggaUt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminMenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}