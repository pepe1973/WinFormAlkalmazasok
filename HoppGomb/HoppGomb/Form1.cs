using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoppGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int elsoKoor = Int32.Parse(textBox1.Text);
            int masodikKoor = Int32.Parse(textBox2.Text);

            if (elsoKoor >= 0 && elsoKoor < this.Size.Width - button1.Width - 10 &&
                masodikKoor >= 0 && masodikKoor < this.Size.Height - button1.Height - 10) 
            {
                label3.Visible = false;
                button1.Location = new Point(elsoKoor, masodikKoor);
            }
            else
            {
                label3.Visible = true;
            }
        }
    }
}
