namespace Presentationslager
{
    partial class Solrosvagen
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
            dataGridView1 = new DataGridView();
            boka = new Button();
            huvudmeny = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(129, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(487, 280);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // boka
            // 
            boka.Location = new Point(640, 403);
            boka.Name = "boka";
            boka.Size = new Size(112, 34);
            boka.TabIndex = 1;
            boka.Text = "Boka";
            boka.UseVisualStyleBackColor = true;
            boka.Click += boka_Click;
            // 
            // huvudmeny
            // 
            huvudmeny.Location = new Point(68, 403);
            huvudmeny.Name = "huvudmeny";
            huvudmeny.Size = new Size(123, 34);
            huvudmeny.TabIndex = 2;
            huvudmeny.Text = "Huvudmeny";
            huvudmeny.UseVisualStyleBackColor = true;
            huvudmeny.Click += huvudmeny_Click;
            // 
            // Solrosvagen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(huvudmeny);
            Controls.Add(boka);
            Controls.Add(dataGridView1);
            Name = "Solrosvagen";
            Text = "Solrosvagen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button boka;
        private Button huvudmeny;
    }
}