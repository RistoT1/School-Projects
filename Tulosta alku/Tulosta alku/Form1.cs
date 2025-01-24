using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tulosta_alku
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
                txtVastaus.Clear();                             //  tyhjentää vastaus kentän 
                string sana = txtSyote.Text;                    //  syöte sana
                char[] kirjaimet = sana.ToCharArray();          //  tekee sanasta yksikirjaimisen listan eli char lista
                int maara = (int)numericUpDown1.Value;          //  numero eli tulostettavien kirjaimien määrä
                if (maara > kirjaimet.Length)                   //  jos kirjaimien määrä on suurempi kuin sana pituus tekee virheilmoituksen mutta tulostaa sen sanan 
                {
                    maara = kirjaimet.Length;
                    MessageBox.Show("numero ei saa olla suurempi kuin sana");
                }
                else if (maara <= 0)    // jos alle nolla tai nolla tekee virhe ilmoituksen
                {
                    MessageBox.Show("syötä lukumäärä kirjaimista mikä on suurempi kuin 0");
                }

                for (int i = 0; i < maara; i++)     // niin kauan kun i on pienempio kuin haluttu kirjain määrä kone tulostaa kirjaimia char listasta
                {
                    txtVastaus.Text += kirjaimet[i].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ongelma ilmeni");
            }
            

            

        }
    }
}
