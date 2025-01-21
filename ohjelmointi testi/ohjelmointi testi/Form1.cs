using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohjelmointi_testi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJatka_Click(object sender, EventArgs e)
        {
            try
            {
                int raha, pitsa, kokis;
                raha = int.Parse(txtRahamaara.Text);
                pitsa = 9;
                kokis = 3;
                if (raha >= pitsa && raha < pitsa+kokis)
                {
                    MessageBox.Show($"Mene kavereiden kanssa pizzalle! {Environment.NewLine}Sinulla on varaa pitsaan ja sinulle jää ylimääräiseksi {raha-pitsa}€");
                }
                else if (raha >= pitsa+kokis) 
                {
                    MessageBox.Show($"Mene kavereiden kanssa pizzalle! {Environment.NewLine}Sinulla on varaa pitsaan sekä kokikseen ja sinulle jää ylimääräiseksi {raha - pitsa - kokis}€");
                }
                else if (raha >= kokis && raha < pitsa) 
                {
                    MessageBox.Show($"Mene kavereiden kanssa pizzalle,mutta sinulla on varaa vain kokikseen ja sinulle jää ylimääräiseksi {raha - kokis}€");
                }                 
                else 
                {
                    MessageBox.Show($"Jää kotiin ja yritä säästää.{Environment.NewLine}Rahaa puuttuu {pitsa-raha}€");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("syötä luku");
            }
        }
    }
}
