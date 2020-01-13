namespace Przeszukiwanie_grafu
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
            this.grafButton = new System.Windows.Forms.Button();
            this.liczbaWierzcholkow = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wierzcholkiButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyborAlgorytmuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorytm1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorytm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorytm3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakonczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uruchomAlgorytmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.liczbaWierzcholkow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafButton
            // 
            this.grafButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grafButton.AutoSize = true;
            this.grafButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grafButton.Enabled = false;
            this.grafButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grafButton.Location = new System.Drawing.Point(172, 5);
            this.grafButton.Margin = new System.Windows.Forms.Padding(4);
            this.grafButton.Name = "grafButton";
            this.grafButton.Size = new System.Drawing.Size(95, 27);
            this.grafButton.TabIndex = 0;
            this.grafButton.Text = "Rysuj Graf";
            this.grafButton.UseVisualStyleBackColor = true;
            this.grafButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // liczbaWierzcholkow
            // 
            this.liczbaWierzcholkow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.liczbaWierzcholkow.LargeChange = 25;
            this.liczbaWierzcholkow.Location = new System.Drawing.Point(0, 117);
            this.liczbaWierzcholkow.Margin = new System.Windows.Forms.Padding(4);
            this.liczbaWierzcholkow.Maximum = 1000;
            this.liczbaWierzcholkow.Minimum = 900;
            this.liczbaWierzcholkow.Name = "liczbaWierzcholkow";
            this.liczbaWierzcholkow.Size = new System.Drawing.Size(1157, 56);
            this.liczbaWierzcholkow.SmallChange = 20;
            this.liczbaWierzcholkow.TabIndex = 20;
            this.liczbaWierzcholkow.Value = 900;
            this.liczbaWierzcholkow.Scroll += new System.EventHandler(this.liczbaWierzcholkow_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1133, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Wypelnienie wierzcholkami 90 - 99 %";
            // 
            // wierzcholkiButton
            // 
            this.wierzcholkiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wierzcholkiButton.AutoSize = true;
            this.wierzcholkiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wierzcholkiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wierzcholkiButton.Location = new System.Drawing.Point(4, 5);
            this.wierzcholkiButton.Margin = new System.Windows.Forms.Padding(4);
            this.wierzcholkiButton.Name = "wierzcholkiButton";
            this.wierzcholkiButton.Size = new System.Drawing.Size(160, 27);
            this.wierzcholkiButton.TabIndex = 104;
            this.wierzcholkiButton.Text = "Generuj wierzcholki";
            this.wierzcholkiButton.UseVisualStyleBackColor = true;
            this.wierzcholkiButton.Click += new System.EventHandler(this.wierzcholkiButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.wierzcholkiButton);
            this.panel1.Controls.Add(this.grafButton);
            this.panel1.Controls.Add(this.liczbaWierzcholkow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 173);
            this.panel1.TabIndex = 106;
            this.panel1.TabStop = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.wyborAlgorytmuToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.uruchomAlgorytmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 28);
            this.menuStrip1.TabIndex = 108;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.zakonczToolStripMenuItem});
            this.programToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.programToolStripMenuItem.Text = "Program";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // wyborAlgorytmuToolStripMenuItem
            // 
            this.wyborAlgorytmuToolStripMenuItem.CheckOnClick = true;
            this.wyborAlgorytmuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algorytm1ToolStripMenuItem,
            this.algorytm2ToolStripMenuItem,
            this.algorytm3ToolStripMenuItem});
            this.wyborAlgorytmuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.wyborAlgorytmuToolStripMenuItem.Name = "wyborAlgorytmuToolStripMenuItem";
            this.wyborAlgorytmuToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.wyborAlgorytmuToolStripMenuItem.Text = "Wybor Algorytmu";
            // 
            // algorytm1ToolStripMenuItem
            // 
            this.algorytm1ToolStripMenuItem.Checked = true;
            this.algorytm1ToolStripMenuItem.CheckOnClick = true;
            this.algorytm1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.algorytm1ToolStripMenuItem.Name = "algorytm1ToolStripMenuItem";
            this.algorytm1ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.algorytm1ToolStripMenuItem.Text = "Algorytm1";
            this.algorytm1ToolStripMenuItem.Click += new System.EventHandler(this.algorytm1ToolStripMenuItem_Click);
            // 
            // algorytm2ToolStripMenuItem
            // 
            this.algorytm2ToolStripMenuItem.CheckOnClick = true;
            this.algorytm2ToolStripMenuItem.Name = "algorytm2ToolStripMenuItem";
            this.algorytm2ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.algorytm2ToolStripMenuItem.Text = "Algorytm2";
            this.algorytm2ToolStripMenuItem.Click += new System.EventHandler(this.algorytm2ToolStripMenuItem_Click);
            // 
            // algorytm3ToolStripMenuItem
            // 
            this.algorytm3ToolStripMenuItem.CheckOnClick = true;
            this.algorytm3ToolStripMenuItem.Name = "algorytm3ToolStripMenuItem";
            this.algorytm3ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.algorytm3ToolStripMenuItem.Text = "Algorytm3";
            this.algorytm3ToolStripMenuItem.Click += new System.EventHandler(this.algorytm3ToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1133, 439);
            this.panel2.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1029, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 106;
            this.label4.Text = "ERROR!";
            this.label4.Visible = false;
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // zakonczToolStripMenuItem
            // 
            this.zakonczToolStripMenuItem.Name = "zakonczToolStripMenuItem";
            this.zakonczToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.zakonczToolStripMenuItem.Text = "Zakoncz";
            this.zakonczToolStripMenuItem.Click += new System.EventHandler(this.zakonczToolStripMenuItem_Click);
            // 
            // uruchomAlgorytmToolStripMenuItem
            // 
            this.uruchomAlgorytmToolStripMenuItem.Enabled = false;
            this.uruchomAlgorytmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.uruchomAlgorytmToolStripMenuItem.Name = "uruchomAlgorytmToolStripMenuItem";
            this.uruchomAlgorytmToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.uruchomAlgorytmToolStripMenuItem.Text = "Uruchom Algorytm";
            this.uruchomAlgorytmToolStripMenuItem.Click += new System.EventHandler(this.uruchomAlgorytmToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1157, 666);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program do wyznaczania drogi.";
            ((System.ComponentModel.ISupportInitialize)(this.liczbaWierzcholkow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grafButton;
        private System.Windows.Forms.TrackBar liczbaWierzcholkow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wierzcholkiButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyborAlgorytmuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorytm1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorytm2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorytm3ToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakonczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uruchomAlgorytmToolStripMenuItem;
    }
}

