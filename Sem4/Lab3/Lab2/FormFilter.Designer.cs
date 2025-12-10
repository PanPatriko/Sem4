namespace Lab2
{
    partial class FormFilter
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
            this.maskedTextBoxDateTo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBirthPlace = new System.Windows.Forms.TextBox();
            this.textBoxFather = new System.Windows.Forms.TextBox();
            this.textBoxMother = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDateFrom = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonClearD = new System.Windows.Forms.Button();
            this.buttonClearM = new System.Windows.Forms.Button();
            this.buttonAddDad = new System.Windows.Forms.Button();
            this.buttonAddMom = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.listBoxPerson = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxFilter = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.checkBoxNameLenght = new System.Windows.Forms.CheckBox();
            this.numericUpDownName = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAge = new System.Windows.Forms.CheckBox();
            this.checkBoxSib = new System.Windows.Forms.CheckBox();
            this.checkBoxParBirthPlace = new System.Windows.Forms.CheckBox();
            this.checkBoxEvenDay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownName)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxDateTo
            // 
            this.maskedTextBoxDateTo.Location = new System.Drawing.Point(133, 226);
            this.maskedTextBoxDateTo.Mask = "00/00/0000";
            this.maskedTextBoxDateTo.Name = "maskedTextBoxDateTo";
            this.maskedTextBoxDateTo.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxDateTo.TabIndex = 33;
            this.maskedTextBoxDateTo.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Miejsce urodzenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Data urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ojciec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Matka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Imie";
            // 
            // textBoxBirthPlace
            // 
            this.textBoxBirthPlace.Location = new System.Drawing.Point(12, 252);
            this.textBoxBirthPlace.Name = "textBoxBirthPlace";
            this.textBoxBirthPlace.Size = new System.Drawing.Size(120, 20);
            this.textBoxBirthPlace.TabIndex = 26;
            // 
            // textBoxFather
            // 
            this.textBoxFather.Location = new System.Drawing.Point(12, 200);
            this.textBoxFather.Name = "textBoxFather";
            this.textBoxFather.ReadOnly = true;
            this.textBoxFather.Size = new System.Drawing.Size(120, 20);
            this.textBoxFather.TabIndex = 25;
            // 
            // textBoxMother
            // 
            this.textBoxMother.Location = new System.Drawing.Point(12, 174);
            this.textBoxMother.Name = "textBoxMother";
            this.textBoxMother.ReadOnly = true;
            this.textBoxMother.Size = new System.Drawing.Size(120, 20);
            this.textBoxMother.TabIndex = 24;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 148);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(120, 20);
            this.textBoxSurname.TabIndex = 23;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 122);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 22;
            // 
            // maskedTextBoxDateFrom
            // 
            this.maskedTextBoxDateFrom.Location = new System.Drawing.Point(30, 226);
            this.maskedTextBoxDateFrom.Mask = "00/00/0000";
            this.maskedTextBoxDateFrom.Name = "maskedTextBoxDateFrom";
            this.maskedTextBoxDateFrom.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBoxDateFrom.TabIndex = 34;
            this.maskedTextBoxDateFrom.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Od";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Do";
            // 
            // buttonClearD
            // 
            this.buttonClearD.Location = new System.Drawing.Point(236, 196);
            this.buttonClearD.Name = "buttonClearD";
            this.buttonClearD.Size = new System.Drawing.Size(49, 23);
            this.buttonClearD.TabIndex = 40;
            this.buttonClearD.Text = "Usuń";
            this.buttonClearD.UseVisualStyleBackColor = true;
            this.buttonClearD.Click += new System.EventHandler(this.buttonClearD_Click);
            // 
            // buttonClearM
            // 
            this.buttonClearM.Location = new System.Drawing.Point(236, 171);
            this.buttonClearM.Name = "buttonClearM";
            this.buttonClearM.Size = new System.Drawing.Size(49, 23);
            this.buttonClearM.TabIndex = 39;
            this.buttonClearM.Text = "Usuń";
            this.buttonClearM.UseVisualStyleBackColor = true;
            this.buttonClearM.Click += new System.EventHandler(this.buttonClearM_Click);
            // 
            // buttonAddDad
            // 
            this.buttonAddDad.Location = new System.Drawing.Point(181, 196);
            this.buttonAddDad.Name = "buttonAddDad";
            this.buttonAddDad.Size = new System.Drawing.Size(49, 23);
            this.buttonAddDad.TabIndex = 38;
            this.buttonAddDad.Text = "Dodaj";
            this.buttonAddDad.UseVisualStyleBackColor = true;
            this.buttonAddDad.Click += new System.EventHandler(this.buttonAddDad_Click);
            // 
            // buttonAddMom
            // 
            this.buttonAddMom.Location = new System.Drawing.Point(181, 171);
            this.buttonAddMom.Name = "buttonAddMom";
            this.buttonAddMom.Size = new System.Drawing.Size(49, 23);
            this.buttonAddMom.TabIndex = 37;
            this.buttonAddMom.Text = "Dodaj";
            this.buttonAddMom.UseVisualStyleBackColor = true;
            this.buttonAddMom.Click += new System.EventHandler(this.buttonAddMom_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 42);
            this.label9.TabIndex = 41;
            this.label9.Text = "Filtry zaawansowane";
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFilter.Location = new System.Drawing.Point(133, 310);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(102, 60);
            this.buttonFilter.TabIndex = 42;
            this.buttonFilter.Text = "Filtruj";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // listBoxPerson
            // 
            this.listBoxPerson.FormattingEnabled = true;
            this.listBoxPerson.Location = new System.Drawing.Point(12, 21);
            this.listBoxPerson.Name = "listBoxPerson";
            this.listBoxPerson.Size = new System.Drawing.Size(120, 95);
            this.listBoxPerson.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Osoby przefiltrowane";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Osoby";
            // 
            // listBoxFilter
            // 
            this.listBoxFilter.FormattingEnabled = true;
            this.listBoxFilter.Location = new System.Drawing.Point(139, 21);
            this.listBoxFilter.Name = "listBoxFilter";
            this.listBoxFilter.Size = new System.Drawing.Size(120, 95);
            this.listBoxFilter.TabIndex = 45;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(241, 310);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 60);
            this.buttonSave.TabIndex = 48;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(30, 278);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 23);
            this.buttonClear.TabIndex = 49;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDetails
            // 
            this.buttonDetails.Location = new System.Drawing.Point(170, 119);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(90, 23);
            this.buttonDetails.TabIndex = 50;
            this.buttonDetails.Text = "Szczegóły";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // checkBoxNameLenght
            // 
            this.checkBoxNameLenght.AutoSize = true;
            this.checkBoxNameLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxNameLenght.Location = new System.Drawing.Point(273, 54);
            this.checkBoxNameLenght.Name = "checkBoxNameLenght";
            this.checkBoxNameLenght.Size = new System.Drawing.Size(307, 20);
            this.checkBoxNameLenght.TabIndex = 51;
            this.checkBoxNameLenght.Text = "Osoba mająca imie dłuższe niż                znaków";
            this.checkBoxNameLenght.UseVisualStyleBackColor = true;
            // 
            // numericUpDownName
            // 
            this.numericUpDownName.Location = new System.Drawing.Point(485, 55);
            this.numericUpDownName.Name = "numericUpDownName";
            this.numericUpDownName.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownName.TabIndex = 52;
            // 
            // checkBoxAge
            // 
            this.checkBoxAge.AutoSize = true;
            this.checkBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxAge.Location = new System.Drawing.Point(273, 80);
            this.checkBoxAge.Name = "checkBoxAge";
            this.checkBoxAge.Size = new System.Drawing.Size(140, 20);
            this.checkBoxAge.TabIndex = 53;
            this.checkBoxAge.Text = "Osoba pełnoletnia";
            this.checkBoxAge.UseVisualStyleBackColor = true;
            // 
            // checkBoxSib
            // 
            this.checkBoxSib.AutoSize = true;
            this.checkBoxSib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxSib.Location = new System.Drawing.Point(273, 106);
            this.checkBoxSib.Name = "checkBoxSib";
            this.checkBoxSib.Size = new System.Drawing.Size(187, 20);
            this.checkBoxSib.TabIndex = 54;
            this.checkBoxSib.Text = "Osoba mająca rodzeństwo";
            this.checkBoxSib.UseVisualStyleBackColor = true;
            // 
            // checkBoxParBirthPlace
            // 
            this.checkBoxParBirthPlace.AutoSize = true;
            this.checkBoxParBirthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxParBirthPlace.Location = new System.Drawing.Point(273, 132);
            this.checkBoxParBirthPlace.Name = "checkBoxParBirthPlace";
            this.checkBoxParBirthPlace.Size = new System.Drawing.Size(352, 20);
            this.checkBoxParBirthPlace.TabIndex = 55;
            this.checkBoxParBirthPlace.Text = "Osoba której rodzice urodzili sie w tym samym miejscu ";
            this.checkBoxParBirthPlace.UseVisualStyleBackColor = true;
            // 
            // checkBoxEvenDay
            // 
            this.checkBoxEvenDay.AutoSize = true;
            this.checkBoxEvenDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxEvenDay.Location = new System.Drawing.Point(291, 158);
            this.checkBoxEvenDay.Name = "checkBoxEvenDay";
            this.checkBoxEvenDay.Size = new System.Drawing.Size(227, 20);
            this.checkBoxEvenDay.TabIndex = 56;
            this.checkBoxEvenDay.Text = "Osoba urodzona w parzysty dzień";
            this.checkBoxEvenDay.UseVisualStyleBackColor = true;
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.checkBoxEvenDay);
            this.Controls.Add(this.checkBoxParBirthPlace);
            this.Controls.Add(this.checkBoxSib);
            this.Controls.Add(this.checkBoxAge);
            this.Controls.Add(this.numericUpDownName);
            this.Controls.Add(this.checkBoxNameLenght);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBoxFilter);
            this.Controls.Add(this.listBoxPerson);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonClearD);
            this.Controls.Add(this.buttonClearM);
            this.Controls.Add(this.buttonAddDad);
            this.Controls.Add(this.buttonAddMom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBoxDateFrom);
            this.Controls.Add(this.maskedTextBoxDateTo);
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
            this.Name = "FormFilter";
            this.Text = "Filtry";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBirthPlace;
        private System.Windows.Forms.TextBox textBoxFather;
        private System.Windows.Forms.TextBox textBoxMother;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonClearD;
        private System.Windows.Forms.Button buttonClearM;
        private System.Windows.Forms.Button buttonAddDad;
        private System.Windows.Forms.Button buttonAddMom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ListBox listBoxPerson;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBoxFilter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.CheckBox checkBoxNameLenght;
        private System.Windows.Forms.NumericUpDown numericUpDownName;
        private System.Windows.Forms.CheckBox checkBoxAge;
        private System.Windows.Forms.CheckBox checkBoxSib;
        private System.Windows.Forms.CheckBox checkBoxParBirthPlace;
        private System.Windows.Forms.CheckBox checkBoxEvenDay;
    }
}