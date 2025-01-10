using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painoindeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VastausL.ForeColor = Color.Black;
            VastausLU.ForeColor = Color.Black;
            try
            {   
                double paino, pituus, vastausV, vastausU;
                paino = double.Parse(txtPaino.Text);                            //parce käyttäjän tiedot.
                pituus = double.Parse(txtPituus.Text);

                vastausV = paino / (pituus * pituus) * 10000;                   //Vanha laskukaava
                vastausU = (1.3 * paino) / Math.Pow(pituus, 2.5) * 100000;       //Uusi laskukaava

                VastausL.Text = string.Format("{0:F2} ", vastausV);              //Vanha Print
                VastausLU.Text = string.Format("{0:F2} ", vastausU);             //Uusi Print

                if (vastausV < 17.9)                            //Määrittää teksti Bmi tuloksen mukaan
                {
                    indeksiL.Text = "alipaino";
                }
                else if (vastausV < 18.9 && vastausV > 17.9) 
                {
                    indeksiL.Text = "Lievä alipaino";
                }
                else if (vastausV > 24.9 && vastausV < 30)
                {
                    indeksiL.Text = "Lievä ylipaino";
                }
                else if (vastausV > 30)
                {
                    indeksiL.Text = "ylipaino";
                }
                else
                {
                    indeksiL.Text = "Normaalipaino";
                }


                if (vastausU < 17.9)                            //Määrittää teksti Bmi tuloksen mukaan
                {
                    indeksiLU.Text = "alipaino";
                }
                else if (vastausU < 18.9 && vastausU > 17.9)
                {
                    indeksiLU.Text = "Lievä alipaino";
                }
                else if (vastausU > 24.9 && vastausU < 30)
                {
                    indeksiLU.Text = "Lievä ylipaino";
                }
                else if (vastausU > 30)
                {
                    indeksiLU.Text = "ylipaino";
                }
                else
                {
                    indeksiLU.Text = "Normaalipaino";
                }

            }
            catch (Exception)                       // Jos parce epäonnistuu 
            {

                VastausL.Text = "Syötä numeroita";      // ilmoittaa käyttäjälle ongelman vanha kaavio
                indeksiL.Text = "---";
                VastausL.ForeColor = Color.Red;

                VastausLU.Text = "Syötä numeroita";        //Uusikaavio
                indeksiLU.Text = "---";
                VastausLU.ForeColor = Color.Red;
            }
            
        }
    }
}
