using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Luku_yksi_vastaus
{
    public partial class Form1 : Form
    {
        double luku1, luku2;
        public Form1()
        {
            InitializeComponent();
            

            
        }

        private void btnSuurempi_Click(object sender, EventArgs e)
        {
            try
            {
                luku1 = double.Parse(textBox1.Text);
                luku2 = double.Parse(textBox2.Text);

                if (luku1 < luku2)
                {
                    VastausL.Text = "luku " + luku2.ToString() + " on suurempi";
                }
                else if (luku1 == luku2)
                {
                    VastausL.Text = "luvut ovat yhtä suuret. Annettu luku:" + luku1.ToString();
                }
                else
                {
                    VastausL.Text = "luku " + luku1.ToString() + " on suurempi";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Syötä Numeroita");
            }
        }

        private void btnPienempi_Click(object sender, EventArgs e)
        {
            try
            {
                luku1 = double.Parse(textBox1.Text);
                luku2 = double.Parse(textBox2.Text);

                if (luku1 > luku2)
                {
                    VastausL.Text = "luku " + luku2.ToString() + " on pienempi";
                }
                else if (luku1 == luku2)
                {
                    VastausL.Text = "luvut ovat yhtä suuret. Annettu luku:" + luku1.ToString();
                }
                else
                {
                    VastausL.Text = "luku " + luku1.ToString() + " on pienempi";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Syötä Numeroita");
            }
        }
    }
}
