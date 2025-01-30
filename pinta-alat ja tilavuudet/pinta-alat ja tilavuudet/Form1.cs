using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pinta_alat_ja_tilavuudet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        Point locationresetL;
        Point locationreset;
        bool done = false;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!done)
            {
                locationresetL = sadeL.Location;
                locationreset = txtsade.Location;
                done = true;
            }
            txtKorkeus.Visible = false;
            KorkeusL.Visible = false;
            txtLeveys.Visible = false;
            LeveysL.Visible = false;
            txtsade.Visible = false;
            sadeL.Visible = false;

            txtsade.Location = locationreset;
            sadeL.Location = locationresetL;

            sadeL.Text = "Säde";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    txtKorkeus.Visible = true;
                    KorkeusL.Visible = true;
                    break;

                case 1:
                    txtsade.Location = txtKorkeus.Location;
                    sadeL.Location = KorkeusL.Location;
                    txtsade.Visible = true;
                    sadeL.Visible = true;
                    break;

                case 2:
                    txtKorkeus.Visible = true;
                    KorkeusL.Visible = true;
                    txtsade.Visible = true;
                    sadeL.Visible = true;
                    break;
                case 3:
                    txtsade.Location = txtKorkeus.Location;
                    sadeL.Location = KorkeusL.Location;
                    txtsade.Visible = true;
                    sadeL.Visible = true;
                    break;

                case 4:
                    txtsade.Location = txtKorkeus.Location;
                    sadeL.Location = KorkeusL.Location;
                    txtsade.Visible = true;
                    sadeL.Visible = true;
                    break;

                case 5:
                    txtKorkeus.Visible = true;
                    KorkeusL.Visible = true;
                    break;
                case 6:
                    txtsade.Visible = true;
                    sadeL.Visible = true;
                    txtKorkeus.Visible = true;
                    KorkeusL.Visible = true;
                    break;

                case 7:
                    txtKorkeus.Visible = true;
                    KorkeusL.Visible = true;
                    txtLeveys.Visible = true;
                    LeveysL.Visible = true;
                    txtsade.Visible = true;
                    sadeL.Text = "pohjan pituus";
                    sadeL.Visible = true;
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnJatka_Click(object sender, EventArgs e)
        {
            double leveys, sade, korkeus;
            
            try
            {
                
                double.TryParse(txtKorkeus.Text,out korkeus);
                double.TryParse(txtsade.Text,out sade);
                double.TryParse(txtLeveys.Text,out leveys);
                laske(leveys, sade, korkeus);
            }
            catch (Exception)
            {
                MessageBox.Show("syötä luku");
            }
        }
        public void laske (double leveys, double sade, double korkeus)
        {
            double vastaus = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //Neliön pinta-ala
                    vastaus = Math.Pow(korkeus,2);
                    break;
                case 1:
                    //Ympyrän pinta-ala
                    vastaus = Math.PI * Math.Pow(sade,2);
                    break;

                case 2:
                    //Ympyrälieriön pinta-ala
                    vastaus = Math.PI * 2 * sade * korkeus + Math.PI * 2 * Math.Pow(sade, 2);
                    break;
                case 3:
                    //Pallon pinta-ala
                    vastaus = 4 * Math.PI * Math.Pow(sade,2);
                    break;
                case 4:
                    vastaus = (4.0 / 3.0) * Math.PI * Math.Pow(sade, 3);
                    break;
                case 5:
                    vastaus = Math.PI * Math.Pow(sade, 3);
                    break;
                case 6:
                    vastaus = (1.0 / 3.0) * Math.PI * Math.Pow(sade, 2) * korkeus;
                    break;

                case 7:
                    vastaus = (1.0 / 3.0) * sade * leveys * korkeus;
                    break;
            }
            if (comboBox1.SelectedIndex != -1 )
            {
                
                if (!string.IsNullOrEmpty(txtKorkeus.Text)
                    || !string.IsNullOrEmpty(txtsade.Text)
                    || !string.IsNullOrEmpty(txtsade.Text))
                {
                    txtVastaus.Clear();
                    txtVastaus.Text = vastaus.ToString();
                    txtKorkeus.Clear();
                    txtsade.Clear();
                    txtLeveys.Clear();
                    
                }
                
            }
   
        }
    }
}
