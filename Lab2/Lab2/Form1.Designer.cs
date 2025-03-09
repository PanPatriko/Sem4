namespace Lab2
{
    partial class Form1
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
            this.listBoxPerson = new System.Windows.Forms.ListBox();
            this.listBoxChildren = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxMother = new System.Windows.Forms.TextBox();
            this.textBoxFather = new System.Windows.Forms.TextBox();
            this.textBoxBirthPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddMom = new System.Windows.Forms.Button();
            this.buttonAddDad = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.buttonDelPerson = new System.Windows.Forms.Button();
            this.buttonEditPerson = new System.Windows.Forms.Button();
            this.maskedTextBoxBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.buttonClearM = new System.Windows.Forms.Button();
            this.buttonClearD = new System.Windows.Forms.Button();
            this.listBoxFilter = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPerson
            // 
            this.listBoxPerson.FormattingEnabled = true;
            this.listBoxPerson.Location = new System.Drawing.Point(8, 43);
            this.listBoxPerson.Name = "listBoxPerson";
            this.listBoxPerson.Size = new System.Drawing.Size(120, 95);
            this.listBoxPerson.TabIndex = 0;
            this.listBoxPerson.SelectedIndexChanged += new System.EventHandler(this.listBoxPerson_SelectedIndexChanged);
            this.listBoxPerson.Enter += new System.EventHandler(this.listBoxPerson_Enter);
            // 
            // listBoxChildren
            // 
            this.listBoxChildren.FormattingEnabled = true;
            this.listBoxChildren.Location = new System.Drawing.Point(263, 43);
            this.listBoxChildren.Name = "listBoxChildren";
            this.listBoxChildren.Size = new System.Drawing.Size(120, 95);
            this.listBoxChildren.TabIndex = 1;
            this.listBoxChildren.Enter += new System.EventHandler(this.listBoxChildren_Enter);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(8, 144);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(8, 170);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(120, 20);
            this.textBoxSurname.TabIndex = 3;
            // 
            // textBoxMother
            // 
            this.textBoxMother.Location = new System.Drawing.Point(8, 196);
            this.textBoxMother.Name = "textBoxMother";
            this.textBoxMother.ReadOnly = true;
            this.textBoxMother.Size = new System.Drawing.Size(120, 20);
            this.textBoxMother.TabIndex = 4;
            // 
            // textBoxFather
            // 
            this.textBoxFather.Location = new System.Drawing.Point(8, 222);
            this.textBoxFather.Name = "textBoxFather";
            this.textBoxFather.ReadOnly = true;
            this.textBoxFather.Size = new System.Drawing.Size(120, 20);
            this.textBoxFather.TabIndex = 5;
            // 
            // textBoxBirthPlace
            // 
            this.textBoxBirthPlace.Location = new System.Drawing.Point(8, 274);
            this.textBoxBirthPlace.Name = "textBoxBirthPlace";
            this.textBoxBirthPlace.Size = new System.Drawing.Size(120, 20);
            this.textBoxBirthPlace.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Matka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ojciec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rok urodzenia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Miejsce urodzenia";
            // 
            // buttonAddMom
            // 
            this.buttonAddMom.Location = new System.Drawing.Point(177, 194);
            this.buttonAddMom.Name = "buttonAddMom";
            this.buttonAddMom.Size = new System.Drawing.Size(49, 23);
            this.buttonAddMom.TabIndex = 14;
            this.buttonAddMom.Text = "Dodaj";
            this.buttonAddMom.UseVisualStyleBackColor = true;
            this.buttonAddMom.Click += new System.EventHandler(this.buttonAddMom_Click);
            // 
            // buttonAddDad
            // 
            this.buttonAddDad.Location = new System.Drawing.Point(177, 219);
            this.buttonAddDad.Name = "buttonAddDad";
            this.buttonAddDad.Size = new System.Drawing.Size(49, 23);
            this.buttonAddDad.TabIndex = 15;
            this.buttonAddDad.Text = "Dodaj";
            this.buttonAddDad.UseVisualStyleBackColor = true;
            this.buttonAddDad.Click += new System.EventHandler(this.buttonAddDad_Click);
            // 
            // buttonDetails
            // 
            this.buttonDetails.Location = new System.Drawing.Point(290, 147);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(90, 23);
            this.buttonDetails.TabIndex = 16;
            this.buttonDetails.Text = "Szczegóły";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(290, 176);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(90, 23);
            this.buttonFilter.TabIndex = 17;
            this.buttonFilter.Text = "Filtruj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(290, 205);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(90, 24);
            this.buttonAddPerson.TabIndex = 18;
            this.buttonAddPerson.Text = "Dodaj osobe";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // buttonDelPerson
            // 
            this.buttonDelPerson.Location = new System.Drawing.Point(290, 232);
            this.buttonDelPerson.Name = "buttonDelPerson";
            this.buttonDelPerson.Size = new System.Drawing.Size(90, 23);
            this.buttonDelPerson.TabIndex = 19;
            this.buttonDelPerson.Text = "Usuń osobe";
            this.buttonDelPerson.UseVisualStyleBackColor = true;
            this.buttonDelPerson.Click += new System.EventHandler(this.buttonDelPerson_Click);
            // 
            // buttonEditPerson
            // 
            this.buttonEditPerson.Location = new System.Drawing.Point(290, 261);
            this.buttonEditPerson.Name = "buttonEditPerson";
            this.buttonEditPerson.Size = new System.Drawing.Size(90, 23);
            this.buttonEditPerson.TabIndex = 20;
            this.buttonEditPerson.Text = "Edytuj osobe";
            this.buttonEditPerson.UseVisualStyleBackColor = true;
            this.buttonEditPerson.Click += new System.EventHandler(this.buttonEditPerson_Click);
            // 
            // maskedTextBoxBirthDate
            // 
            this.maskedTextBoxBirthDate.Location = new System.Drawing.Point(8, 248);
            this.maskedTextBoxBirthDate.Mask = "00/00/0000";
            this.maskedTextBoxBirthDate.Name = "maskedTextBoxBirthDate";
            this.maskedTextBoxBirthDate.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBoxBirthDate.TabIndex = 21;
            this.maskedTextBoxBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // buttonClearM
            // 
            this.buttonClearM.Location = new System.Drawing.Point(232, 194);
            this.buttonClearM.Name = "buttonClearM";
            this.buttonClearM.Size = new System.Drawing.Size(49, 23);
            this.buttonClearM.TabIndex = 22;
            this.buttonClearM.Text = "Usuń";
            this.buttonClearM.UseVisualStyleBackColor = true;
            this.buttonClearM.Click += new System.EventHandler(this.buttonClearM_Click);
            // 
            // buttonClearD
            // 
            this.buttonClearD.Location = new System.Drawing.Point(232, 219);
            this.buttonClearD.Name = "buttonClearD";
            this.buttonClearD.Size = new System.Drawing.Size(49, 23);
            this.buttonClearD.TabIndex = 23;
            this.buttonClearD.Text = "Usuń";
            this.buttonClearD.UseVisualStyleBackColor = true;
            this.buttonClearD.Click += new System.EventHandler(this.buttonClearD_Click);
            // 
            // listBoxFilter
            // 
            this.listBoxFilter.FormattingEnabled = true;
            this.listBoxFilter.Location = new System.Drawing.Point(137, 43);
            this.listBoxFilter.Name = "listBoxFilter";
            this.listBoxFilter.Size = new System.Drawing.Size(120, 95);
            this.listBoxFilter.TabIndex = 24;
            this.listBoxFilter.SelectedIndexChanged += new System.EventHandler(this.listBoxFilter_SelectedIndexChanged);
            this.listBoxFilter.Enter += new System.EventHandler(this.listBoxFilter_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Osoby";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Dzieci";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Osoby przefiltrowane";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(22, 300);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 23);
            this.buttonClear.TabIndex = 28;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 344);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxFilter);
            this.Controls.Add(this.buttonClearD);
            this.Controls.Add(this.buttonClearM);
            this.Controls.Add(this.maskedTextBoxBirthDate);
            this.Controls.Add(this.buttonEditPerson);
            this.Controls.Add(this.buttonDelPerson);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.buttonAddDad);
            this.Controls.Add(this.buttonAddMom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBirthPlace);
            this.Controls.Add(this.textBoxFather);
            this.Controls.Add(this.textBoxMother);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxChildren);
            this.Controls.Add(this.listBoxPerson);
            this.Name = "Form1";
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPerson;
        private System.Windows.Forms.ListBox listBoxChildren;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxMother;
        private System.Windows.Forms.TextBox textBoxFather;
        private System.Windows.Forms.TextBox textBoxBirthPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddMom;
        private System.Windows.Forms.Button buttonAddDad;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Button buttonDelPerson;
        private System.Windows.Forms.Button buttonEditPerson;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBirthDate;
        private System.Windows.Forms.Button buttonClearM;
        private System.Windows.Forms.Button buttonClearD;
        private System.Windows.Forms.ListBox listBoxFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonClear;
    }
}

