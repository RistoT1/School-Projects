using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lukujen_summa_ja_keskiarvo__Random_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJatka_Click(object sender, EventArgs e)
        {

            try
            {
                int Luku = int.Parse(txtLuku.Text);
                int summa = 0;
                double keskiarvo = 0;
                int randomLuku;
                List<int> list = new List<int>(); //numero 
                Random random = new Random(); 

                for (int i = 0; i < Luku; i++) // random luku ja listaus 
                {
                    randomLuku = random.Next(1, 21);
                    list.Add(randomLuku);


                }
                keskiarvo += list.Average(); //keskiarvo luvuista
                txtSumma.Text = string.Join(", ", list.Sum());  //summa luvuista
                txtKeskiarvo.Text = keskiarvo.ToString("F2");   // keskiarvo tekstiksi
                txtVastaus.Text = string.Join(", ", list);      // Vastaus Tekstiksi eli kaikki numerot listatsta
            }
            catch (Exception ex)                                //error
            {
                MessageBox.Show(ex.Message, "syötä luku");
            }
        }
    }
}
