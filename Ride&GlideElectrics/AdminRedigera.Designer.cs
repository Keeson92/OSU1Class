namespace Presentationslager
{
    partial class AdminRedigera : Form
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            ID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(77, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 338);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(121, 269);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(173, 23);
            textBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.AccessibleName = "Spara ändringar";
            button1.Location = new Point(507, 311);
            button1.Name = "button1";
            button1.Size = new Size(185, 104);
            button1.TabIndex = 4;
            button1.Text = "Spara";
            button1.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            ID.AccessibleName = "idLable";
            ID.AutoSize = true;
            ID.Location = new Point(121, 104);
            ID.Name = "ID";
            ID.Size = new Size(38, 15);
            ID.TabIndex = 5;
            ID.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 176);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 251);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 320);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // AdminRedigera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ID);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AdminRedigera";
            Text = "AdminRedigera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label ID;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}