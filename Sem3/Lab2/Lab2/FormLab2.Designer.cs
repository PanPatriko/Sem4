namespace Lab2
{
    partial class FormLab2
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tab1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Tab2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tab1
            // 
            this.Tab1.Location = new System.Drawing.Point(92, 56);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(75, 23);
            this.Tab1.TabIndex = 0;
            this.Tab1.Text = "Tablica [ , ]";
            this.Tab1.UseVisualStyleBackColor = true;
            this.Tab1.Click += new System.EventHandler(this.Tab1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 129);
            this.textBox1.TabIndex = 1;
            // 
            // Tab2
            // 
            this.Tab2.Location = new System.Drawing.Point(252, 56);
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(75, 23);
            this.Tab2.TabIndex = 2;
            this.Tab2.Text = "Tablica [ ][ ]";
            this.Tab2.UseVisualStyleBackColor = true;
            this.Tab2.Click += new System.EventHandler(this.Tab2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(333, 123);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 129);
            this.textBox3.TabIndex = 4;
            // 
            // FormLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Tab2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tab1);
            this.Name = "FormLab2";
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tab1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Tab2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

