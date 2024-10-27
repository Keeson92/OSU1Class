namespace Ride_GlideElectrics
{
    partial class RedigeraFordon
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
            Redigera = new Button();
            label1 = new Label();
            Tillbaka = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            Redigera.Location = new Point(636, 361);
            Redigera.Name = "button1";
            Redigera.Size = new Size(75, 23);
            Redigera.TabIndex = 0;
            Redigera.Text = "Bekräfta ändring";
            Redigera.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 22);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "Redigera valt fordon";
            // 
            // button2
            // 
            Tillbaka.AccessibleName = "Tillbaka";
            Tillbaka.Location = new Point(36, 361);
            Tillbaka.Name = "button2";
            Tillbaka.Size = new Size(75, 23);
            Tillbaka.TabIndex = 2;
            Tillbaka.Text = "tillbaka";
            Tillbaka.UseVisualStyleBackColor = true;
            // 
            // RedigeraFordon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Tillbaka);
            Controls.Add(label1);
            Controls.Add(Redigera);
            Name = "RedigeraFordon";
            Text = "RedigeraFordon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Redigera;
        private Label label1;
        private Button Tillbaka;
    }
}