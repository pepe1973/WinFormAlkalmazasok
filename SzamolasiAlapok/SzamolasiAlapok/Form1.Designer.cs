namespace SzamolasiAlapok
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aOldal = new System.Windows.Forms.TextBox();
            this.bOldal = new System.Windows.Forms.TextBox();
            this.eredmenyek = new System.Windows.Forms.TextBox();
            this.SzamolasGomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A-oldal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B-oldal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eredmények";
            // 
            // aOldal
            // 
            this.aOldal.Location = new System.Drawing.Point(250, 57);
            this.aOldal.Name = "aOldal";
            this.aOldal.Size = new System.Drawing.Size(100, 20);
            this.aOldal.TabIndex = 3;
            // 
            // bOldal
            // 
            this.bOldal.Location = new System.Drawing.Point(250, 115);
            this.bOldal.Name = "bOldal";
            this.bOldal.Size = new System.Drawing.Size(100, 20);
            this.bOldal.TabIndex = 4;
            // 
            // eredmenyek
            // 
            this.eredmenyek.Location = new System.Drawing.Point(250, 183);
            this.eredmenyek.Multiline = true;
            this.eredmenyek.Name = "eredmenyek";
            this.eredmenyek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eredmenyek.Size = new System.Drawing.Size(100, 93);
            this.eredmenyek.TabIndex = 5;
            // 
            // SzamolasGomb
            // 
            this.SzamolasGomb.Location = new System.Drawing.Point(450, 55);
            this.SzamolasGomb.Name = "SzamolasGomb";
            this.SzamolasGomb.Size = new System.Drawing.Size(75, 23);
            this.SzamolasGomb.TabIndex = 6;
            this.SzamolasGomb.Text = "Számolás";
            this.SzamolasGomb.UseVisualStyleBackColor = true;
            this.SzamolasGomb.Click += new System.EventHandler(this.SzamolasGomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 424);
            this.Controls.Add(this.SzamolasGomb);
            this.Controls.Add(this.eredmenyek);
            this.Controls.Add(this.bOldal);
            this.Controls.Add(this.aOldal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aOldal;
        private System.Windows.Forms.TextBox bOldal;
        private System.Windows.Forms.TextBox eredmenyek;
        private System.Windows.Forms.Button SzamolasGomb;
    }
}

