namespace Lab9
{
    partial class FormMain
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
            this.buttonLiczba1 = new System.Windows.Forms.Button();
            this.buttonLiczba2 = new System.Windows.Forms.Button();
            this.buttonWynik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLiczba1
            // 
            this.buttonLiczba1.Location = new System.Drawing.Point(21, 15);
            this.buttonLiczba1.Name = "buttonLiczba1";
            this.buttonLiczba1.Size = new System.Drawing.Size(75, 23);
            this.buttonLiczba1.TabIndex = 0;
            this.buttonLiczba1.Text = "2";
            this.buttonLiczba1.UseVisualStyleBackColor = true;
            this.buttonLiczba1.Click += new System.EventHandler(this.buttonLiczba1_Click);
            // 
            // buttonLiczba2
            // 
            this.buttonLiczba2.Location = new System.Drawing.Point(126, 15);
            this.buttonLiczba2.Name = "buttonLiczba2";
            this.buttonLiczba2.Size = new System.Drawing.Size(75, 23);
            this.buttonLiczba2.TabIndex = 1;
            this.buttonLiczba2.Text = "2";
            this.buttonLiczba2.UseVisualStyleBackColor = true;
            this.buttonLiczba2.Click += new System.EventHandler(this.buttonLiczba2_Click);
            // 
            // buttonWynik
            // 
            this.buttonWynik.Location = new System.Drawing.Point(21, 65);
            this.buttonWynik.Name = "buttonWynik";
            this.buttonWynik.Size = new System.Drawing.Size(75, 23);
            this.buttonWynik.TabIndex = 2;
            this.buttonWynik.Text = "=";
            this.buttonWynik.UseVisualStyleBackColor = true;
            this.buttonWynik.Click += new System.EventHandler(this.buttonWynik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(122, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(102, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 154);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWynik);
            this.Controls.Add(this.buttonLiczba2);
            this.Controls.Add(this.buttonLiczba1);
            this.Name = "FormMain";
            this.Text = "Lab9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLiczba2;
        private System.Windows.Forms.Button buttonWynik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonLiczba1;
    }
}

