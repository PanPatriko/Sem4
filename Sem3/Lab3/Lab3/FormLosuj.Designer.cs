namespace Lab3
{
    partial class FormLosuj
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
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.labelLosowanie = new System.Windows.Forms.Label();
            this.textBoxLosowanie = new System.Windows.Forms.TextBox();
            this.buttonSpr = new System.Windows.Forms.Button();
            this.buttonCofnij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(12, 120);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 0;
            this.buttonLosuj.Text = "Losuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click_1);
            // 
            // labelLosowanie
            // 
            this.labelLosowanie.AutoSize = true;
            this.labelLosowanie.Location = new System.Drawing.Point(12, 37);
            this.labelLosowanie.Name = "labelLosowanie";
            this.labelLosowanie.Size = new System.Drawing.Size(16, 13);
            this.labelLosowanie.TabIndex = 1;
            this.labelLosowanie.Text = "...";
            // 
            // textBoxLosowanie
            // 
            this.textBoxLosowanie.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLosowanie.Enabled = false;
            this.textBoxLosowanie.Location = new System.Drawing.Point(15, 64);
            this.textBoxLosowanie.Name = "textBoxLosowanie";
            this.textBoxLosowanie.Size = new System.Drawing.Size(100, 20);
            this.textBoxLosowanie.TabIndex = 2;
            this.textBoxLosowanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSpr
            // 
            this.buttonSpr.Enabled = false;
            this.buttonSpr.Location = new System.Drawing.Point(93, 120);
            this.buttonSpr.Name = "buttonSpr";
            this.buttonSpr.Size = new System.Drawing.Size(75, 23);
            this.buttonSpr.TabIndex = 3;
            this.buttonSpr.Text = "Sprawdź";
            this.buttonSpr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSpr.UseVisualStyleBackColor = true;
            this.buttonSpr.Click += new System.EventHandler(this.buttonSpr_Click);
            // 
            // buttonCofnij
            // 
            this.buttonCofnij.Enabled = false;
            this.buttonCofnij.Location = new System.Drawing.Point(152, 61);
            this.buttonCofnij.Name = "buttonCofnij";
            this.buttonCofnij.Size = new System.Drawing.Size(75, 23);
            this.buttonCofnij.TabIndex = 4;
            this.buttonCofnij.Text = "Cofnij";
            this.buttonCofnij.UseVisualStyleBackColor = true;
            this.buttonCofnij.Click += new System.EventHandler(this.buttonCofnij_Click);
            // 
            // FormLosuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 155);
            this.Controls.Add(this.buttonCofnij);
            this.Controls.Add(this.buttonSpr);
            this.Controls.Add(this.textBoxLosowanie);
            this.Controls.Add(this.labelLosowanie);
            this.Controls.Add(this.buttonLosuj);
            this.Name = "FormLosuj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.Label labelLosowanie;
        private System.Windows.Forms.TextBox textBoxLosowanie;
        private System.Windows.Forms.Button buttonSpr;
        private System.Windows.Forms.Button buttonCofnij;
    }
}