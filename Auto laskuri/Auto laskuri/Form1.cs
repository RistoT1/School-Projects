using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
        }

        private void HenkiloA_Click(object sender, EventArgs e)
        {
            int hAuto;
            int hautoluku = int.Parse(txthauto.Text);
            if (hautoluku > 0)
            {
                label1.Text = label1.Text + hautoluku.ToString();
                return;
            }
            else
            { 
            hAuto = int.Parse(label1.Text);
            hAuto += 1;
            label1.Text = hAuto.ToString();
                return ;
            }
        }

        private void KuormaA_Click(object sender, EventArgs e)
        {
            int KAuto;
            KAuto = int.Parse(label2.Text);
            KAuto += 1;
            label2.Text = KAuto.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
