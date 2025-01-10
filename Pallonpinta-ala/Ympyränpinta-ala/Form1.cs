using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ympyränpinta_ala
{
    public partial class Ympyrälaskuri : Form
    {
        public Ympyrälaskuri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VastausPL.ForeColor = Color.Black;

            try {
                double Sade, PVastaus, TVastaus;
                Sade = double.Parse(txtSade.Text);

                PVastaus = 4 * Math.PI * Math.Pow(Sade, 2);
                TVastaus = (4 * Math.PI * Math.Pow(Sade, 3)) / 3;

                VastausPL.Text = "Pinta-ala " + string.Format("{0:F2}", PVastaus);
                VastausTL.Text = "Tilavuus " + string.Format("{0:F2}", TVastaus);



            } 
            catch (Exception )
            {
                VastausPL.Text = "Kirjoita numero";
                VastausPL.ForeColor = Color.Red;

                VastausTL.Text = "---";
                

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ymbyrä :D");
        }
    }
}
