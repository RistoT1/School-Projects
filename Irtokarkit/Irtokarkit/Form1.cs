using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irtokarkit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Laske_Click(object sender, EventArgs e)
        {
            karkkimääräL.ForeColor = Color.Black;
            karkkimääräkL.ForeColor = Color.Black;
            try
            {
                double kilo, raha, karkki, gkarkki;
                kilo = double.Parse(txtKilo.Text);
                raha = double.Parse(txtRaha.Text);

                karkki = raha / kilo;
                gkarkki = karkki * 1000;

                karkkimääräL.Text = string.Format("{0:F2} kg", karkki);
                karkkimääräkL.Text = string.Format("{0:F0} g", gkarkki);

            }
            catch (Exception)
            {

                karkkimääräL.Text = "anna kaksi lukua";
                karkkimääräL.ForeColor = Color.Red;

                karkkimääräkL.Text = "tarkista pilkku merkintä";
                karkkimääräkL.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
