using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luku_arvaus
{
    public partial class Form1 : Form
    {
        public int randomluku1, arvaus;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            randomluku();
        }
    
        public void randomluku()
        {
           
            randomluku1 = random.Next(1, 10);
            lukuLV.Text = randomluku1.ToString();
        }
        private void Arvaa_Click(object sender, EventArgs e)
        {
            try
            {
                arvaus = int.Parse(txtArvaa.Text);

                if (arvaus == randomluku1)
                {
                    txtArvaa.Text = "";
                    MessageBox.Show("voitit");
                    vaarin.ForeColor = Color.Black;
                    vaarin.Text = "---";
                    randomluku();
                }
                else
                {
                    txtArvaa.Text = "";
                    vaarin.Text ="väärin kirjoita uusi luku";
                    vaarin.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
            
        }
    }
}
