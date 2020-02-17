namespace ElsoWinForm
{
    partial class MacskasUrlap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacskasUrlap));
            this.BeviteliMezo = new System.Windows.Forms.TextBox();
            this.ModositoGomb = new System.Windows.Forms.Button();
            this.KimenoSzoveg = new System.Windows.Forms.TextBox();
            this.EltuntetGomb = new System.Windows.Forms.Button();
            this.BezarGomb = new System.Windows.Forms.Button();
            this.szoveg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BeviteliMezo
            // 
            this.BeviteliMezo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BeviteliMezo.Location = new System.Drawing.Point(228, 45);
            this.BeviteliMezo.Multiline = true;
            this.BeviteliMezo.Name = "BeviteliMezo";
            this.BeviteliMezo.PasswordChar = 'ß';
            this.BeviteliMezo.Size = new System.Drawing.Size(100, 20);
            this.BeviteliMezo.TabIndex = 1;
            this.BeviteliMezo.TextChanged += new System.EventHandler(this.BeviteliMezo_TextChanged);
            // 
            // ModositoGomb
            // 
            this.ModositoGomb.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ModositoGomb.Location = new System.Drawing.Point(37, 191);
            this.ModositoGomb.Name = "ModositoGomb";
            this.ModositoGomb.Size = new System.Drawing.Size(90, 55);
            this.ModositoGomb.TabIndex = 2;
            this.ModositoGomb.Text = "Módosítógomb";
            this.ModositoGomb.UseVisualStyleBackColor = false;
            this.ModositoGomb.Click += new System.EventHandler(this.ModositoGomb_Click);
            this.ModositoGomb.MouseEnter += new System.EventHandler(this.ModositoGomb_MouseEnter);
            this.ModositoGomb.MouseLeave += new System.EventHandler(this.ModositoGomb_MouseLeave);
            // 
            // KimenoSzoveg
            // 
            this.KimenoSzoveg.Location = new System.Drawing.Point(228, 89);
            this.KimenoSzoveg.Name = "KimenoSzoveg";
            this.KimenoSzoveg.Size = new System.Drawing.Size(100, 20);
            this.KimenoSzoveg.TabIndex = 3;
            // 
            // EltuntetGomb
            // 
            this.EltuntetGomb.BackColor = System.Drawing.Color.Lime;
            this.EltuntetGomb.Location = new System.Drawing.Point(293, 191);
            this.EltuntetGomb.Name = "EltuntetGomb";
            this.EltuntetGomb.Size = new System.Drawing.Size(90, 55);
            this.EltuntetGomb.TabIndex = 4;
            this.EltuntetGomb.Text = "Eltüntet";
            this.EltuntetGomb.UseVisualStyleBackColor = false;
            this.EltuntetGomb.Click += new System.EventHandler(this.EltuntetGomb_Click);
            // 
            // BezarGomb
            // 
            this.BezarGomb.BackColor = System.Drawing.Color.Yellow;
            this.BezarGomb.Location = new System.Drawing.Point(531, 191);
            this.BezarGomb.Name = "BezarGomb";
            this.BezarGomb.Size = new System.Drawing.Size(90, 55);
            this.BezarGomb.TabIndex = 5;
            this.BezarGomb.Text = "Bezárás";
            this.BezarGomb.UseVisualStyleBackColor = false;
            this.BezarGomb.Click += new System.EventHandler(this.BezarGomb_Click);
            this.BezarGomb.MouseEnter += new System.EventHandler(this.BezarGomb_MouseEnter);
            // 
            // szoveg
            // 
            this.szoveg.AutoSize = true;
            this.szoveg.BackColor = System.Drawing.Color.White;
            this.szoveg.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szoveg.ForeColor = System.Drawing.Color.DarkRed;
            this.szoveg.Location = new System.Drawing.Point(74, 42);
            this.szoveg.Name = "szoveg";
            this.szoveg.Size = new System.Drawing.Size(70, 22);
            this.szoveg.TabIndex = 0;
            this.szoveg.Text = "Szöveg";
            this.szoveg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MacskasUrlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(761, 335);
            this.Controls.Add(this.BezarGomb);
            this.Controls.Add(this.EltuntetGomb);
            this.Controls.Add(this.KimenoSzoveg);
            this.Controls.Add(this.ModositoGomb);
            this.Controls.Add(this.BeviteliMezo);
            this.Controls.Add(this.szoveg);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "MacskasUrlap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macskás Űrlap";
            this.Load += new System.EventHandler(this.MacskasUrlap_Load);
            this.MouseEnter += new System.EventHandler(this.MacskasUrlap_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MacskasUrlap_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MacskasUrlap_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BeviteliMezo;
        private System.Windows.Forms.Button ModositoGomb;
        private System.Windows.Forms.TextBox KimenoSzoveg;
        private System.Windows.Forms.Button EltuntetGomb;
        private System.Windows.Forms.Button BezarGomb;
        private System.Windows.Forms.Label szoveg;
    }
}

