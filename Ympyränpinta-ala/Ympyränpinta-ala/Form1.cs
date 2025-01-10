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
            VastausL.ForeColor = Color.Black;

            try {
                double Sade, Vastaus;
                Sade = double.Parse(txtSade.Text);

                Vastaus = (Sade * Sade * Math.PI);

                VastausL.Text = string.Format("{0:F2}", Vastaus) + " cm";
                
            } 
            catch (Exception )
            {
                VastausL.Text = "Kirjoita numero";
                VastausL.ForeColor = Color.Red; 
            }
            
        }
    }
}
