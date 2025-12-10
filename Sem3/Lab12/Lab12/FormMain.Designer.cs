namespace Lab12
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonLambda1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.buttonLambda2 = new System.Windows.Forms.Button();
            this.buttonLambda3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.buttonLambda4 = new System.Windows.Forms.Button();
            this.buttonLambda5 = new System.Windows.Forms.Button();
            this.buttonLambda6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonLambda7 = new System.Windows.Forms.Button();
            this.buttonLambda8 = new System.Windows.Forms.Button();
            this.buttonLambda9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(85, 67);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // buttonLambda1
            // 
            this.buttonLambda1.Location = new System.Drawing.Point(136, 67);
            this.buttonLambda1.Name = "buttonLambda1";
            this.buttonLambda1.Size = new System.Drawing.Size(75, 20);
            this.buttonLambda1.TabIndex = 2;
            this.buttonLambda1.Text = "n^3";
            this.buttonLambda1.UseVisualStyleBackColor = true;
            this.buttonLambda1.Click += new System.EventHandler(this.buttonLambda1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "b";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(85, 93);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // buttonLambda2
            // 
            this.buttonLambda2.Location = new System.Drawing.Point(136, 91);
            this.buttonLambda2.Name = "buttonLambda2";
            this.buttonLambda2.Size = new System.Drawing.Size(75, 20);
            this.buttonLambda2.TabIndex = 6;
            this.buttonLambda2.Text = "n^p";
            this.buttonLambda2.UseVisualStyleBackColor = true;
            this.buttonLambda2.Click += new System.EventHandler(this.buttonLambda2_Click);
            // 
            // buttonLambda3
            // 
            this.buttonLambda3.Location = new System.Drawing.Point(136, 117);
            this.buttonLambda3.Name = "buttonLambda3";
            this.buttonLambda3.Size = new System.Drawing.Size(93, 20);
            this.buttonLambda3.TabIndex = 7;
            this.buttonLambda3.Text = "Mniejsza (a,b)";
            this.buttonLambda3.UseVisualStyleBackColor = true;
            this.buttonLambda3.Click += new System.EventHandler(this.buttonLambda3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "c";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(85, 119);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown3.TabIndex = 8;
            // 
            // buttonLambda4
            // 
            this.buttonLambda4.Location = new System.Drawing.Point(85, 145);
            this.buttonLambda4.Name = "buttonLambda4";
            this.buttonLambda4.Size = new System.Drawing.Size(99, 22);
            this.buttonLambda4.TabIndex = 10;
            this.buttonLambda4.Text = "Srodkowy (a,b,c)";
            this.buttonLambda4.UseVisualStyleBackColor = true;
            this.buttonLambda4.Click += new System.EventHandler(this.buttonLambda4_Click);
            // 
            // buttonLambda5
            // 
            this.buttonLambda5.Location = new System.Drawing.Point(85, 173);
            this.buttonLambda5.Name = "buttonLambda5";
            this.buttonLambda5.Size = new System.Drawing.Size(132, 22);
            this.buttonLambda5.TabIndex = 11;
            this.buttonLambda5.Text = "Czy a jest parzyste?";
            this.buttonLambda5.UseVisualStyleBackColor = true;
            this.buttonLambda5.Click += new System.EventHandler(this.buttonLambda5_Click);
            // 
            // buttonLambda6
            // 
            this.buttonLambda6.Location = new System.Drawing.Point(85, 201);
            this.buttonLambda6.Name = "buttonLambda6";
            this.buttonLambda6.Size = new System.Drawing.Size(165, 22);
            this.buttonLambda6.TabIndex = 12;
            this.buttonLambda6.Text = "Czy a jest podzielne przez b?";
            this.buttonLambda6.UseVisualStyleBackColor = true;
            this.buttonLambda6.Click += new System.EventHandler(this.buttonLambda6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Wpisz tekst lub znak";
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 342);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 20);
            this.textBox3.TabIndex = 14;
            // 
            // buttonLambda7
            // 
            this.buttonLambda7.Location = new System.Drawing.Point(85, 255);
            this.buttonLambda7.Name = "buttonLambda7";
            this.buttonLambda7.Size = new System.Drawing.Size(165, 23);
            this.buttonLambda7.TabIndex = 15;
            this.buttonLambda7.Text = "Zmien małą litere na dużą";
            this.buttonLambda7.UseVisualStyleBackColor = true;
            this.buttonLambda7.Click += new System.EventHandler(this.buttonLambda7_Click);
            // 
            // buttonLambda8
            // 
            this.buttonLambda8.Location = new System.Drawing.Point(85, 284);
            this.buttonLambda8.Name = "buttonLambda8";
            this.buttonLambda8.Size = new System.Drawing.Size(165, 23);
            this.buttonLambda8.TabIndex = 16;
            this.buttonLambda8.Text = "Zmień wszytkie litery na duże";
            this.buttonLambda8.UseVisualStyleBackColor = true;
            this.buttonLambda8.Click += new System.EventHandler(this.buttonLambda8_Click);
            // 
            // buttonLambda9
            // 
            this.buttonLambda9.Location = new System.Drawing.Point(85, 313);
            this.buttonLambda9.Name = "buttonLambda9";
            this.buttonLambda9.Size = new System.Drawing.Size(165, 23);
            this.buttonLambda9.TabIndex = 17;
            this.buttonLambda9.Text = "Wyświetl kolejną litere alfabetu";
            this.buttonLambda9.UseVisualStyleBackColor = true;
            this.buttonLambda9.Click += new System.EventHandler(this.buttonLambda9_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.buttonLambda9);
            this.Controls.Add(this.buttonLambda8);
            this.Controls.Add(this.buttonLambda7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonLambda6);
            this.Controls.Add(this.buttonLambda5);
            this.Controls.Add(this.buttonLambda4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.buttonLambda3);
            this.Controls.Add(this.buttonLambda2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLambda1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormMain";
            this.Text = "Lab12";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonLambda1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button buttonLambda2;
        private System.Windows.Forms.Button buttonLambda3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button buttonLambda4;
        private System.Windows.Forms.Button buttonLambda5;
        private System.Windows.Forms.Button buttonLambda6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonLambda7;
        private System.Windows.Forms.Button buttonLambda8;
        private System.Windows.Forms.Button buttonLambda9;
    }
}

