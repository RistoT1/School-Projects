using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parillinen_pariton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLaske_Click(object sender, EventArgs e)
        {
            int min, max;
            List<int> vastauspari = new List<int>();            // listat perilliselle ja parittomille
            List<int> vastauspariton = new List<int>();
            min = (int)numericUpDown1.Value;                    //min ja max luvut 
            max = (int)numericUpDown2.Value;

            while (min <= max)                                  //kun max on suurempi kuin min
            {

                if (min % 2 == 0 && min != 0)                   // jos jaollinen kahdella ja ei ole nolla
                {
                    vastauspari.Add(min);
                }
                else 
                {   
                   if(min != 0)                                 //jos ei ole nolla lisää luku
                   {
                        vastauspariton.Add(min);
                   }    
                }
                min++;
                
            }
            txtVastaus.Text = string.Join(", ", vastauspari);       //printtaa listat
            txtvastauspariton.Text = string.Join(", ", vastauspariton);

        }
    }
}
