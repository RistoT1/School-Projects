using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottopeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int pelatut = 0;

        private void btnpelaa_Click(object sender, EventArgs e)
        {
            double raha;
            int numerot;

            List<int> rivit = new List<int>();              // list rivin numeroista
            try
            {
                raha = double.Parse(txtRaha.Text);

                foreach (Control c in this.Controls)        //Etsii kaikki formin control itemit
                { 
                    if (c is CheckBox checkBox && checkBox.Checked)         //jos checkbocx ja checkattu 
                    {
                        int.TryParse(checkBox.Text, out numerot);           // Parse  numeroihin
                       
                        rivit.Add(numerot);                                 // lisää numerot list
                        rivit.Sort();                                       // järjestää numerot  
                        

                        

                    }
                }
                if (rivit.Count == 7 && raha >= 2)              //jos rahaa on ja numeroita tasan 7
                {
                    txtVastaus.Text += string.Join(" ", rivit) + Environment.NewLine;   // Listasta numerot ja new line
                    pelatut += 1;                                                       // lisää pelattuun yhden
                    txtPelatut.Text = pelatut.ToString();                               
                    raha -= 2;                                                          //raha järjestelmä
                    txtRaha.Text = raha.ToString(); 

                }               
                else if ( raha < 2 )                                                    //liian vähän rahea :d
                {
                    MessageBox.Show("rahaa liian vähä");
                }
                else if (rivit.Count < 7)                                               //liian vähän numeroita  
                {
                    MessageBox.Show("numeroita liian vähän");
                }
                else                                                                  // Liikaa numeroita
                {
                    MessageBox.Show("numeroita liikaa");
                }
                
               
            }
            catch (Exception)                                           // raha kohta tyhjä..
            {

                MessageBox.Show("syötä rahaa");
            }           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnNollaa_Click(object sender, EventArgs e)        //nollaus
        {
            txtRaha.Text = "0";                     
            pelatut = 0;
            txtPelatut.Text = pelatut.ToString();
            txtVastaus.Text = " ";

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox checkBox)             // etsii arvolla check boxit
                {
                    checkBox.Checked = false;           //checkBox checked arvo false
                }
            }
        }
    }
}
