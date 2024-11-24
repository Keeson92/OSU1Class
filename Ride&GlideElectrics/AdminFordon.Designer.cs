namespace GreenWheels
{
    partial class AdminFordon : Form
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


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            fordonsIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            positionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fordonsTypDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fordonBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fordonBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleName = "LoggaUt";
            button1.Location = new Point(64, 607);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(163, 88);
            button1.TabIndex = 0;
            button1.Text = "Logga ut";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AccessibleName = "Redigera";
            button2.Location = new Point(926, 607);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(153, 88);
            button2.TabIndex = 1;
            button2.Text = "Redigera";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fordonsIDDataGridViewTextBoxColumn, positionDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, fordonsTypDataGridViewTextBoxColumn });
            dataGridView1.DataSource = fordonBindingSource;
            dataGridView1.Location = new Point(17, 20);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(634, 448);
            dataGridView1.TabIndex = 2;
            // 
            // fordonsIDDataGridViewTextBoxColumn
            // 
            fordonsIDDataGridViewTextBoxColumn.DataPropertyName = "FordonsID";
            fordonsIDDataGridViewTextBoxColumn.HeaderText = "FordonsID";
            fordonsIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            fordonsIDDataGridViewTextBoxColumn.Name = "fordonsIDDataGridViewTextBoxColumn";
            fordonsIDDataGridViewTextBoxColumn.ReadOnly = true;
            fordonsIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            positionDataGridViewTextBoxColumn.HeaderText = "Position";
            positionDataGridViewTextBoxColumn.MinimumWidth = 8;
            positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            positionDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // fordonsTypDataGridViewTextBoxColumn
            // 
            fordonsTypDataGridViewTextBoxColumn.DataPropertyName = "FordonsTyp";
            fordonsTypDataGridViewTextBoxColumn.HeaderText = "FordonsTyp";
            fordonsTypDataGridViewTextBoxColumn.MinimumWidth = 8;
            fordonsTypDataGridViewTextBoxColumn.Name = "fordonsTypDataGridViewTextBoxColumn";
            fordonsTypDataGridViewTextBoxColumn.Width = 150;
            // 
            // fordonBindingSource
            // 
            fordonBindingSource.DataSource = typeof(BusinessEntities.Fordon);
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "idBox";
            textBox1.Location = new Point(721, 60);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "Possitionbox";
            textBox2.Location = new Point(724, 162);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.AccessibleName = "Status box";
            textBox3.Location = new Point(724, 282);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 31);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.AccessibleName = "Typbox";
            textBox4.Location = new Point(724, 390);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 31);
            textBox4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AccessibleName = "IDlab";
            label1.AutoSize = true;
            label1.Location = new Point(721, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AccessibleName = "possitionID";
            label2.AutoSize = true;
            label2.Location = new Point(726, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 8;
            label2.Text = "Possition";
            // 
            // label3
            // 
            label3.AccessibleName = "status";
            label3.AutoSize = true;
            label3.Location = new Point(724, 250);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 9;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AccessibleName = "Fordonstyplable";
            label4.AutoSize = true;
            label4.Location = new Point(726, 358);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 10;
            label4.Text = "Fordonstyp";
            // 
            // AdminFordon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminFordon";
            Text = "AdminFordon";
            Load += AdminFordon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fordonBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fordonsIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fordonsTypDataGridViewTextBoxColumn;
        private BindingSource fordonBindingSource;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}