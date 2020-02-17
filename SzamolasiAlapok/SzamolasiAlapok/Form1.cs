using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzamolasiAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SzamolasGomb_Click(object sender, EventArgs e)
        {
            double aOldalHossz = Double.Parse(aOldal.Text);
            double bOldalHossz = Double.Parse(bOldal.Text);

            double c = Math.Sqrt(Math.Pow(aOldalHossz, 2) + Math.Pow(bOldalHossz, 2));

            double kerulet = aOldalHossz + bOldalHossz + c;
            double terulet = aOldalHossz * bOldalHossz / 2;

            string kiiras = $"C-oldal {c:F2}\nKerület: {kerulet:F2}\nTerület: {terulet:F2}";
            eredmenyek.Text = kiiras;
        }
    }
}
