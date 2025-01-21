using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nopan_heitto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            Random random = new Random();                       // randomi
            txtVastaus1.Text = "Noppa1" + Environment.NewLine;  //toimii clear toimintona alussa
            txtVastaus2.Text = "Noppa2" + Environment.NewLine; 
            txtSumma.Clear();               

            int noppa1, noppa2;                                 //arvot
            //int heitto määrä = 5;
            int summa = 0;
            int summaN1 = 0;                    
            int summaN2 = 0;

            for (int i = 0; i < 5; i++)                         //looppaa heittomäärän verran
            {
                noppa1 = random.Next(1,7);                      //generoi luvulle randomin
                noppa2 = random.Next(1,7);                      
                summaN1 += noppa1;                              //laskee yhteen noppien heitto luvut lisää joka loopilla
                summaN2 += noppa2;

                txtVastaus1.Text += noppa1.ToString() + Environment.NewLine;        //kirjoittaa luvut textboxiin
                txtVastaus2.Text += noppa2.ToString() + Environment.NewLine;
            }
            summa += summaN1 + summaN2; //laskee kokonais summan ja lisää muut summat
            txtVastaus1.Text += "summa: " + summaN1;
            txtVastaus2.Text += "summa: " + summaN2;
            txtSumma.Text += Environment.NewLine + "summa: " + summa.ToString();
            
        }
    }
}
