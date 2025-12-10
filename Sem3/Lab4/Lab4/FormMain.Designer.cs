namespace Lab4
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonOdejmij = new System.Windows.Forms.Button();
            this.buttonPomnoz = new System.Windows.Forms.Button();
            this.buttonPodziel = new System.Windows.Forms.Button();
            this.labelWynik = new System.Windows.Forms.Label();
            this.textBoxR1 = new System.Windows.Forms.TextBox();
            this.textBoxU1 = new System.Windows.Forms.TextBox();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.textBoxU2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonRowne = new System.Windows.Forms.Button();
            this.buttonRozne = new System.Windows.Forms.Button();
            this.buttonWiekszy = new System.Windows.Forms.Button();
            this.buttonMniejszy = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonGetHashCode = new System.Windows.Forms.Button();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Enabled = false;
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDodaj.Location = new System.Drawing.Point(36, 229);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(143, 27);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Liczba1 + Liczba2";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonOdejmij
            // 
            this.buttonOdejmij.Enabled = false;
            this.buttonOdejmij.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOdejmij.Location = new System.Drawing.Point(36, 258);
            this.buttonOdejmij.Name = "buttonOdejmij";
            this.buttonOdejmij.Size = new System.Drawing.Size(143, 27);
            this.buttonOdejmij.TabIndex = 1;
            this.buttonOdejmij.Text = "Liczba1 - Liczba2";
            this.buttonOdejmij.UseVisualStyleBackColor = true;
            this.buttonOdejmij.Click += new System.EventHandler(this.buttonOdejmij_Click);
            // 
            // buttonPomnoz
            // 
            this.buttonPomnoz.Enabled = false;
            this.buttonPomnoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonPomnoz.Location = new System.Drawing.Point(36, 287);
            this.buttonPomnoz.Name = "buttonPomnoz";
            this.buttonPomnoz.Size = new System.Drawing.Size(143, 27);
            this.buttonPomnoz.TabIndex = 2;
            this.buttonPomnoz.Text = "Liczba1 * Liczba2";
            this.buttonPomnoz.UseVisualStyleBackColor = true;
            this.buttonPomnoz.Click += new System.EventHandler(this.buttonPomnoz_Click);
            // 
            // buttonPodziel
            // 
            this.buttonPodziel.Enabled = false;
            this.buttonPodziel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonPodziel.Location = new System.Drawing.Point(36, 316);
            this.buttonPodziel.Name = "buttonPodziel";
            this.buttonPodziel.Size = new System.Drawing.Size(143, 27);
            this.buttonPodziel.TabIndex = 3;
            this.buttonPodziel.Text = "Liczba1 / Liczba2";
            this.buttonPodziel.UseVisualStyleBackColor = true;
            this.buttonPodziel.Click += new System.EventHandler(this.buttonPodziel_Click);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelWynik.Location = new System.Drawing.Point(31, 187);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(83, 25);
            this.labelWynik.TabIndex = 4;
            this.labelWynik.Text = "Wynik : ";
            // 
            // textBoxR1
            // 
            this.textBoxR1.Location = new System.Drawing.Point(27, 45);
            this.textBoxR1.Name = "textBoxR1";
            this.textBoxR1.Size = new System.Drawing.Size(100, 20);
            this.textBoxR1.TabIndex = 5;
            // 
            // textBoxU1
            // 
            this.textBoxU1.Location = new System.Drawing.Point(27, 71);
            this.textBoxU1.Name = "textBoxU1";
            this.textBoxU1.Size = new System.Drawing.Size(100, 20);
            this.textBoxU1.TabIndex = 6;
            // 
            // textBoxR2
            // 
            this.textBoxR2.Location = new System.Drawing.Point(133, 45);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.Size = new System.Drawing.Size(100, 20);
            this.textBoxR2.TabIndex = 7;
            // 
            // textBoxU2
            // 
            this.textBoxU2.Location = new System.Drawing.Point(133, 71);
            this.textBoxU2.Name = "textBoxU2";
            this.textBoxU2.Size = new System.Drawing.Size(100, 20);
            this.textBoxU2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Liczba 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Liczba 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Część rzeczywista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Część urojona";
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(27, 109);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 13;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonRowne
            // 
            this.buttonRowne.Enabled = false;
            this.buttonRowne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRowne.Location = new System.Drawing.Point(185, 229);
            this.buttonRowne.Name = "buttonRowne";
            this.buttonRowne.Size = new System.Drawing.Size(143, 27);
            this.buttonRowne.TabIndex = 14;
            this.buttonRowne.Text = "Liczba1 == Liczba2";
            this.buttonRowne.UseVisualStyleBackColor = true;
            this.buttonRowne.Click += new System.EventHandler(this.buttonRowne_Click);
            // 
            // buttonRozne
            // 
            this.buttonRozne.Enabled = false;
            this.buttonRozne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRozne.Location = new System.Drawing.Point(185, 258);
            this.buttonRozne.Name = "buttonRozne";
            this.buttonRozne.Size = new System.Drawing.Size(143, 27);
            this.buttonRozne.TabIndex = 15;
            this.buttonRozne.Text = "Liczba1 != Liczba2";
            this.buttonRozne.UseVisualStyleBackColor = true;
            this.buttonRozne.Click += new System.EventHandler(this.buttonRozne_Click);
            // 
            // buttonWiekszy
            // 
            this.buttonWiekszy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonWiekszy.Enabled = false;
            this.buttonWiekszy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonWiekszy.Location = new System.Drawing.Point(185, 287);
            this.buttonWiekszy.Name = "buttonWiekszy";
            this.buttonWiekszy.Size = new System.Drawing.Size(143, 27);
            this.buttonWiekszy.TabIndex = 16;
            this.buttonWiekszy.Text = "Liczba1 > Liczba2";
            this.buttonWiekszy.UseVisualStyleBackColor = true;
            this.buttonWiekszy.Click += new System.EventHandler(this.buttonWiekszy_Click);
            // 
            // buttonMniejszy
            // 
            this.buttonMniejszy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMniejszy.Enabled = false;
            this.buttonMniejszy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonMniejszy.Location = new System.Drawing.Point(185, 316);
            this.buttonMniejszy.Name = "buttonMniejszy";
            this.buttonMniejszy.Size = new System.Drawing.Size(143, 27);
            this.buttonMniejszy.TabIndex = 17;
            this.buttonMniejszy.Text = "Liczba1 < Liczba2";
            this.buttonMniejszy.UseVisualStyleBackColor = true;
            this.buttonMniejszy.Click += new System.EventHandler(this.buttonMniejszy_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Enabled = false;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonEquals.Location = new System.Drawing.Point(334, 229);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(231, 27);
            this.buttonEquals.TabIndex = 18;
            this.buttonEquals.Text = "Liczba1.Equals(Liczba2)";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonGetHashCode
            // 
            this.buttonGetHashCode.Enabled = false;
            this.buttonGetHashCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonGetHashCode.Location = new System.Drawing.Point(334, 262);
            this.buttonGetHashCode.Name = "buttonGetHashCode";
            this.buttonGetHashCode.Size = new System.Drawing.Size(231, 27);
            this.buttonGetHashCode.TabIndex = 19;
            this.buttonGetHashCode.Text = "Liczba1.GetHashCode()";
            this.buttonGetHashCode.UseVisualStyleBackColor = true;
            this.buttonGetHashCode.Click += new System.EventHandler(this.buttonGetHashCode_Click);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(108, 109);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(75, 23);
            this.buttonWyczysc.TabIndex = 20;
            this.buttonWyczysc.Text = "Wyczysc";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.buttonGetHashCode);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonMniejszy);
            this.Controls.Add(this.buttonWiekszy);
            this.Controls.Add(this.buttonRozne);
            this.Controls.Add(this.buttonRowne);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxU2);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.textBoxU1);
            this.Controls.Add(this.textBoxR1);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.buttonPodziel);
            this.Controls.Add(this.buttonPomnoz);
            this.Controls.Add(this.buttonOdejmij);
            this.Controls.Add(this.buttonDodaj);
            this.Name = "FormMain";
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonOdejmij;
        private System.Windows.Forms.Button buttonPomnoz;
        private System.Windows.Forms.Button buttonPodziel;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.TextBox textBoxR1;
        private System.Windows.Forms.TextBox textBoxU1;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.TextBox textBoxU2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonRowne;
        private System.Windows.Forms.Button buttonRozne;
        private System.Windows.Forms.Button buttonWiekszy;
        private System.Windows.Forms.Button buttonMniejszy;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonGetHashCode;
        private System.Windows.Forms.Button buttonWyczysc;
    }
}

