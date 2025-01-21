using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_5_luvut_teht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTulosta_Click(object sender, EventArgs e)
        {   
            textBox1.Clear(); textBox2.Clear();             //clear
            int luku1, luku2,osa,osa2;
            try
            {
                luku1 = int.Parse(txtMin.Text);             // parsetus
                luku2 = int.Parse(txtMax.Text);
                osa = luku1;                                // väliaikainen luvun tallennus
                osa2 = luku2;

                if (luku1 > luku2)
                {
                    MessageBox.Show("Luku 1 pitää olla pienempi kuin Luku2!");
                }
                else
                {
                    while (luku1 <= luku2)                      // jos aloitusluku on pienempi kuin lopetusluku
                    {
                        if (luku1 == osa)                       // jos luku on osa eli alkuperäinen input
                        {
                            textBox1.Text += luku1.ToString();
                        }
                        else                                   // jos luku ei ole alkuperäinen input
                        {
                            textBox1.Text += ", " + luku1.ToString();

                        }
                        luku1++;
                    }
                    // käyttäen lukuja "osa" vältetään uudelleen parsetus.
                    while (osa <= osa2)                         // jos luku 1 on  pienempi tai yhtä suuri kuin luku2
                    {
                        if (osa2 == osa)                        // jos luku2 on osa eli alkuperäinen luku1
                        {
                            textBox2.Text += osa2.ToString();
                        }
                        else
                        {
                            textBox2.Text += osa2.ToString() + ", ";

                        }
                        osa2--;
                    }
                }
               
            }
            catch (Exception) // virheen tarkistus
            {
                MessageBox.Show("Anna lukuja");
            }
            


        }
    }
}
