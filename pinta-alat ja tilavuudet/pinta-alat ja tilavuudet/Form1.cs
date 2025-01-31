using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            if (!done) // ottaa kerran säteen ja säde tekstin sijainnin
            {
                locationresetL = sadeL.Location;
                locationreset = txtsade.Location;
                done = true;    // tehty
            }
            //alku arvo kaikki piilossa
            txtKorkeus.Visible = false; 
            KorkeusL.Visible = false;
            txtLeveys.Visible = false;
            LeveysL.Visible = false;
            txtsade.Visible = false;
            sadeL.Visible = false;

            // alku arvo  säteen sijainti nollattu
            txtsade.Location = locationreset;
            sadeL.Location = locationresetL;

            //alku arvo säteen teksti on säde (muuttuu tulevaisuudessa niin ei tarvitse useaa labelia)
            sadeL.Text = "Säde"; 
            switch (comboBox1.SelectedIndex)
            {   
                case 0:
                    //VAIN korkeus näkyviin
                    txtKorkeus.Visible = true;
                    KorkeusL.Visible = true;
                    break;

                case 1:
                    // säde tulee korkeuden sijaintiin jotta näyttää tyylikkäältä
                    txtsade.Location = txtKorkeus.Location;
                    sadeL.Location = KorkeusL.Location;
                    //säde näkyviin
                    txtsade.Visible = true;
                    sadeL.Visible = true;
                    break;

                case 2:
                    // korkeus ja säde näkyvissä
                    txtKorkeus.Visible = true;
                    KorkeusL.Visible = true;
                    txtsade.Visible = true;
                    sadeL.Visible = true;
                    break;
                case 3:
                    // säde tulee korkeuden sijaintiin jotta näyttää tyylikkäältä
                    txtsade.Location = txtKorkeus.Location;
                    sadeL.Location = KorkeusL.Location;
                    //säde näkyviin
                    txtsade.Visible = true;
                    sadeL.Visible = true;
                    break;

                case 4:
                    // säde tulee korkeuden sijaintiin jotta näyttää tyylikkäältä
                    txtsade.Location = txtKorkeus.Location;
                    sadeL.Location = KorkeusL.Location;
                    //säde näkyviin
                    txtsade.Visible = true;
                    sadeL.Visible = true;
                    break;

                case 5:
                    //korkeus näkyviin
                    txtKorkeus.Visible = true;
                    KorkeusL.Visible = true;
                    break;
                case 6:
                    // korkeus ja säde näkyvissä
                    txtsade.Visible = true;
                    sadeL.Visible = true;
                    txtKorkeus.Visible = true;
                    KorkeusL.Visible = true;
                    break;

                case 7:
                    // kaikki mäkyvissä
                    txtKorkeus.Visible = true;
                    KorkeusL.Visible = true;
                    txtLeveys.Visible = true;
                    LeveysL.Visible = true;
                    txtsade.Visible = true;
                    // muuttaa säteen tekstin pohjanpoituudeksi.
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
            double leveys, sade, korkeus,vastaus; // perus arvot
            int comboBoxIndex; // Valintalaatikon indeksi
            
            try
            {
                //lukujen määritys
                double.TryParse(txtKorkeus.Text,out korkeus);
                double.TryParse(txtsade.Text,out sade);
                double.TryParse(txtLeveys.Text,out leveys);
                //Combobox indexin määritys
                comboBoxIndex = comboBox1.SelectedIndex;
            

                Kaavat kaavat = new Kaavat(); // viittaus classiin kaavat 
                kaavat.K = korkeus; // classin perus arvojen viittaus  voisi myös tehdä klassiin viitatessa {K = korkeus yms}
                kaavat.S = sade;
                kaavat.L = leveys;
                //comboboxin indexin viittaus
                kaavat.ComboIndex = comboBoxIndex;
                // hakee vastaukset laske kaavasta
                vastaus = kaavat.laske();

                // jos indeksi ei ole -1 eli tyhjä.
                if (comboBox1.SelectedIndex != -1)
                {
                    // jos jokin teksti kentistä ei ole tyhjä
                    if (!string.IsNullOrEmpty(txtKorkeus.Text)
                        || !string.IsNullOrEmpty(txtsade.Text)
                        || !string.IsNullOrEmpty(txtsade.Text))
                    {
                        txtVastaus.Clear(); // tyhjentää txtvastauksen eli edellisen vastauksen
                        txtVastaus.Text = vastaus.ToString(); //printtaa txtvastauksen
                        //tyhjentää täyttökentät
                        txtKorkeus.Clear();
                        txtsade.Clear();
                        txtLeveys.Clear();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("syötä luku");
            }
        }
    }
    class Kaavat
    {
        private double l, s, k; //classin perus arvot
        private int comboIndex; // classin comboBoxindeksi
        public double laske() // lasku kaava muodoille
        {
            switch (comboIndex) //comboBoxin indeksin mukaan
            {
                case 0:
                    //Neliön pinta-ala
                    return Math.Pow(k, 2);
                case 1:
                    //Ympyrän pinta-ala
                    return Math.PI * Math.Pow(s, 2);
                case 2:
                    //Ympyrälieriön pinta-ala
                    return Math.PI * 2 * s * k + Math.PI * 2 * Math.Pow(s, 2);
                case 3:
                    //Pallon pinta-ala
                    return 4 * Math.PI * Math.Pow(s, 2);
                case 4:
                    return (4.0 / 3.0) * Math.PI * Math.Pow(s, 3);
                case 5:
                    return Math.PI * Math.Pow(s, 3);
                case 6:
                    return (1.0 / 3.0) * Math.PI * Math.Pow(s, 2) * k;
                case 7:
                    return (1.0 / 3.0) * s * l * k;
                default:
                    return comboIndex;
            }
        }
        //alku kaavat 
        public Kaavat()
        {
            l = 0; s = 0; k = 0;    
        }
        //levyden, säteen ja korkeuden määrittely;
        public double L {  get { return l; } set {  l = value; } }
        public double S { get { return s; } set { s = value; } }
        public double K { get { return k; } set { k = value; } }
        public int ComboIndex { get { return comboIndex; } set { comboIndex = value; } }

        
    }
}
