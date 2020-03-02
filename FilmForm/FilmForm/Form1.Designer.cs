namespace FilmForm
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
            this.topmoziLB = new System.Windows.Forms.ListBox();
            this.moziLatottLB = new System.Windows.Forms.ListBox();
            this.szovegTxt = new System.Windows.Forms.TextBox();
            this.elemszamNUD = new System.Windows.Forms.NumericUpDown();
            this.felveszBtn = new System.Windows.Forms.Button();
            this.beszurBtn = new System.Windows.Forms.Button();
            this.torolBtn = new System.Windows.Forms.Button();
            this.torolMindBtn = new System.Windows.Forms.Button();
            this.atmasolBtn = new System.Windows.Forms.Button();
            this.atmozgatBtn = new System.Windows.Forms.Button();
            this.keresBtn = new System.Windows.Forms.Button();
            this.evText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.elemszamNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // topmoziLB
            // 
            this.topmoziLB.FormattingEnabled = true;
            this.topmoziLB.Location = new System.Drawing.Point(46, 65);
            this.topmoziLB.Name = "topmoziLB";
            this.topmoziLB.Size = new System.Drawing.Size(274, 368);
            this.topmoziLB.TabIndex = 0;
            // 
            // moziLatottLB
            // 
            this.moziLatottLB.FormattingEnabled = true;
            this.moziLatottLB.Location = new System.Drawing.Point(511, 65);
            this.moziLatottLB.Name = "moziLatottLB";
            this.moziLatottLB.Size = new System.Drawing.Size(285, 368);
            this.moziLatottLB.TabIndex = 1;
            // 
            // szovegTxt
            // 
            this.szovegTxt.Location = new System.Drawing.Point(46, 12);
            this.szovegTxt.Name = "szovegTxt";
            this.szovegTxt.Size = new System.Drawing.Size(209, 20);
            this.szovegTxt.TabIndex = 2;
            // 
            // elemszamNUD
            // 
            this.elemszamNUD.Location = new System.Drawing.Point(374, 13);
            this.elemszamNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.elemszamNUD.Name = "elemszamNUD";
            this.elemszamNUD.Size = new System.Drawing.Size(120, 20);
            this.elemszamNUD.TabIndex = 3;
            this.elemszamNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.elemszamNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // felveszBtn
            // 
            this.felveszBtn.Location = new System.Drawing.Point(387, 65);
            this.felveszBtn.Name = "felveszBtn";
            this.felveszBtn.Size = new System.Drawing.Size(75, 28);
            this.felveszBtn.TabIndex = 4;
            this.felveszBtn.Text = "Felvesz";
            this.felveszBtn.UseVisualStyleBackColor = true;
            this.felveszBtn.Click += new System.EventHandler(this.felveszBtn_Click);
            // 
            // beszurBtn
            // 
            this.beszurBtn.Location = new System.Drawing.Point(387, 121);
            this.beszurBtn.Name = "beszurBtn";
            this.beszurBtn.Size = new System.Drawing.Size(75, 23);
            this.beszurBtn.TabIndex = 5;
            this.beszurBtn.Text = "Beszúr";
            this.beszurBtn.UseVisualStyleBackColor = true;
            this.beszurBtn.Click += new System.EventHandler(this.beszurBtn_Click);
            // 
            // torolBtn
            // 
            this.torolBtn.Location = new System.Drawing.Point(387, 176);
            this.torolBtn.Name = "torolBtn";
            this.torolBtn.Size = new System.Drawing.Size(75, 23);
            this.torolBtn.TabIndex = 6;
            this.torolBtn.Text = "Töröl";
            this.torolBtn.UseVisualStyleBackColor = true;
            this.torolBtn.Click += new System.EventHandler(this.torolBtn_Click);
            // 
            // torolMindBtn
            // 
            this.torolMindBtn.Location = new System.Drawing.Point(387, 237);
            this.torolMindBtn.Name = "torolMindBtn";
            this.torolMindBtn.Size = new System.Drawing.Size(75, 23);
            this.torolMindBtn.TabIndex = 7;
            this.torolMindBtn.Text = "Töröl mind";
            this.torolMindBtn.UseVisualStyleBackColor = true;
            this.torolMindBtn.Click += new System.EventHandler(this.torolMindBtn_Click);
            // 
            // atmasolBtn
            // 
            this.atmasolBtn.Location = new System.Drawing.Point(387, 300);
            this.atmasolBtn.Name = "atmasolBtn";
            this.atmasolBtn.Size = new System.Drawing.Size(75, 23);
            this.atmasolBtn.TabIndex = 8;
            this.atmasolBtn.Text = "Átmásol";
            this.atmasolBtn.UseVisualStyleBackColor = true;
            this.atmasolBtn.Click += new System.EventHandler(this.atmasolBtn_Click);
            // 
            // atmozgatBtn
            // 
            this.atmozgatBtn.Location = new System.Drawing.Point(387, 351);
            this.atmozgatBtn.Name = "atmozgatBtn";
            this.atmozgatBtn.Size = new System.Drawing.Size(75, 23);
            this.atmozgatBtn.TabIndex = 9;
            this.atmozgatBtn.Text = "Átmozgat";
            this.atmozgatBtn.UseVisualStyleBackColor = true;
            this.atmozgatBtn.Click += new System.EventHandler(this.atmozgatBtn_Click);
            // 
            // keresBtn
            // 
            this.keresBtn.Location = new System.Drawing.Point(387, 405);
            this.keresBtn.Name = "keresBtn";
            this.keresBtn.Size = new System.Drawing.Size(75, 23);
            this.keresBtn.TabIndex = 10;
            this.keresBtn.Text = "Keres";
            this.keresBtn.UseVisualStyleBackColor = true;
            this.keresBtn.Click += new System.EventHandler(this.keresBtn_Click);
            // 
            // evText
            // 
            this.evText.Location = new System.Drawing.Point(268, 13);
            this.evText.Name = "evText";
            this.evText.Size = new System.Drawing.Size(64, 20);
            this.evText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 491);
            this.Controls.Add(this.evText);
            this.Controls.Add(this.keresBtn);
            this.Controls.Add(this.atmozgatBtn);
            this.Controls.Add(this.atmasolBtn);
            this.Controls.Add(this.torolMindBtn);
            this.Controls.Add(this.torolBtn);
            this.Controls.Add(this.beszurBtn);
            this.Controls.Add(this.felveszBtn);
            this.Controls.Add(this.elemszamNUD);
            this.Controls.Add(this.szovegTxt);
            this.Controls.Add(this.moziLatottLB);
            this.Controls.Add(this.topmoziLB);
            this.Name = "Form1";
            this.Text = "Filmlista";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elemszamNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox topmoziLB;
        private System.Windows.Forms.ListBox moziLatottLB;
        private System.Windows.Forms.TextBox szovegTxt;
        private System.Windows.Forms.NumericUpDown elemszamNUD;
        private System.Windows.Forms.Button felveszBtn;
        private System.Windows.Forms.Button beszurBtn;
        private System.Windows.Forms.Button torolBtn;
        private System.Windows.Forms.Button torolMindBtn;
        private System.Windows.Forms.Button atmasolBtn;
        private System.Windows.Forms.Button atmozgatBtn;
        private System.Windows.Forms.Button keresBtn;
        private System.Windows.Forms.TextBox evText;
    }
}

