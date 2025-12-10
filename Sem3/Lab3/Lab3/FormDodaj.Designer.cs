namespace Lab3
{
    partial class FormDodaj
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
            this.textBoxAng = new System.Windows.Forms.TextBox();
            this.textBoxPl = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAng
            // 
            this.textBoxAng.Location = new System.Drawing.Point(12, 12);
            this.textBoxAng.Name = "textBoxAng";
            this.textBoxAng.Size = new System.Drawing.Size(159, 20);
            this.textBoxAng.TabIndex = 0;
            this.textBoxAng.Text = "Dodaj słowo po angielsku";
            this.textBoxAng.Enter += new System.EventHandler(this.textBoxAng_Enter);
            this.textBoxAng.Leave += new System.EventHandler(this.textBoxAng_Leave);
            // 
            // textBoxPl
            // 
            this.textBoxPl.Location = new System.Drawing.Point(12, 38);
            this.textBoxPl.Name = "textBoxPl";
            this.textBoxPl.Size = new System.Drawing.Size(159, 20);
            this.textBoxPl.TabIndex = 1;
            this.textBoxPl.Text = "Dodaj słowo po polsku";
            this.textBoxPl.Enter += new System.EventHandler(this.textBoxPl_Enter);
            this.textBoxPl.Leave += new System.EventHandler(this.textBoxPl_Leave);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(54, 64);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Dodaj";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 106);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxPl);
            this.Controls.Add(this.textBoxAng);
            this.Name = "FormDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAng;
        private System.Windows.Forms.TextBox textBoxPl;
        private System.Windows.Forms.Button buttonOk;
    }
}