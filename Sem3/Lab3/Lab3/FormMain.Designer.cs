namespace Lab3
{
    partial class FormMain
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
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.textBoxWyszukaj = new System.Windows.Forms.TextBox();
            this.radioButtonPl = new System.Windows.Forms.RadioButton();
            this.radioButtonAng = new System.Windows.Forms.RadioButton();
            this.labelSlowo = new System.Windows.Forms.Label();
            this.labelHistoria = new System.Windows.Forms.Label();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.Location = new System.Drawing.Point(271, 171);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(148, 23);
            this.buttonWyszukaj.TabIndex = 1;
            this.buttonWyszukaj.Text = "Szukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = true;
            this.buttonWyszukaj.Click += new System.EventHandler(this.buttonWyszukaj_Click);
            // 
            // textBoxWyszukaj
            // 
            this.textBoxWyszukaj.Location = new System.Drawing.Point(271, 200);
            this.textBoxWyszukaj.Multiline = true;
            this.textBoxWyszukaj.Name = "textBoxWyszukaj";
            this.textBoxWyszukaj.Size = new System.Drawing.Size(148, 26);
            this.textBoxWyszukaj.TabIndex = 0;
            this.textBoxWyszukaj.TextChanged += new System.EventHandler(this.textBoxWyszukaj_TextChanged);
            // 
            // radioButtonPl
            // 
            this.radioButtonPl.AutoSize = true;
            this.radioButtonPl.Location = new System.Drawing.Point(271, 255);
            this.radioButtonPl.Name = "radioButtonPl";
            this.radioButtonPl.Size = new System.Drawing.Size(90, 17);
            this.radioButtonPl.TabIndex = 3;
            this.radioButtonPl.TabStop = true;
            this.radioButtonPl.Text = "Slowo polskie";
            this.radioButtonPl.UseVisualStyleBackColor = true;
            // 
            // radioButtonAng
            // 
            this.radioButtonAng.AutoSize = true;
            this.radioButtonAng.Location = new System.Drawing.Point(271, 232);
            this.radioButtonAng.Name = "radioButtonAng";
            this.radioButtonAng.Size = new System.Drawing.Size(104, 17);
            this.radioButtonAng.TabIndex = 4;
            this.radioButtonAng.TabStop = true;
            this.radioButtonAng.Text = "Slowo angielskie";
            this.radioButtonAng.UseVisualStyleBackColor = true;
            // 
            // labelSlowo
            // 
            this.labelSlowo.AutoSize = true;
            this.labelSlowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSlowo.Location = new System.Drawing.Point(423, 106);
            this.labelSlowo.Name = "labelSlowo";
            this.labelSlowo.Size = new System.Drawing.Size(25, 24);
            this.labelSlowo.TabIndex = 6;
            this.labelSlowo.Text = "...";
            // 
            // labelHistoria
            // 
            this.labelHistoria.AutoSize = true;
            this.labelHistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHistoria.Location = new System.Drawing.Point(21, 38);
            this.labelHistoria.Name = "labelHistoria";
            this.labelHistoria.Size = new System.Drawing.Size(56, 17);
            this.labelHistoria.TabIndex = 7;
            this.labelHistoria.Text = "Historia";
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(12, 12);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(75, 23);
            this.buttonWyczysc.TabIndex = 8;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(271, 278);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(130, 23);
            this.buttonDodaj.TabIndex = 9;
            this.buttonDodaj.Text = "Dodaj swoje słowo";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(445, 171);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 10;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 368);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.labelHistoria);
            this.Controls.Add(this.labelSlowo);
            this.Controls.Add(this.radioButtonAng);
            this.Controls.Add(this.radioButtonPl);
            this.Controls.Add(this.buttonWyszukaj);
            this.Controls.Add(this.textBoxWyszukaj);
            this.Name = "FormMain";
            this.Text = "Lab3";
            this.Load += new System.EventHandler(this.FormLab3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.TextBox textBoxWyszukaj;
        private System.Windows.Forms.RadioButton radioButtonPl;
        private System.Windows.Forms.RadioButton radioButtonAng;
        private System.Windows.Forms.Label labelSlowo;
        private System.Windows.Forms.Label labelHistoria;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonTest;
    }
}

