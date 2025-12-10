namespace Lab5
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
            this.textBoxSciezka = new System.Windows.Forms.TextBox();
            this.checkBoxKompresja = new System.Windows.Forms.CheckBox();
            this.checkBoxSzyfr = new System.Windows.Forms.CheckBox();
            this.buttonPrzeg = new System.Windows.Forms.Button();
            this.buttonOtw = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.textBoxNotepad = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxSciezka
            // 
            this.textBoxSciezka.Location = new System.Drawing.Point(12, 12);
            this.textBoxSciezka.Name = "textBoxSciezka";
            this.textBoxSciezka.Size = new System.Drawing.Size(314, 20);
            this.textBoxSciezka.TabIndex = 0;
            // 
            // checkBoxKompresja
            // 
            this.checkBoxKompresja.AutoSize = true;
            this.checkBoxKompresja.Location = new System.Drawing.Point(44, 38);
            this.checkBoxKompresja.Name = "checkBoxKompresja";
            this.checkBoxKompresja.Size = new System.Drawing.Size(75, 17);
            this.checkBoxKompresja.TabIndex = 1;
            this.checkBoxKompresja.Text = "Kompresja";
            this.checkBoxKompresja.UseVisualStyleBackColor = true;
            // 
            // checkBoxSzyfr
            // 
            this.checkBoxSzyfr.AutoSize = true;
            this.checkBoxSzyfr.Location = new System.Drawing.Point(183, 38);
            this.checkBoxSzyfr.Name = "checkBoxSzyfr";
            this.checkBoxSzyfr.Size = new System.Drawing.Size(83, 17);
            this.checkBoxSzyfr.TabIndex = 2;
            this.checkBoxSzyfr.Text = "Szyfrowanie";
            this.checkBoxSzyfr.UseVisualStyleBackColor = true;
            // 
            // buttonPrzeg
            // 
            this.buttonPrzeg.Location = new System.Drawing.Point(353, 12);
            this.buttonPrzeg.Name = "buttonPrzeg";
            this.buttonPrzeg.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzeg.TabIndex = 3;
            this.buttonPrzeg.Text = "Przegladaj";
            this.buttonPrzeg.UseVisualStyleBackColor = true;
            this.buttonPrzeg.Click += new System.EventHandler(this.buttonPrzeg_Click);
            // 
            // buttonOtw
            // 
            this.buttonOtw.Location = new System.Drawing.Point(434, 12);
            this.buttonOtw.Name = "buttonOtw";
            this.buttonOtw.Size = new System.Drawing.Size(75, 23);
            this.buttonOtw.TabIndex = 4;
            this.buttonOtw.Text = "Otwórz";
            this.buttonOtw.UseVisualStyleBackColor = true;
            this.buttonOtw.Click += new System.EventHandler(this.buttonOtw_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(515, 12);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 5;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // textBoxNotepad
            // 
            this.textBoxNotepad.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNotepad.Location = new System.Drawing.Point(12, 73);
            this.textBoxNotepad.Multiline = true;
            this.textBoxNotepad.Name = "textBoxNotepad";
            this.textBoxNotepad.Size = new System.Drawing.Size(710, 427);
            this.textBoxNotepad.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.textBoxNotepad);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.buttonOtw);
            this.Controls.Add(this.buttonPrzeg);
            this.Controls.Add(this.checkBoxSzyfr);
            this.Controls.Add(this.checkBoxKompresja);
            this.Controls.Add(this.textBoxSciezka);
            this.Name = "FormMain";
            this.Text = "Lab6 Super Notepad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSciezka;
        private System.Windows.Forms.CheckBox checkBoxKompresja;
        private System.Windows.Forms.CheckBox checkBoxSzyfr;
        private System.Windows.Forms.Button buttonPrzeg;
        private System.Windows.Forms.Button buttonOtw;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.TextBox textBoxNotepad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

