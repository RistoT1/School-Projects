using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painoindeksi_Ali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJatka_Click(object sender, EventArgs e)
        {
            double pituus, paino;
            try
            {
                paino = double.Parse(txtPaino.Text);
                pituus = double.Parse(txtPituus.Text);
                tulosta(paino,pituus);
            }
            catch (Exception)
            {
                MessageBox.Show("syötä luku");
            }
        }
        public static void tulosta(double paino, double pituus)
        {
            MessageBox.Show(((paino / Math.Pow(pituus, 2))*10000).ToString("F2"));
        }

    }
}
