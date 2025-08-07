using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keskiarvo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Laske_Click(object sender, EventArgs e)
        {
            Vastaus.ForeColor = Color.Black;
            try
            {
                double luku1, luku2, luku3, tulo;
                luku1 = double.Parse(txtLuku1.Text);
                luku2 = double.Parse(txtLuku2.Text);
                luku3 = double.Parse(txtLuku3.Text);

                tulo = (luku1 + luku2 + luku3) / 3;
                Vastaus.Text = tulo.ToString();
            }
            catch (Exception)
            {

                Vastaus.Text = "Syötä kolme lukua";
                Vastaus.ForeColor = Color.Red;
            }
             

            





        }
    }
}
