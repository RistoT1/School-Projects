using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luku_suurempi_vai_pienempi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Laske_Click(object sender, EventArgs e)
        {
            try
            {
                double luku;

                luku = double.Parse(txtLuku.Text);

                if (luku > 0)
                {
                    VastausL.Text = "luku on suurempi kuin 0";
                }
                else if (luku <= 0)
                {
                    VastausL.Text = "luku on 0 tai pienempi";
                }
             
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
            

           
        }
    }
}
