using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FovarosokForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> orszagok = new List<string>();
        List<string> fovarosok = new List<string>();
        Random rnd = new Random();
        int veletlen = 0;
        bool betolt = true;
        int veletlen_2 = 0;
        Form Form2 = new Form();

        private void Form1_Load(object sender, EventArgs e)
        {
            orszagok.Add("Magyarország");
            fovarosok.Add("Budapest");
            orszagok.Add("Ausztria");
            fovarosok.Add("Bécs");
            orszagok.Add("Horvátország");
            fovarosok.Add("Zágráb");
            orszagok.Add("Csehország");
            fovarosok.Add("Prága");
            orszagok.Add("Szlovákia");
            fovarosok.Add("Pozsony");
            orszagok.Add("Románia");
            fovarosok.Add("Bukarest");

            veletlen = rnd.Next(orszagok.Count);
            label3.Text = orszagok[veletlen];
        }

        private void tippeloBtn_Click(object sender, EventArgs e)
        {
            string tippFovaros = textBox1.Text;
            if (tippFovaros == fovarosok[veletlen] && betolt)
            {
                MessageBox.Show("Ügyes vagy!", "Eredmény", MessageBoxButtons.OK);
                UjOrszagBtn.Visible = true;
                kilepesBtn.Visible = true;
                tippeloBtn.Enabled = false;
            }
            else if (tippFovaros == fovarosok[veletlen_2])
            {
                MessageBox.Show("Ügyes vagy!", "Eredmény", MessageBoxButtons.OK);
                UjOrszagBtn.Visible = true;
                kilepesBtn.Visible = true;
                tippeloBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Nem talált!", "Eredmény", MessageBoxButtons.OK);
                textBox1.Text = "";
            }
        }

        private void kilepesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UjOrszagBtn_Click(object sender, EventArgs e)
        {
            /*tippeloBtn.Enabled = true;
            kilepesBtn.Visible = false;
            UjOrszagBtn.Visible = false;

            veletlen_2 = rnd.Next(orszagok.Count);

            while (veletlen_2 == veletlen)
            {
                veletlen_2 = rnd.Next(orszagok.Count);
            }

            label3.Text = orszagok[veletlen_2];
            textBox1.Text = "";
            betolt = false;*/

            Form2.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            orszagok.Add("Magyarország");
            fovarosok.Add("Budapest");
            orszagok.Add("Ausztria");
            fovarosok.Add("Bécs");
            orszagok.Add("Horvátország");
            fovarosok.Add("Zágráb");
            orszagok.Add("Csehország");
            fovarosok.Add("Prága");
            orszagok.Add("Szlovákia");
            fovarosok.Add("Pozsony");
            orszagok.Add("Románia");
            fovarosok.Add("Bukarest");

            veletlen = rnd.Next(orszagok.Count);
            label1.Text = orszagok[veletlen];
        }
    }
}
