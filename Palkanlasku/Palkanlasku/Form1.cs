using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palkanlasku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Laske_Click(object sender, EventArgs e)
        {
           
            double x, y, z, i, tulo = 0, tunnit = 0;

            

            try
            {
                x = Double.Parse(txtTunti.Text);      // Tuntipalkka
                y = Double.Parse(txtnorm.Text);                       // Normaali tuntipalkka
                z = Double.Parse(txtpuol.Text);                       // 50% korko tuntipalkka
                i = Double.Parse(txtsata.Text);                       // 100% korko Tuntipalkka

                tulo = (x * y + z * 1.5 + i * 2.0);                           //Laskee kokonaispalkan
                                                //Laskee Tunnit
                TunnitL.Text = tunnit.ToString();
                PalkkaL.Text = tulo.ToString() + "€";
            }
            catch (Exception)
            {

                MessageBox.Show("syötä Tuntipalkka!");
            }
            

        }
            
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
