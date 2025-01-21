using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuukaudet_switch_rakenteella
{
    public partial class Form1 : Form
    {
        private int i =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btbJatka_Click(object sender, EventArgs e)
        {
            List<string> kuukaudet = new List<string>() { "Tammi", "Helmi", "Maalis", "Huhti", "Touko", "Kesä", "Heinä", "Elo", "Syys", "Loka", "Marras", "Joulu" };

            int luku = (int)numericUpDown1.Value;
            
            switch (luku)
            {
                case 1:
                    i = 1;
                    break;
                case 2:
                    i = 2;
                    break;
                case 3:
                    i = 3;
                    break;
                case 4:
                    i = 4;
                    break;
                case 5:
                    i = 5;
                    break;
                case 6:
                    i = 6;
                    break;
                case 7:
                    i = 7;
                    break;
                case 8:
                    i = 8;
                    break;
                case 9:
                    i = 9;
                    break;
                case 10:
                    i = 10;
                    break;
                case 11:
                    i = 11;
                    break;
                case 12:
                    i = 12;
                    break;
                default:
                    MessageBox.Show("anna luku 1-12");
                    break;
            }
            if (i == 0)
            {
                return;
            }
            else
            {
                MessageBox.Show($"kuukautesi on {kuukaudet[i-1]}");
                i = 0;
            }


            /* OIS HELPOMPI TEHDÄ VAAN NÄIN!
            if(luku < 1 || luku > 12) 
            {
                MessageBox.Show("anna luku 1-12");
            }
            else 
            {
                MessageBox.Show($"kuukautesi on {kuukaudet[luku - 1]}");
            }
            */
        }
    }
}
