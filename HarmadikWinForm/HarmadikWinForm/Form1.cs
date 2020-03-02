using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmadikWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValasztoGomb_Click(object sender, EventArgs e)
        {
            string kimeno = "";
            foreach (var item in listBox1.SelectedItems)
            {
                //kimeno += item.ToString() + "\r\n";
                //listBox2.Items.Add(item);
                comboBox1.Items.Add(item);
            }
            textBox1.Text = kimeno;
        }

        private void HozzaadGomb_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            comboBox1.Items.Clear();
            //string valaszt = textBox3.Text;
            int hozzaad = Int32.Parse(textBox2.Text);
            int negyzetgyok = (int)Math.Floor(Math.Sqrt(hozzaad));
            for (int i = 1; i <= hozzaad; i++)
            {
                if (hozzaad % i == 0)
                {
                    listBox1.Items.Add(i);
                    /*if (i.ToString().Contains(valaszt))
                    {
                        comboBox1.Items.Add(i);
                    }*/
                    if (i <= negyzetgyok)
                    {
                        listBox2.Items.Add(i);
                    }
                    else
                    {
                        comboBox1.Items.Add(i);
                    }
                }  
            }
            if (comboBox1.Items.Count == listBox2.Items.Count)
            {
                textBox3.Text = "A szám nem négyzetszám.";
            }
            else
            {
                textBox3.Text = "A szám négyzetszám.";
            }
        }
    }
}
