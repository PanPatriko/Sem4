namespace Lab11
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPlec = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonUN = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxCars = new System.Windows.Forms.CheckBox();
            this.checkBoxFilms = new System.Windows.Forms.CheckBox();
            this.checkBoxFB = new System.Windows.Forms.CheckBox();
            this.checkBoxBooks = new System.Windows.Forms.CheckBox();
            this.checkBoxComp = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(170, 107);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(69, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 20;
            // 
            // labelPlec
            // 
            this.labelPlec.AutoSize = true;
            this.labelPlec.Location = new System.Drawing.Point(7, 41);
            this.labelPlec.Name = "labelPlec";
            this.labelPlec.Size = new System.Drawing.Size(30, 13);
            this.labelPlec.TabIndex = 18;
            this.labelPlec.Text = "Płeć";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 13);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Imię";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(276, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 95);
            this.listBox1.TabIndex = 14;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(53, 39);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(78, 17);
            this.radioButtonM.TabIndex = 25;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Mezczyzna";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(133, 39);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(61, 17);
            this.radioButtonF.TabIndex = 26;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "Kobieta";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonUN
            // 
            this.radioButtonUN.AutoSize = true;
            this.radioButtonUN.Location = new System.Drawing.Point(200, 39);
            this.radioButtonUN.Name = "radioButtonUN";
            this.radioButtonUN.Size = new System.Drawing.Size(70, 17);
            this.radioButtonUN.TabIndex = 27;
            this.radioButtonUN.TabStop = true;
            this.radioButtonUN.Text = "Nieznana";
            this.radioButtonUN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Stan Cywilny";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nieznany",
            "Panna/Kawaler",
            "Mężatka/Żonaty",
            "Wdowa/Wdowiec",
            "Rozwódka/Rozwodnik"});
            this.comboBox1.Location = new System.Drawing.Point(80, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Hobby";
            // 
            // checkBoxCars
            // 
            this.checkBoxCars.AutoSize = true;
            this.checkBoxCars.Location = new System.Drawing.Point(53, 90);
            this.checkBoxCars.Name = "checkBoxCars";
            this.checkBoxCars.Size = new System.Drawing.Size(82, 17);
            this.checkBoxCars.TabIndex = 34;
            this.checkBoxCars.Text = "Samochody";
            this.checkBoxCars.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilms
            // 
            this.checkBoxFilms.AutoSize = true;
            this.checkBoxFilms.Location = new System.Drawing.Point(53, 113);
            this.checkBoxFilms.Name = "checkBoxFilms";
            this.checkBoxFilms.Size = new System.Drawing.Size(49, 17);
            this.checkBoxFilms.TabIndex = 35;
            this.checkBoxFilms.Text = "Filmy";
            this.checkBoxFilms.UseVisualStyleBackColor = true;
            // 
            // checkBoxFB
            // 
            this.checkBoxFB.AutoSize = true;
            this.checkBoxFB.Location = new System.Drawing.Point(53, 136);
            this.checkBoxFB.Name = "checkBoxFB";
            this.checkBoxFB.Size = new System.Drawing.Size(85, 17);
            this.checkBoxFB.TabIndex = 36;
            this.checkBoxFB.Text = "Piłka Nożna";
            this.checkBoxFB.UseVisualStyleBackColor = true;
            // 
            // checkBoxBooks
            // 
            this.checkBoxBooks.AutoSize = true;
            this.checkBoxBooks.Location = new System.Drawing.Point(53, 159);
            this.checkBoxBooks.Name = "checkBoxBooks";
            this.checkBoxBooks.Size = new System.Drawing.Size(59, 17);
            this.checkBoxBooks.TabIndex = 37;
            this.checkBoxBooks.Text = "Książki";
            this.checkBoxBooks.UseVisualStyleBackColor = true;
            // 
            // checkBoxComp
            // 
            this.checkBoxComp.AutoSize = true;
            this.checkBoxComp.Location = new System.Drawing.Point(53, 182);
            this.checkBoxComp.Name = "checkBoxComp";
            this.checkBoxComp.Size = new System.Drawing.Size(76, 17);
            this.checkBoxComp.TabIndex = 38;
            this.checkBoxComp.Text = "Komputery";
            this.checkBoxComp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 39;
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(276, 113);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 23);
            this.buttonView.TabIndex = 40;
            this.buttonView.Text = "Wyświetl";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(170, 136);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 41;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(170, 165);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 42;
            this.buttonDel.Text = "Usuń";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 395);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxComp);
            this.Controls.Add(this.checkBoxBooks);
            this.Controls.Add(this.checkBoxFB);
            this.Controls.Add(this.checkBoxFilms);
            this.Controls.Add(this.checkBoxCars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonUN);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPlec);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Lab11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPlec;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonUN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxCars;
        private System.Windows.Forms.CheckBox checkBoxFilms;
        private System.Windows.Forms.CheckBox checkBoxFB;
        private System.Windows.Forms.CheckBox checkBoxBooks;
        private System.Windows.Forms.CheckBox checkBoxComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
    }
}

