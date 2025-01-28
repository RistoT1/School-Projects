using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mäkihyppy_teht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Jatka_Click(object sender, EventArgs e)
        {
            //listat
            List<double> TuomariPisteet = new List<double>(); // Lista Tuomarien antamista pisteistä

            //perusarvot
            double Kpiste = 0; // Kpiste
            double hypynPituus = 0; //hypyn pituus
            
            
            //tuomarien luvut eri muodoissa
            double TuomariParsed;   // tuomarin luku kun parsetettu
            double RoundedTuomari;  // pyötistetty tuomarin pisteet 0,5

            //pisteet
            double KokonaisPisteet = 0; //Kokonaispisteet
            double tyyliPisteet = 0;    // tuomarien antamat pisteet
            double hypynPituuspisteet = 0; // hypyn pituudesta saadut pisteet

            try
            {
                Kpiste = int.Parse(txtKpiste.Text); // parsettaa K pisteen
            }
            catch (Exception)
            {
                MessageBox.Show("syötä luku K-pisteeseen"); //virhe ilmotus
            }

            for (int rivi = 0; rivi < dataGridView1.RowCount; rivi++)   //joka rivin lukeminen
            {
                KokonaisPisteet = 0;            // nollaus
                tyyliPisteet = 0;               
                hypynPituuspisteet = 0;         
                TuomariPisteet.Clear();
                for (int solu = 2; solu <= 6; solu++) //joka tuomari solun lukeminen
                {
                    //jos tuomari solu ei ole tyhjä ja parsettaa
                    if(dataGridView1.Rows[rivi].Cells[solu].Value != null && double.TryParse(dataGridView1.Rows[rivi].Cells[solu].Value.ToString(),out TuomariParsed)) 
                    {
                        RoundedTuomari = Math.Round(TuomariParsed * 2, 0, MidpointRounding.AwayFromZero) / 2; // pyöristää luvun lähimpään 0,5
                        TuomariPisteet.Add(RoundedTuomari); // lisää pyöristetyn tuomari luvun pisteisiin
                    }    
                }
                //jos tuomari solu ei ole tyhjä ja parsettaa
                if (dataGridView1.Rows[rivi].Cells[1].Value != null && double.TryParse(dataGridView1.Rows[rivi].Cells[1].Value.ToString(), out hypynPituus)) 
                {    
                        if (hypynPituus >= Kpiste) //jos hypyn pituus on pitempi kuin K-piste, lisää hypynpituus pisteisiin 60 + yli metrit * 1,8 
                        {
                            hypynPituuspisteet = 60 + ((hypynPituus - Kpiste) * 1.8);
                        }
                        else if (hypynPituus < Kpiste) // jos alle K-pisteen vähentää 60 pisteestä vajaat metrit.
                        {
                            hypynPituus = 60 - (Kpiste - hypynPituus) * 1.8;
                        }     
                }

                if (TuomariPisteet.Count >= 3)  // jos tuomareita on 3 tai yli niin suorittaa laskennan
                {
                    TuomariPisteet.Remove(TuomariPisteet.Max());    //poistaa Max
                    TuomariPisteet.Remove(TuomariPisteet.Min());    //poistaa Min
                    tyyliPisteet = TuomariPisteet.Sum();            // laskee yhteen summan
                }
                else if (dataGridView1.Rows[rivi].Cells[0].Value != null && TuomariPisteet.Count < 3)   // jos alle 3 tuomari ilmoittaa virhe ilmoituksen
                {
                    MessageBox.Show("tarvitaan vähintään 3 tuomaria");
                    break;
                }
                KokonaisPisteet = tyyliPisteet + hypynPituuspisteet; // laskee tuomari ja hyppypisteet yhteen

                dataGridView1.Rows[rivi].Cells[7].Value = hypynPituuspisteet.ToString();    //hypynpituus pisteet
                dataGridView1.Rows[rivi].Cells[8].Value = tyyliPisteet.ToString();          //Tuomarin pisteet
                dataGridView1.Rows[rivi].Cells[9].Value = KokonaisPisteet.ToString();       //Kokonaispisteet pisteet
                Console.WriteLine(Kpiste.ToString()+" " + hypynPituus.ToString()+" "  + hypynPituuspisteet.ToString()); // debugging printtaa piste arvot
            }  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
