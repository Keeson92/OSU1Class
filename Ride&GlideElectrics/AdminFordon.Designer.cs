namespace Ride_GlideElectrics
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fordonBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleName = "LoggaUt";
            button1.Location = new Point(45, 364);
            button1.Name = "button1";
            button1.Size = new Size(114, 53);
            button1.TabIndex = 0;
            button1.Text = "Logga ut";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AccessibleName = "Redigera";
            button2.Location = new Point(648, 364);
            button2.Name = "button2";
            button2.Size = new Size(107, 53);
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
            dataGridView1.Location = new Point(195, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 307);
            dataGridView1.TabIndex = 2;
            // 
            // fordonsIDDataGridViewTextBoxColumn
            // 
            fordonsIDDataGridViewTextBoxColumn.DataPropertyName = "FordonsID";
            fordonsIDDataGridViewTextBoxColumn.HeaderText = "FordonsID";
            fordonsIDDataGridViewTextBoxColumn.Name = "fordonsIDDataGridViewTextBoxColumn";
            fordonsIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            positionDataGridViewTextBoxColumn.HeaderText = "Position";
            positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // fordonsTypDataGridViewTextBoxColumn
            // 
            fordonsTypDataGridViewTextBoxColumn.DataPropertyName = "FordonsTyp";
            fordonsTypDataGridViewTextBoxColumn.HeaderText = "FordonsTyp";
            fordonsTypDataGridViewTextBoxColumn.Name = "fordonsTypDataGridViewTextBoxColumn";
            // 
            // fordonBindingSource
            // 
            fordonBindingSource.DataSource = typeof(BusinessEntities.Fordon);
            // 
            // AdminFordon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdminFordon";
            Text = "AdminFordon";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fordonBindingSource).EndInit();
            ResumeLayout(false);
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
    }
}