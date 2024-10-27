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
            label_AdminMenu.Location = new Point(700, 87);
            label_AdminMenu.Margin = new Padding(4, 0, 4, 0);
            label_AdminMenu.MaximumSize = new Size(234, 50);
            label_AdminMenu.Name = "label_AdminMenu";
            label_AdminMenu.Size = new Size(234, 50);
            label_AdminMenu.TabIndex = 1;
            label_AdminMenu.Text = "ADMIN MENU";
            // 
            // Btn_LoggaUt
            // 
            Btn_LoggaUt.AccessibleName = "LoggaUt";
            Btn_LoggaUt.Location = new Point(51, 842);
            Btn_LoggaUt.Margin = new Padding(4, 5, 4, 5);
            Btn_LoggaUt.Name = "Btn_LoggaUt";
            Btn_LoggaUt.Size = new Size(154, 88);
            Btn_LoggaUt.TabIndex = 3;
            Btn_LoggaUt.Text = "Logga ut";
            Btn_LoggaUt.UseVisualStyleBackColor = true;
            Btn_LoggaUt.Click += btn_LoggaUt_click;
            // 
            // Btn_Redigera
            // 
            Btn_Redigera.Location = new Point(1414, 842);
            Btn_Redigera.Margin = new Padding(4, 5, 4, 5);
            Btn_Redigera.Name = "Btn_Redigera";
            Btn_Redigera.Size = new Size(124, 88);
            Btn_Redigera.TabIndex = 4;
            Btn_Redigera.Text = "Redigera";
            Btn_Redigera.UseVisualStyleBackColor = true;
            Btn_Redigera.Click += btn_Redigera_click;
            // 
            // label_FordonUppdaterad
            // 
            label_FordonUppdaterad.AutoSize = true;
            label_FordonUppdaterad.Location = new Point(766, 905);
            label_FordonUppdaterad.Margin = new Padding(4, 0, 4, 0);
            label_FordonUppdaterad.Name = "label_FordonUppdaterad";
            label_FordonUppdaterad.Size = new Size(192, 25);
            label_FordonUppdaterad.TabIndex = 7;
            label_FordonUppdaterad.Text = "Fordon Uppdaterades!";
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "FordonStatusStationGrid";
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(554, 380);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(627, 360);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 1013);
            Controls.Add(dataGridView1);
            Controls.Add(label_FordonUppdaterad);
            Controls.Add(Btn_Redigera);
            Controls.Add(Btn_LoggaUt);
            Controls.Add(label_AdminMenu);
            Margin = new Padding(4, 5, 4, 5);
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