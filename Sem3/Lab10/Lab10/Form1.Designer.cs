namespace Lab10
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxTree = new System.Windows.Forms.CheckBox();
            this.checkBoxLights = new System.Windows.Forms.CheckBox();
            this.checkBoxBombs = new System.Windows.Forms.CheckBox();
            this.checkBoxGifts = new System.Windows.Forms.CheckBox();
            this.checkBoxMelody = new System.Windows.Forms.CheckBox();
            this.checkBoxChains = new System.Windows.Forms.CheckBox();
            this.checkBoxStar = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBoxTree
            // 
            this.checkBoxTree.AutoSize = true;
            this.checkBoxTree.Location = new System.Drawing.Point(271, 12);
            this.checkBoxTree.Name = "checkBoxTree";
            this.checkBoxTree.Size = new System.Drawing.Size(65, 17);
            this.checkBoxTree.TabIndex = 2;
            this.checkBoxTree.Text = "Choinka";
            this.checkBoxTree.UseVisualStyleBackColor = true;
            this.checkBoxTree.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxLights
            // 
            this.checkBoxLights.AutoSize = true;
            this.checkBoxLights.Location = new System.Drawing.Point(271, 35);
            this.checkBoxLights.Name = "checkBoxLights";
            this.checkBoxLights.Size = new System.Drawing.Size(74, 17);
            this.checkBoxLights.TabIndex = 3;
            this.checkBoxLights.Text = "Światełka";
            this.checkBoxLights.UseVisualStyleBackColor = true;
            this.checkBoxLights.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxBombs
            // 
            this.checkBoxBombs.AutoSize = true;
            this.checkBoxBombs.Location = new System.Drawing.Point(271, 58);
            this.checkBoxBombs.Name = "checkBoxBombs";
            this.checkBoxBombs.Size = new System.Drawing.Size(61, 17);
            this.checkBoxBombs.TabIndex = 4;
            this.checkBoxBombs.Text = "Bombki";
            this.checkBoxBombs.UseVisualStyleBackColor = true;
            this.checkBoxBombs.CheckedChanged += new System.EventHandler(this.checkBoxBombs_CheckedChanged);
            // 
            // checkBoxGifts
            // 
            this.checkBoxGifts.AutoSize = true;
            this.checkBoxGifts.Location = new System.Drawing.Point(271, 81);
            this.checkBoxGifts.Name = "checkBoxGifts";
            this.checkBoxGifts.Size = new System.Drawing.Size(67, 17);
            this.checkBoxGifts.TabIndex = 5;
            this.checkBoxGifts.Text = "Prezenty";
            this.checkBoxGifts.UseVisualStyleBackColor = true;
            this.checkBoxGifts.CheckedChanged += new System.EventHandler(this.checkBoxGifts_CheckedChanged);
            // 
            // checkBoxMelody
            // 
            this.checkBoxMelody.AutoSize = true;
            this.checkBoxMelody.Location = new System.Drawing.Point(271, 127);
            this.checkBoxMelody.Name = "checkBoxMelody";
            this.checkBoxMelody.Size = new System.Drawing.Size(74, 17);
            this.checkBoxMelody.TabIndex = 7;
            this.checkBoxMelody.Text = "Melodyjka";
            this.checkBoxMelody.UseVisualStyleBackColor = true;
            this.checkBoxMelody.CheckedChanged += new System.EventHandler(this.checkBoxMelody_CheckedChanged);
            // 
            // checkBoxChains
            // 
            this.checkBoxChains.AutoSize = true;
            this.checkBoxChains.Location = new System.Drawing.Point(271, 104);
            this.checkBoxChains.Name = "checkBoxChains";
            this.checkBoxChains.Size = new System.Drawing.Size(74, 17);
            this.checkBoxChains.TabIndex = 6;
            this.checkBoxChains.Text = "Łańcuchy";
            this.checkBoxChains.UseVisualStyleBackColor = true;
            this.checkBoxChains.CheckedChanged += new System.EventHandler(this.checkBoxChains_CheckedChanged);
            // 
            // checkBoxStar
            // 
            this.checkBoxStar.AutoSize = true;
            this.checkBoxStar.Location = new System.Drawing.Point(271, 150);
            this.checkBoxStar.Name = "checkBoxStar";
            this.checkBoxStar.Size = new System.Drawing.Size(73, 17);
            this.checkBoxStar.TabIndex = 8;
            this.checkBoxStar.Text = "Gwiazdka";
            this.checkBoxStar.UseVisualStyleBackColor = true;
            this.checkBoxStar.CheckedChanged += new System.EventHandler(this.checkBoxStar_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(160, 280);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(209, 122);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(376, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.checkBoxStar);
            this.Controls.Add(this.checkBoxMelody);
            this.Controls.Add(this.checkBoxChains);
            this.Controls.Add(this.checkBoxGifts);
            this.Controls.Add(this.checkBoxBombs);
            this.Controls.Add(this.checkBoxTree);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxLights);
            this.Name = "Form1";
            this.Text = "Lab10";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxTree;
        private System.Windows.Forms.CheckBox checkBoxLights;
        private System.Windows.Forms.CheckBox checkBoxGifts;
        private System.Windows.Forms.CheckBox checkBoxBombs;
        private System.Windows.Forms.CheckBox checkBoxMelody;
        private System.Windows.Forms.CheckBox checkBoxChains;
        private System.Windows.Forms.CheckBox checkBoxStar;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button1;
    }
}

