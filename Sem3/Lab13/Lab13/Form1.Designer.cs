namespace Lab13
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
            this.buttonCapitalizeWords = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCountVowels = new System.Windows.Forms.Button();
            this.buttonCountWords = new System.Windows.Forms.Button();
            this.buttonRemoveVowels = new System.Windows.Forms.Button();
            this.buttonReverseLettersInWords = new System.Windows.Forms.Button();
            this.buttonContainsAlaMaKota = new System.Windows.Forms.Button();
            this.buttonRemoveNonLetters = new System.Windows.Forms.Button();
            this.buttonRandomizeMiddleLetters = new System.Windows.Forms.Button();
            this.buttonConvertToMorse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Wpisz tekst";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // buttonCapitalizeWords
            // 
            this.buttonCapitalizeWords.Location = new System.Drawing.Point(118, 12);
            this.buttonCapitalizeWords.Name = "buttonCapitalizeWords";
            this.buttonCapitalizeWords.Size = new System.Drawing.Size(95, 23);
            this.buttonCapitalizeWords.TabIndex = 1;
            this.buttonCapitalizeWords.Text = "CapitalizeWords";
            this.buttonCapitalizeWords.UseVisualStyleBackColor = true;
            this.buttonCapitalizeWords.Click += new System.EventHandler(this.buttonCapitalizeWords_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // buttonCountVowels
            // 
            this.buttonCountVowels.Location = new System.Drawing.Point(118, 41);
            this.buttonCountVowels.Name = "buttonCountVowels";
            this.buttonCountVowels.Size = new System.Drawing.Size(95, 23);
            this.buttonCountVowels.TabIndex = 3;
            this.buttonCountVowels.Text = "CountVowels";
            this.buttonCountVowels.UseVisualStyleBackColor = true;
            this.buttonCountVowels.Click += new System.EventHandler(this.buttonCountVowels_Click);
            // 
            // buttonCountWords
            // 
            this.buttonCountWords.Location = new System.Drawing.Point(118, 70);
            this.buttonCountWords.Name = "buttonCountWords";
            this.buttonCountWords.Size = new System.Drawing.Size(95, 23);
            this.buttonCountWords.TabIndex = 4;
            this.buttonCountWords.Text = "CountWords";
            this.buttonCountWords.UseVisualStyleBackColor = true;
            this.buttonCountWords.Click += new System.EventHandler(this.buttonCountWords_Click);
            // 
            // buttonRemoveVowels
            // 
            this.buttonRemoveVowels.Location = new System.Drawing.Point(118, 99);
            this.buttonRemoveVowels.Name = "buttonRemoveVowels";
            this.buttonRemoveVowels.Size = new System.Drawing.Size(95, 23);
            this.buttonRemoveVowels.TabIndex = 5;
            this.buttonRemoveVowels.Text = "RemoveVowels";
            this.buttonRemoveVowels.UseVisualStyleBackColor = true;
            this.buttonRemoveVowels.Click += new System.EventHandler(this.buttonRemoveVowels_Click);
            // 
            // buttonReverseLettersInWords
            // 
            this.buttonReverseLettersInWords.Location = new System.Drawing.Point(118, 244);
            this.buttonReverseLettersInWords.Name = "buttonReverseLettersInWords";
            this.buttonReverseLettersInWords.Size = new System.Drawing.Size(142, 23);
            this.buttonReverseLettersInWords.TabIndex = 6;
            this.buttonReverseLettersInWords.Text = "ReverseLettersInWords";
            this.buttonReverseLettersInWords.UseVisualStyleBackColor = true;
            this.buttonReverseLettersInWords.Click += new System.EventHandler(this.buttonReverseLettersInWords_Click);
            // 
            // buttonContainsAlaMaKota
            // 
            this.buttonContainsAlaMaKota.Location = new System.Drawing.Point(118, 157);
            this.buttonContainsAlaMaKota.Name = "buttonContainsAlaMaKota";
            this.buttonContainsAlaMaKota.Size = new System.Drawing.Size(142, 23);
            this.buttonContainsAlaMaKota.TabIndex = 7;
            this.buttonContainsAlaMaKota.Text = "ContainsAlaMaKota";
            this.buttonContainsAlaMaKota.UseVisualStyleBackColor = true;
            this.buttonContainsAlaMaKota.Click += new System.EventHandler(this.buttonContainsAlaMaKota_Click);
            // 
            // buttonRemoveNonLetters
            // 
            this.buttonRemoveNonLetters.Location = new System.Drawing.Point(118, 186);
            this.buttonRemoveNonLetters.Name = "buttonRemoveNonLetters";
            this.buttonRemoveNonLetters.Size = new System.Drawing.Size(142, 23);
            this.buttonRemoveNonLetters.TabIndex = 8;
            this.buttonRemoveNonLetters.Text = " RemoveNonLetters";
            this.buttonRemoveNonLetters.UseVisualStyleBackColor = true;
            this.buttonRemoveNonLetters.Click += new System.EventHandler(this.buttonRemoveNonLetters_Click);
            // 
            // buttonRandomizeMiddleLetters
            // 
            this.buttonRandomizeMiddleLetters.Location = new System.Drawing.Point(118, 215);
            this.buttonRandomizeMiddleLetters.Name = "buttonRandomizeMiddleLetters";
            this.buttonRandomizeMiddleLetters.Size = new System.Drawing.Size(142, 23);
            this.buttonRandomizeMiddleLetters.TabIndex = 9;
            this.buttonRandomizeMiddleLetters.Text = "RandomizeMiddleLetters";
            this.buttonRandomizeMiddleLetters.UseVisualStyleBackColor = true;
            this.buttonRandomizeMiddleLetters.Click += new System.EventHandler(this.buttonRandomizeMiddleLetters_Click);
            // 
            // buttonConvertToMorse
            // 
            this.buttonConvertToMorse.Location = new System.Drawing.Point(118, 128);
            this.buttonConvertToMorse.Name = "buttonConvertToMorse";
            this.buttonConvertToMorse.Size = new System.Drawing.Size(95, 23);
            this.buttonConvertToMorse.TabIndex = 10;
            this.buttonConvertToMorse.Text = "ConvertToMorse";
            this.buttonConvertToMorse.UseVisualStyleBackColor = true;
            this.buttonConvertToMorse.Click += new System.EventHandler(this.buttonConvertToMorse_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConvertToMorse);
            this.Controls.Add(this.buttonRandomizeMiddleLetters);
            this.Controls.Add(this.buttonRemoveNonLetters);
            this.Controls.Add(this.buttonContainsAlaMaKota);
            this.Controls.Add(this.buttonReverseLettersInWords);
            this.Controls.Add(this.buttonRemoveVowels);
            this.Controls.Add(this.buttonCountWords);
            this.Controls.Add(this.buttonCountVowels);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonCapitalizeWords);
            this.Controls.Add(this.textBox1);
            this.Name = "FormMain";
            this.Text = "Lab13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCapitalizeWords;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCountVowels;
        private System.Windows.Forms.Button buttonCountWords;
        private System.Windows.Forms.Button buttonRemoveVowels;
        private System.Windows.Forms.Button buttonReverseLettersInWords;
        private System.Windows.Forms.Button buttonContainsAlaMaKota;
        private System.Windows.Forms.Button buttonRemoveNonLetters;
        private System.Windows.Forms.Button buttonRandomizeMiddleLetters;
        private System.Windows.Forms.Button buttonConvertToMorse;
    }
}

