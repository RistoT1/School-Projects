using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Kartoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtKorkeus.TextChanged += new EventHandler(Vastaus_Laske);      //jos teksti muuttuu. Aktivoi Vastaus_Laske. 
            txtSade.TextChanged += new EventHandler(Vastaus_Laske);         // jos teksti muuttuu. Aktivoi Vastaus_Laske.   
        }
        
        private void Vastaus_Laske(object sender, EventArgs e)
        {
            double sade, korkeus,pohja, Vastaus;
            try 
            {
                sade = double.Parse(txtSade.Text);              //PARCE
                korkeus = double.Parse(txtKorkeus.Text);
                pohja = Math.PI * Math.Pow(sade, 2) ;           //LASKEE PINTA-ALAN SÄTEESTÄ
                Vastaus = 1.0 / 3 * pohja * korkeus;            //Laskee tilavuuden
                VastausL.Text =  Vastaus.ToString("F2");        //F2 vastaus kahdella desimaalilla 0.00            
            }
            catch (Exception)
            {
                return;                                         // return
            }    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Vastaus_Click(object sender, EventArgs e)
        {

        }

        private void Jatka_Click(object sender, EventArgs e)
        {
            
        }
    }
}
