namespace Battleships
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.bttnBattleship = new System.Windows.Forms.Button();
            this.bttnSubmarine1 = new System.Windows.Forms.Button();
            this.bttnDestroyer1 = new System.Windows.Forms.Button();
            this.bttnPatrol1 = new System.Windows.Forms.Button();
            this.bttnSubmarine2 = new System.Windows.Forms.Button();
            this.bttnDestroyer2 = new System.Windows.Forms.Button();
            this.bttnDestroyer3 = new System.Windows.Forms.Button();
            this.bttnPatrol2 = new System.Windows.Forms.Button();
            this.bttnPatrol3 = new System.Windows.Forms.Button();
            this.bttnPatrol4 = new System.Windows.Forms.Button();
            this.panelComputer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DifficulttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EasyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoundtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusictoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelPlayer.Location = new System.Drawing.Point(0, 25);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(385, 385);
            this.panelPlayer.TabIndex = 4;
            // 
            // bttnBattleship
            // 
            this.bttnBattleship.BackColor = System.Drawing.Color.DimGray;
            this.bttnBattleship.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnBattleship.Location = new System.Drawing.Point(3, 3);
            this.bttnBattleship.Name = "bttnBattleship";
            this.bttnBattleship.Size = new System.Drawing.Size(140, 35);
            this.bttnBattleship.TabIndex = 5;
            this.bttnBattleship.UseVisualStyleBackColor = false;
            this.bttnBattleship.Click += new System.EventHandler(this.BttnShip_Click);
            // 
            // bttnSubmarine1
            // 
            this.bttnSubmarine1.BackColor = System.Drawing.Color.DimGray;
            this.bttnSubmarine1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSubmarine1.Location = new System.Drawing.Point(3, 44);
            this.bttnSubmarine1.Name = "bttnSubmarine1";
            this.bttnSubmarine1.Size = new System.Drawing.Size(105, 35);
            this.bttnSubmarine1.TabIndex = 6;
            this.bttnSubmarine1.UseVisualStyleBackColor = false;
            this.bttnSubmarine1.Click += new System.EventHandler(this.BttnShip_Click);
            // 
            // bttnDestroyer1
            // 
            this.bttnDestroyer1.BackColor = System.Drawing.Color.DimGray;
            this.bttnDestroyer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnDestroyer1.Location = new System.Drawing.Point(3, 85);
            this.bttnDestroyer1.Name = "bttnDestroyer1";
            this.bttnDestroyer1.Size = new System.Drawing.Size(70, 35);
            this.bttnDestroyer1.TabIndex = 8;
            this.bttnDestroyer1.UseVisualStyleBackColor = false;
            this.bttnDestroyer1.Click += new System.EventHandler(this.BttnShip_Click);
            // 
            // bttnPatrol1
            // 
            this.bttnPatrol1.BackColor = System.Drawing.Color.DimGray;
            this.bttnPatrol1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnPatrol1.Location = new System.Drawing.Point(3, 126);
            this.bttnPatrol1.Name = "bttnPatrol1";
            this.bttnPatrol1.Size = new System.Drawing.Size(35, 35);
            this.bttnPatrol1.TabIndex = 11;
            this.bttnPatrol1.UseVisualStyleBackColor = false;
            this.bttnPatrol1.Click += new System.EventHandler(this.BttnShip_Click);
            // 
            // bttnSubmarine2
            // 
            this.bttnSubmarine2.BackColor = System.Drawing.Color.DimGray;
            this.bttnSubmarine2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSubmarine2.Location = new System.Drawing.Point(114, 44);
            this.bttnSubmarine2.Name = "bttnSubmarine2";
            this.bttnSubmarine2.Size = new System.Drawing.Size(105, 35);
            this.bttnSubmarine2.TabIndex = 7;
            this.bttnSubmarine2.UseVisualStyleBackColor = false;
            this.bttnSubmarine2.Click += new System.EventHandler(this.BttnShip_Click);
            // 
            // bttnDestroyer2
            // 
            this.bttnDestroyer2.BackColor = System.Drawing.Color.DimGray;
            this.bttnDestroyer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnDestroyer2.Location = new System.Drawing.Point(79, 85);
            this.bttnDestroyer2.Name = "bttnDestroyer2";
            this.bttnDestroyer2.Size = new System.Drawing.Size(70, 35);
            this.bttnDestroyer2.TabIndex = 9;
            this.bttnDestroyer2.UseVisualStyleBackColor = false;
            this.bttnDestroyer2.Click += new System.EventHandler(this.BttnShip_Click);
            // 
            // bttnDestroyer3
            // 
            this.bttnDestroyer3.BackColor = System.Drawing.Color.DimGray;
            this.bttnDestroyer3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnDestroyer3.Location = new System.Drawing.Point(155, 85);
            this.bttnDestroyer3.Name = "bttnDestroyer3";
            this.bttnDestroyer3.Size = new System.Drawing.Size(70, 35);
            this.bttnDestroyer3.TabIndex = 10;
            this.bttnDestroyer3.UseVisualStyleBackColor = false;
            this.bttnDestroyer3.Click += new System.EventHandler(this.BttnShip_Click);
            // 
            // bttnPatrol2
            // 
            this.bttnPatrol2.BackColor = System.Drawing.Color.DimGray;
            this.bttnPatrol2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnPatrol2.Location = new System.Drawing.Point(44, 126);
            this.bttnPatrol2.Name = "bttnPatrol2";
            this.bttnPatrol2.Size = new System.Drawing.Size(35, 35);
            this.bttnPatrol2.TabIndex = 12;
            this.bttnPatrol2.UseVisualStyleBackColor = false;
            this.bttnPatrol2.Click += new System.EventHandler(this.BttnShip_Click);
            // 
            // bttnPatrol3
            // 
            this.bttnPatrol3.BackColor = System.Drawing.Color.DimGray;
            this.bttnPatrol3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnPatrol3.Location = new System.Drawing.Point(85, 126);
            this.bttnPatrol3.Name = "bttnPatrol3";
            this.bttnPatrol3.Size = new System.Drawing.Size(35, 35);
            this.bttnPatrol3.TabIndex = 13;
            this.bttnPatrol3.UseVisualStyleBackColor = false;
            this.bttnPatrol3.Click += new System.EventHandler(this.BttnShip_Click);
            // 
            // bttnPatrol4
            // 
            this.bttnPatrol4.BackColor = System.Drawing.Color.DimGray;
            this.bttnPatrol4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnPatrol4.Location = new System.Drawing.Point(126, 126);
            this.bttnPatrol4.Name = "bttnPatrol4";
            this.bttnPatrol4.Size = new System.Drawing.Size(35, 35);
            this.bttnPatrol4.TabIndex = 14;
            this.bttnPatrol4.UseVisualStyleBackColor = false;
            this.bttnPatrol4.Click += new System.EventHandler(this.BttnShip_Click);
            // 
            // panelComputer
            // 
            this.panelComputer.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelComputer.Location = new System.Drawing.Point(386, 25);
            this.panelComputer.Name = "panelComputer";
            this.panelComputer.Size = new System.Drawing.Size(385, 385);
            this.panelComputer.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.bttnBattleship);
            this.panel1.Controls.Add(this.buttonStartStop);
            this.panel1.Controls.Add(this.bttnSubmarine1);
            this.panel1.Controls.Add(this.bttnDestroyer1);
            this.panel1.Controls.Add(this.bttnPatrol1);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.bttnSubmarine2);
            this.panel1.Controls.Add(this.buttonRandomize);
            this.panel1.Controls.Add(this.bttnDestroyer2);
            this.panel1.Controls.Add(this.buttonRotate);
            this.panel1.Controls.Add(this.bttnPatrol4);
            this.panel1.Controls.Add(this.bttnDestroyer3);
            this.panel1.Controls.Add(this.bttnPatrol3);
            this.panel1.Controls.Add(this.bttnPatrol2);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 210);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(662, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Przebieg gry";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(386, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(385, 208);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.BackColor = System.Drawing.Color.Firebrick;
            this.buttonStartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartStop.Location = new System.Drawing.Point(305, 3);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 50);
            this.buttonStartStop.TabIndex = 18;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = false;
            this.buttonStartStop.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(244, 115);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 50);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.BackColor = System.Drawing.Color.Firebrick;
            this.buttonRandomize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRandomize.BackgroundImage")));
            this.buttonRandomize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRandomize.Location = new System.Drawing.Point(244, 59);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(50, 50);
            this.buttonRandomize.TabIndex = 16;
            this.buttonRandomize.UseVisualStyleBackColor = false;
            this.buttonRandomize.Click += new System.EventHandler(this.ButtonRandomize_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonRotate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRotate.BackgroundImage")));
            this.buttonRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRotate.Location = new System.Drawing.Point(244, 3);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(50, 50);
            this.buttonRotate.TabIndex = 15;
            this.buttonRotate.UseVisualStyleBackColor = false;
            this.buttonRotate.Click += new System.EventHandler(this.ButtonRotate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DifficulttoolStripMenuItem,
            this.SoundtoolStripMenuItem,
            this.MusictoolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItem1.Text = "Ustawienia";
            // 
            // DifficulttoolStripMenuItem
            // 
            this.DifficulttoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EasyToolStripMenuItem,
            this.HardToolStripMenuItem});
            this.DifficulttoolStripMenuItem.Name = "DifficulttoolStripMenuItem";
            this.DifficulttoolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.DifficulttoolStripMenuItem.Text = "Poziom";
            // 
            // EasyToolStripMenuItem
            // 
            this.EasyToolStripMenuItem.Checked = true;
            this.EasyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem";
            this.EasyToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.EasyToolStripMenuItem.Text = "Łatwy";
            this.EasyToolStripMenuItem.Click += new System.EventHandler(this.EasyToolStripMenuItem_Click);
            // 
            // HardToolStripMenuItem
            // 
            this.HardToolStripMenuItem.Name = "HardToolStripMenuItem";
            this.HardToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.HardToolStripMenuItem.Text = "Trudny";
            this.HardToolStripMenuItem.Click += new System.EventHandler(this.HardToolStripMenuItem_Click);
            // 
            // SoundtoolStripMenuItem
            // 
            this.SoundtoolStripMenuItem.Checked = true;
            this.SoundtoolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SoundtoolStripMenuItem.Name = "SoundtoolStripMenuItem";
            this.SoundtoolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.SoundtoolStripMenuItem.Text = "Dzwięki";
            this.SoundtoolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemSound_Click);
            // 
            // MusictoolStripMenuItem
            // 
            this.MusictoolStripMenuItem.Name = "MusictoolStripMenuItem";
            this.MusictoolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.MusictoolStripMenuItem.Text = "Muzyka";
            this.MusictoolStripMenuItem.Click += new System.EventHandler(this.MusictoolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem3.Text = "Wyniki";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem2.Text = "Zakończ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(773, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelComputer);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Battleships";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button bttnSubmarine1;
        private System.Windows.Forms.Button bttnBattleship;
        private System.Windows.Forms.Button bttnDestroyer1;
        private System.Windows.Forms.Button bttnPatrol1;
        private System.Windows.Forms.Button bttnSubmarine2;
        private System.Windows.Forms.Button bttnDestroyer2;
        private System.Windows.Forms.Button bttnDestroyer3;
        private System.Windows.Forms.Button bttnPatrol2;
        private System.Windows.Forms.Button bttnPatrol3;
        private System.Windows.Forms.Button bttnPatrol4;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelComputer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DifficulttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SoundtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EasyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusictoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

