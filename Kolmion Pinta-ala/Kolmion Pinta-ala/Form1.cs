using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolmion_Pinta_ala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Laske_Click(object sender, EventArgs e)
        {
            

            VastausL.ForeColor = Color.Black;

            try
            {
                double kanta, korkeus, Vastaus;
                kanta = double.Parse(txtKanta.Text);
                korkeus = double.Parse(txtKorkeus.Text);

                Vastaus = kanta * korkeus / 2;
                VastausL.Text = Vastaus.ToString();
            }
            catch (Exception)
            {

                VastausL.Text = "Anna 2 lukua";
                VastausL.ForeColor = Color.Red;
            }
        }
    }
}
