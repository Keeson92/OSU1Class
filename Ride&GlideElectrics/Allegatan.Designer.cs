namespace Presentationslager
{
    partial class Allegatan
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
            Button Boka;
            dataGridView1 = new DataGridView();
            Huvudmeny = new Button();
            Boka = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 71);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(340, 162);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Boka
            // 
            Boka.Location = new Point(556, 478);
            Boka.Name = "Boka";
            Boka.Size = new Size(112, 34);
            Boka.TabIndex = 1;
            Boka.Text = "Boka";
            Boka.UseVisualStyleBackColor = true;
            Boka.Click += boka_Click;
            // 
            // Huvudmeny
            // 
            /*button2.Location = new Point(43, 478);
            button2.Name = "button2";
            button2.Size = new Size(125, 34);
            button2.TabIndex = 2;
            button2.Text = "Huvudmeny";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            */ 
            // Allegatan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 529);
            //Controls.Add(button2);
            //Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Allegatan";
            Text = "Allegatan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Boka;
        private Button Huvudmeny;
    }
}