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

namespace listaa_ja_laske_summa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTulosta_Click(object sender, EventArgs e)
        {
            

            try
            {
                int lopetusLuku, aloitusLuku, summa;
                aloitusLuku = 1;
                lopetusLuku = int.Parse(txtLuku.Text);              // lopetus luvun parsetus 
                summa = 0;                                          //laskee summan
                txtSumma.Clear();                                   // tekstikenttien tyhjennys
                textBox2.Clear();

                while (aloitusLuku <= lopetusLuku)                  // kun aloitus luku on pienempi kuin lopetus luku 
                {
                    if (lopetusLuku == aloitusLuku)                 // jos lopetus ja aloitus luku ovat samat
                    {
                        textBox2.Text += aloitusLuku.ToString();
                    }
                    else
                    {
                        textBox2.Text += aloitusLuku.ToString() + ", ";
                    }
                    summa += aloitusLuku;                           // lisää summaan aloitusluvun 
                    aloitusLuku++;
                }
                txtSumma.Text += summa.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("syötä luku");
            }
           
        }
    }
}
