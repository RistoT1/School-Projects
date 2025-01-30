using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etäisyydet_funktiot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJatka_Click(object sender, EventArgs e)
        {
            txtVastaus.Clear();
            double luku = 0;
            int muunnos = 0;
            double vastaus = 0;
            try
            {
                luku = double.Parse(textBox1.Text);
                muunnos = (int)comboBox1.SelectedIndex;
                laske(luku, muunnos,vastaus);
            }
            catch (Exception)
            {
                MessageBox.Show("syötä luku");
            }
        }
        public void laske(double luku, int muunnos,double vastaus)
        {
            switch (muunnos)
            {
                case 0:
                    vastaus = luku * 100;
                    break;
                case 1:
                    vastaus = luku * 10;
                    break;
                case 2:
                    vastaus = luku / 1000;
                    break;
                case 3:
                    vastaus = luku * 39.37;
                    break;
                case 4:
                    vastaus = luku * 3.28084;
                    break;
                case 5:
                    vastaus = luku * 0.9144;
                    break;       
            }
            if (muunnos != -1)
            {
                txtVastaus.Text += $"{vastaus} {comboBox1.Text}{Environment.NewLine}";
            }
            else
            {
                txtVastaus.Text = "valitse muutettava arvo";
            }
           
        }
    }
}
