namespace Guess_me_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.własneWyrazyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyrazySystemoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trybGryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToCreateWordlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointslabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.Label();
            this.wpiszlitere = new System.Windows.Forms.TextBox();
            this.hacks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.trybGryToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.własneWyrazyToolStripMenuItem,
            this.wyrazySystemoweToolStripMenuItem});
            this.plikToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.plikToolStripMenuItem.Text = "File";
            // 
            // własneWyrazyToolStripMenuItem
            // 
            this.własneWyrazyToolStripMenuItem.Name = "własneWyrazyToolStripMenuItem";
            this.własneWyrazyToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.własneWyrazyToolStripMenuItem.Text = "Own words";
            this.własneWyrazyToolStripMenuItem.Click += new System.EventHandler(this.własneWyrazyToolStripMenuItem_Click);
            // 
            // wyrazySystemoweToolStripMenuItem
            // 
            this.wyrazySystemoweToolStripMenuItem.Name = "wyrazySystemoweToolStripMenuItem";
            this.wyrazySystemoweToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.wyrazySystemoweToolStripMenuItem.Text = "default words";
            this.wyrazySystemoweToolStripMenuItem.Click += new System.EventHandler(this.wyrazySystemoweToolStripMenuItem_Click);
            // 
            // trybGryToolStripMenuItem
            // 
            this.trybGryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheatsToolStripMenuItem});
            this.trybGryToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.trybGryToolStripMenuItem.Name = "trybGryToolStripMenuItem";
            this.trybGryToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.trybGryToolStripMenuItem.Text = "Options";
            // 
            // cheatsToolStripMenuItem
            // 
            this.cheatsToolStripMenuItem.CheckOnClick = true;
            this.cheatsToolStripMenuItem.Name = "cheatsToolStripMenuItem";
            this.cheatsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cheatsToolStripMenuItem.Text = "cheats";
            this.cheatsToolStripMenuItem.Click += new System.EventHandler(this.cheatsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToCreateWordlistToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToCreateWordlistToolStripMenuItem
            // 
            this.howToCreateWordlistToolStripMenuItem.Name = "howToCreateWordlistToolStripMenuItem";
            this.howToCreateWordlistToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.howToCreateWordlistToolStripMenuItem.Text = "how to create a list of words?";
            this.howToCreateWordlistToolStripMenuItem.Click += new System.EventHandler(this.howToCreateWordlistToolStripMenuItem_Click);
            // 
            // pointslabel
            // 
            this.pointslabel.AutoSize = true;
            this.pointslabel.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointslabel.Location = new System.Drawing.Point(610, 29);
            this.pointslabel.Name = "pointslabel";
            this.pointslabel.Size = new System.Drawing.Size(141, 33);
            this.pointslabel.TabIndex = 2;
            this.pointslabel.Text = "Points: 0";
            this.pointslabel.Click += new System.EventHandler(this.pointslabel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // word
            // 
            this.word.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word.Location = new System.Drawing.Point(12, 160);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(627, 79);
            this.word.TabIndex = 4;
            this.word.Text = "G U E SS   M E ! ";
            this.word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wpiszlitere
            // 
            this.wpiszlitere.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wpiszlitere.ImeMode = System.Windows.Forms.ImeMode.On;
            this.wpiszlitere.Location = new System.Drawing.Point(246, 267);
            this.wpiszlitere.MaxLength = 1;
            this.wpiszlitere.Name = "wpiszlitere";
            this.wpiszlitere.Size = new System.Drawing.Size(147, 43);
            this.wpiszlitere.TabIndex = 1;
            this.wpiszlitere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hacks
            // 
            this.hacks.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hacks.Location = new System.Drawing.Point(167, 65);
            this.hacks.Name = "hacks";
            this.hacks.Size = new System.Drawing.Size(298, 33);
            this.hacks.TabIndex = 6;
            this.hacks.Text = "Word: ";
            this.hacks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hacks.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Guess_me_.Properties.Resources.brakbledu;
            this.pictureBox1.Location = new System.Drawing.Point(645, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "USED LETTERS: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(457, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 144);
            this.label2.TabIndex = 8;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hacks);
            this.Controls.Add(this.wpiszlitere);
            this.Controls.Add(this.word);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pointslabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trybGryToolStripMenuItem;
        private System.Windows.Forms.Label pointslabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.TextBox wpiszlitere;
        private System.Windows.Forms.ToolStripMenuItem własneWyrazyToolStripMenuItem;
        private System.Windows.Forms.Label hacks;
        private System.Windows.Forms.ToolStripMenuItem wyrazySystemoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToCreateWordlistToolStripMenuItem;
    }
}

