using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutokForm
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Auto> lista = new List<Auto>();

        private void felveszBtn_Click(object sender, EventArgs e)
        {
            string rendszam = maskedTextBox1.Text;
            maskedTextBox1.Clear();
            string marka = markaCB.SelectedItem.ToString();
            string tipus = textBox1.Text;
            textBox1.Text = "";
            int evjarat = (int)numericUpDown1.Value;
            string uzemanyag = comboBox1.SelectedItem.ToString();

            Auto auto = new Auto(rendszam, marka, tipus, evjarat, uzemanyag);
            lista.Add(auto);
        }

        private void listazBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in lista)
            {
                listBox1.Items.Add(item.Kiir());
            }
        }
    }
}
