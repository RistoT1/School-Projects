using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tähtien_tulostus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Concat(Enumerable.Repeat(" ★", int.Parse(txtluku.Text))));
            //Bruh 
            // toimii yhdellä lauseella


            int luku;
            luku = int.Parse(txtluku.Text);
            string tahdet = "";
            for (int i = 0; i < luku; i++) //for loop 
            {
                tahdet += " ★";
            }
            MessageBox.Show(tahdet);
        }
    }
}
