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
            button1 = new Button();
            button2 = new Button();
            Boka = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(212, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(486, 270);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Huvudmeny
            // 
            Huvudmeny.Location = new Point(0, 0);
            Huvudmeny.Name = "Huvudmeny";
            Huvudmeny.Size = new Size(75, 23);
            Huvudmeny.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(829, 805);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Boka";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Boka_Click;
            // 
            // button2
            // 
            button2.Location = new Point(76, 805);
            button2.Name = "button2";
            button2.Size = new Size(130, 34);
            button2.TabIndex = 2;
            button2.Text = "Huvudmeny";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Huvudmeny_Click;
            // 
            // Allegatan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 882);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Allegatan";
            Text = "Allegatan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Boka;
        private Button Huvudmeny;
        private Button button1;
        private Button button2;
    }
}