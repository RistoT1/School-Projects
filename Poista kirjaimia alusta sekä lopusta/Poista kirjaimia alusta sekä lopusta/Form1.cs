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

namespace Poista_kirjaimia_alusta_sekä_lopusta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sana = txtSana.Text.ToLower();
                int arvo = int.Parse(txtLuku.Text);
                string vastaus = "";

                if (arvo == 0) 
                {
                    MessageBox.Show("arvo ei voi olla 0");
                }
                else if (arvo * 2 >= sana.Length)
                {
                    MessageBox.Show("kahdella kerrottu luku ei voi olla suurempi tai yhtä suuri kuin sana");
                }
                else
                {
                    vastaus = sana.Substring(arvo, sana.Length - 2 * arvo);
                }
                
                txtVastaus.Text = vastaus;

                
               
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
