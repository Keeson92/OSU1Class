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
        private void InitializeAdminComponent()
        {
            label_AdminMenu = new Label();
            Btn_LoggaUt = new Button();
            Btn_Redigera = new Button();
            label_FordonUppdaterad = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_AdminMenu
            // 
            label_AdminMenu.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_AdminMenu.Location = new Point(490, 52);
            label_AdminMenu.MaximumSize = new Size(164, 30);
            label_AdminMenu.Name = "label_AdminMenu";
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
            // Btn_Redigera
            // 
            Btn_Redigera.Location = new Point(990, 505);
            Btn_Redigera.Name = "Btn_Redigera";
            Btn_Redigera.Size = new Size(87, 53);
            Btn_Redigera.TabIndex = 4;
            Btn_Redigera.Text = "Redigera";
            Btn_Redigera.UseVisualStyleBackColor = true;
            Btn_Redigera.Click += btn_Redigera_click;
            // 
            // label_FordonUppdaterad
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
            dataGridView1.Location = new Point(388, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(448, 216);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 608);
            Controls.Add(dataGridView1);
            Controls.Add(label_FordonUppdaterad);
            Controls.Add(Btn_Redigera);
            Controls.Add(Btn_LoggaUt);
            Controls.Add(label_AdminMenu);
            Name = "AdminMenu";
            Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_AdminMenu;
        private Button Btn_LoggaUt;
        private Button Btn_Redigera;
        private Label label_FordonUppdaterad;
        private DataGridView dataGridView1;
    }
}