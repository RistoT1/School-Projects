using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotto_arvonta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            txtLottorivi.Clear();
            int luku;
            Random random = new Random(); // random
            List <int> list = new List<int>();           // lottorivi lista
            try
            {   
                for (int i = 0; i < 7;)                         // looppaa 7 kertaa
                {
                    luku = random.Next(1, 41);
                    if (!list.Contains(luku))
                    {
                        list.Add(luku);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("luku oli käytössä " +  luku);
                    }
                }
                txtLottorivi.Text = string.Join(Environment.NewLine, list) ;         // printtaa listan
            }
            catch (Exception ex )
            {
                MessageBox.Show("" + ex.Message);           // error messages
            }
            
           


        }
    }
}
