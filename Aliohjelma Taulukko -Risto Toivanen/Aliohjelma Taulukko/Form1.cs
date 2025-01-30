using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aliohjelma_Taulukko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> Nimet = new List<string> {"1    Maija    Meikäläinen", "2    Matti    Meikäläinen", "3    Pirkko  Liisa" };
            Suorita(Nimet);
        }
        public void Suorita(List<string> Nimet) 
        {
            txtTaulukko.Text = $"ID     Nimi    Sukunimi {Environment.NewLine} --------------------------------------{Environment.NewLine}{string.Join(Environment.NewLine,Nimet)}";
        }
    }
}
