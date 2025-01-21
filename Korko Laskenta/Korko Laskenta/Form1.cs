using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korko_Laskenta
{
    public partial class Form1 : Form
    {   
        //txtName = textbox
        //NameL = Label
        //btnName = Button

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLaske_Click(object sender, EventArgs e)
        {
            double paaoma, aika, korko, vastaus;
            Vastaus1L.ForeColor = Color.Black;
            try
            {
                paaoma = double.Parse(txtpaaoma.Text);
                aika = double.Parse(txtAika.Text);
                korko = double.Parse(txtKorko.Text);

                vastaus = korko*paaoma*aika / 100 /360;
                Vastaus1L.Text = vastaus.ToString("F2") + "€";
                Vastaus2L.Text = (vastaus + paaoma).ToString("F2") + "€";
            }
            catch (Exception)
            {

                Vastaus1L.Text = "Anna lukuina";
                Vastaus1L.ForeColor = Color.Red;
                Vastaus2L.Text = "---";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
