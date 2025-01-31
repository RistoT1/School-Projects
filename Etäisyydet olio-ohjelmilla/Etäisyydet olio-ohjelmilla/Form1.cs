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

namespace Etäisyydet_olio_ohjelmilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJatka_Click(object sender, EventArgs e)
        {
            txtVastaus.Clear(); // tyhjentää vastaus kentän
            int muunnos;        // Comboboxin valinta arvo
            double luku;        // käyttäjän syöte
            double vastaus;     // vastaus laskun jälkeen
            string comboBoxText = comboBox1.Text;   //comboboxin teksti printtiin
            try
            {
                luku = double.Parse(txtArvo.Text);  // parsetus
                muunnos = (int)comboBox1.SelectedIndex; //comboboxin valinta indeksi

                Kaavat kaavat = new Kaavat();       // viittaus classiin
                kaavat.l = luku;                    // luvun asetus
                kaavat.m = muunnos;                 // comboBoxin valinta syöteen asetus
                vastaus = kaavat.Laske();           // viittaus lasku toimintoon
                if (muunnos != -1)                  // indeksi ei ole oletus eli tyhjä
                {
                    txtVastaus.Text = $"{vastaus} {comboBoxText}{Environment.NewLine}"; // printtaa textin vastaukset
                }
            }
            catch (Exception) //virhe
            {
                MessageBox.Show("syötä luku");
            }
        }
    }
    class Kaavat //kaavat class
    {
        private double L; // luku
        private int M; //muunnos

        public double Laske() //laske vastaus
        {
            switch (M)
            {
                case 0:
                    return L * 100;
                case 1:
                    return L * 10;
                case 2:
                    return L / 1000;
                case 3:
                    return L * 39.37;
                case 4:
                    return L * 3.28084;
                case 5:
                    return L * 0.9144;
                default:
                    return M;
            }
        }
        public Kaavat() // resetti
        {
            L = 0;
            M = 0;
        }
        public double l //Luku
        { get 
            { 
                return L; 
            } 
            set 
            { 
                L = value; 
            } 
        }
        public int m //muunnos eli combobox indeksi
        {
            get
            {
                return M;
            }

            set
            {
                M = value;
            }
        }

    }
}
