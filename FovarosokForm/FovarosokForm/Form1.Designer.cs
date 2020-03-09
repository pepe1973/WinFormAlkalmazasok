namespace FovarosokForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tippeloBtn = new System.Windows.Forms.Button();
            this.UjOrszagBtn = new System.Windows.Forms.Button();
            this.kilepesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ország neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Főváros tipped:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // tippeloBtn
            // 
            this.tippeloBtn.Location = new System.Drawing.Point(436, 76);
            this.tippeloBtn.Name = "tippeloBtn";
            this.tippeloBtn.Size = new System.Drawing.Size(75, 23);
            this.tippeloBtn.TabIndex = 4;
            this.tippeloBtn.Text = "Tippelő";
            this.tippeloBtn.UseVisualStyleBackColor = true;
            this.tippeloBtn.Click += new System.EventHandler(this.tippeloBtn_Click);
            // 
            // UjOrszagBtn
            // 
            this.UjOrszagBtn.Location = new System.Drawing.Point(436, 159);
            this.UjOrszagBtn.Name = "UjOrszagBtn";
            this.UjOrszagBtn.Size = new System.Drawing.Size(75, 23);
            this.UjOrszagBtn.TabIndex = 5;
            this.UjOrszagBtn.Text = "Új ország";
            this.UjOrszagBtn.UseVisualStyleBackColor = true;
            this.UjOrszagBtn.Visible = false;
            this.UjOrszagBtn.Click += new System.EventHandler(this.UjOrszagBtn_Click);
            // 
            // kilepesBtn
            // 
            this.kilepesBtn.Location = new System.Drawing.Point(436, 242);
            this.kilepesBtn.Name = "kilepesBtn";
            this.kilepesBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepesBtn.TabIndex = 6;
            this.kilepesBtn.Text = "Kilépés";
            this.kilepesBtn.UseVisualStyleBackColor = true;
            this.kilepesBtn.Visible = false;
            this.kilepesBtn.Click += new System.EventHandler(this.kilepesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 512);
            this.Controls.Add(this.kilepesBtn);
            this.Controls.Add(this.UjOrszagBtn);
            this.Controls.Add(this.tippeloBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button tippeloBtn;
        private System.Windows.Forms.Button UjOrszagBtn;
        private System.Windows.Forms.Button kilepesBtn;
    }
}

