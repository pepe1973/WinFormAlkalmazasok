using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElsoWinForm
{
    public partial class MacskasUrlap : Form
    {
        public string belepoSzoveg = "Macskás űrlap";
        public MacskasUrlap()
        {
            InitializeComponent();
        }

        private void ModositoGomb_Click(object sender, EventArgs e)
        {
            /*string modositandoSzoveg = BeviteliMezo.Text;
            KimenoSzoveg.Text = modositandoSzoveg.ToUpper();*/
            //this.Close();
            //MessageBox.Show("Éljen a 13SZF", "Ez egy üdvözlő üzenet", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            /*if (EltuntetGomb.Visible)
            {
                EltuntetGomb.Visible = false;
            }
            else
            {
                EltuntetGomb.Visible = true;
            }*/
            EltuntetGomb.Visible = !EltuntetGomb.Visible;
        }

        private void MacskasUrlap_MouseEnter(object sender, EventArgs e)
        {
            this.Text = "Belépett";
        }

        private void MacskasUrlap_MouseLeave(object sender, EventArgs e)
        {
            this.Text = belepoSzoveg;
        }

        private void MacskasUrlap_Load(object sender, EventArgs e)
        {
            this.Text = belepoSzoveg.ToUpper();
        }

        private void MacskasUrlap_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Mozgás";
        }

        private void BeviteliMezo_TextChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int szam = rnd.Next(5);
            switch (szam)
            {
                case 0:
                    {
                        this.BackColor = Color.Blue;
                        break;
                    }
                case 1:
                    {
                        this.BackColor = Color.Beige;
                        break;
                    }
                case 2:
                    {
                        this.BackColor = Color.Brown;
                        break;
                    }
                case 3:
                    {
                        this.BackColor = Color.BlueViolet;
                        break;
                    }
                case 4:
                    {
                        this.BackColor = Color.Chocolate;
                        break;
                    }
            }
            
        }

        private void ModositoGomb_MouseEnter(object sender, EventArgs e)
        {
            //ModositoGomb.Visible = false;
        }

        private void ModositoGomb_MouseLeave(object sender, EventArgs e)
        {
            //ModositoGomb.Visible = true;
        }

        private void EltuntetGomb_Click(object sender, EventArgs e)
        {
            if (ModositoGomb.Enabled)
            {
                ModositoGomb.Enabled = false;
            }
            else
            {
                ModositoGomb.Enabled = true;
            }
            //ModositoGomb.Enabled = !ModositoGomb.Enabled;
        }

        private void BezarGomb_Click(object sender, EventArgs e)
        {
            BezarGomb.Location = new Point(0, 0);
        }

        private void BezarGomb_MouseEnter(object sender, EventArgs e)
        {
            int szelesseg = this.Size.Width - BezarGomb.Width -10;
            int magassag = this.Size.Height - BezarGomb.Height - 10;

            Random rnd = new Random();

            int x = rnd.Next(szelesseg);
            int y = rnd.Next(magassag);
            BezarGomb.Location = new Point(x, y);
        }
    }
}
