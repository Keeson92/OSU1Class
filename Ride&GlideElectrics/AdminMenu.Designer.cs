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
            label_Fordon = new Label();
            label_AdminMenu = new Label();
            Btn_LoggaUt = new Button();
            Btn_Redigera = new Button();
            label_Status = new Label();
            label_Station = new Label();
            label_FordonUppdaterad = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_Fordon
            // 
            label_Fordon.AutoSize = true;
            label_Fordon.Location = new Point(257, 186);
            label_Fordon.Name = "label_Fordon";
            label_Fordon.Size = new Size(45, 15);
            label_Fordon.TabIndex = 0;
            label_Fordon.Text = "Fordon";

            // 
            // label2
            // 
            label_AdminMenu.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_AdminMenu.Location = new Point(490, 52);
            label_AdminMenu.MaximumSize = new Size(164, 30);
            label_AdminMenu.Name = "labelAdminMenu";
            label_AdminMenu.Size = new Size(164, 30);
            label_AdminMenu.TabIndex = 1;
            label_AdminMenu.Text = "ADMIN MENU";
            // 
            // Btn_LoggaUt
            // 
            Btn_LoggaUt.AccessibleName = "LoggaUt";
            Btn_LoggaUt.Location = new Point(36, 505);
            Btn_LoggaUt.Name = "Btn_LoggaUt";
            Btn_LoggaUt.Size = new Size(108, 53);
            Btn_LoggaUt.TabIndex = 3;
            Btn_LoggaUt.Text = "Logga ut";
            Btn_LoggaUt.UseVisualStyleBackColor = true;
            Btn_LoggaUt.Click += btn_LoggaUt_click;
            // 
            // btn_Redigera
            // 
            Btn_Redigera.Location = new Point(990, 505);
            Btn_Redigera.Name = "btn_Redigera";
            Btn_Redigera.Size = new Size(87, 53);
            Btn_Redigera.TabIndex = 4;
            Btn_Redigera.Text = "Redigera";
            Btn_Redigera.UseVisualStyleBackColor = true;
            Btn_Redigera.Click += btn_Redigera_click;
            // 
            // label_Status
            // 
            label_Status.AutoSize = true;
            label_Status.Location = new Point(536, 186);
            label_Status.Name = "label_Status";
            label_Status.Size = new Size(39, 15);
            label_Status.TabIndex = 5;
            label_Status.Text = "Status";
            // 
            // label_Station
            // 
            label_Station.AutoSize = true;
            label_Station.Location = new Point(871, 186);
            label_Station.Name = "label_Station";
            label_Station.Size = new Size(44, 15);
            label_Station.TabIndex = 6;
            label_Station.Text = "Station";
            // 
            // label5
            // 
            label_FordonUppdaterad.AutoSize = true;
            label_FordonUppdaterad.Location = new Point(536, 543);
            label_FordonUppdaterad.Name = "label_FordonUppdaterad";
            label_FordonUppdaterad.Size = new Size(124, 15);
            label_FordonUppdaterad.TabIndex = 7;
            label_FordonUppdaterad.Text = "Fordon Uppdaterades!";
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
            Controls.Add(label_FordonUppdaterad);
            Controls.Add(label_Station);
            Controls.Add(label_Status);
            Controls.Add(Btn_Redigera);
            Controls.Add(Btn_LoggaUt);
            Controls.Add(label_AdminMenu);
            Controls.Add(label_Fordon);
            Name = "AdminMenu";
            Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Fordon;
        private Label label_AdminMenu;
        private Button Btn_LoggaUt;
        private Button Btn_Redigera;
        private Label label_Status;
        private Label label_Station;
        private Label label_FordonUppdaterad;
        private DataGridView dataGridView1;
    }
}