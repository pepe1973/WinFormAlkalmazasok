using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elemszamNUD.Maximum = topmoziLB.Items.Count;
        }

        private void felveszBtn_Click(object sender, EventArgs e)
        {
            if (szovegTxt.Text != "" && evText.Text != "")
            {
                string bevitel = $"{szovegTxt.Text} ({evText.Text})";
                topmoziLB.Items.Add(bevitel);
                elemszamNUD.Maximum = topmoziLB.Items.Count;
                szovegTxt.Text = "";
                evText.Text = "";
            }
            else if(szovegTxt.Text == "" && evText.Text == "")
            {
                MessageBox.Show("Mindkét beviteli mező üres!",
                    "Beviteli mező üres", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (szovegTxt.Text == "" && evText.Text != "")
            {
                MessageBox.Show("Szövegbeviteli mező üres!",
                    "Beviteli mező üres", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (szovegTxt.Text != "" && evText.Text == "")
            {
                MessageBox.Show("Évbeviteli mező üres!",
                    "Beviteli mező üres", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void beszurBtn_Click(object sender, EventArgs e)
        {
            if (szovegTxt.Text != "" && evText.Text != "" && (int)elemszamNUD.Value != 0)
            {
                string bevitel = $"{szovegTxt.Text} ({evText.Text})";
                topmoziLB.Items.Insert((int)elemszamNUD.Value - 1,
                    bevitel);
                elemszamNUD.Maximum = topmoziLB.Items.Count;
                szovegTxt.Text = "";
                evText.Text = "";
            }
        }

        private void torolBtn_Click(object sender, EventArgs e)
        {
            if (topmoziLB.SelectedIndex != -1)
            {
                topmoziLB.Items.RemoveAt(topmoziLB.SelectedIndex);
                elemszamNUD.Maximum = topmoziLB.Items.Count;
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!",
                    "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void torolMindBtn_Click(object sender, EventArgs e)
        {
            topmoziLB.Items.Clear();
            elemszamNUD.Maximum = topmoziLB.Items.Count;
        }

        private void atmasolBtn_Click(object sender, EventArgs e)
        {
            if (topmoziLB.SelectedIndex != -1)
            {
                if (moziLatottLB.Items.Contains(topmoziLB.SelectedItem))
                {
                    MessageBox.Show("Már van ilyen elem!",
                    "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    moziLatottLB.Items.Add(topmoziLB.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!",
                    "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void atmozgatBtn_Click(object sender, EventArgs e)
        {
            if (topmoziLB.SelectedIndex != -1)
            {
                moziLatottLB.Items.Add(topmoziLB.SelectedItem);
                topmoziLB.Items.RemoveAt(topmoziLB.SelectedIndex);
                elemszamNUD.Maximum = topmoziLB.Items.Count;
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!",
                    "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void keresBtn_Click(object sender, EventArgs e)
        {
            if (szovegTxt.Text != "")
            {
                int index = topmoziLB.FindString(szovegTxt.Text);
                if (index != -1)
                {
                    topmoziLB.SetSelected(index, true);
                }
            }
        }
    }
}
