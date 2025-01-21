using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaollisuus_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLaske_Click(object sender, EventArgs e)
        {
            int luku,lukualku;
            int jaettu = 0;
            int jakaja = 3;
            try
            {
                luku = int.Parse(txtLuku.Text); //parsetus
                lukualku = luku;                //ottaa luvun eri muuttujaan tulevaisuutta varten
                
                if (lukualku >= jakaja)         // jos luku on suurempi tai yhtäsuuri kuin jakaja
                {   
                    while (luku >= jakaja)      // looppaa kun totta ja joka looppauksessa lisää kierroksen ja vähentää luvusta jakajan 
                    {
                        jaettu += 1;
                        luku -= jakaja;
                    }
                    if (luku == 0) // eri vastaukset 
                    {
                        MessageBox.Show($"luku {lukualku} on jaollinen {jaettu} kertaa.");
                    }
                    else
                    {
                        MessageBox.Show($"luku {lukualku} on jaollinen {jaettu} kertaa ja jäljelle jäi {luku}.");
                    }
                }
                else
                {
                    MessageBox.Show($"luku {lukualku} ei ole jaollinen luvulla {jakaja}");
                }
                
            }
            catch (Exception) //error 
            {
                MessageBox.Show("Syötä luku");
            }
            


        }
    }
}
