using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikä_ja_nimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            int x;
           

            
            if (int.TryParse(txtIka.Text, out x)) {
                if(x >10 && x <100) { 
                MessageBox.Show("hei olet " + x + "-vuotta");
                }
                else if(x < 16) { 
                    MessageBox.Show("Lian nuori");
                }
                else if (x > 100) {
                    MessageBox.Show("Liian Vanha");
                }
                
            }
            else
            {
                MessageBox.Show("ei ole luku");
            }
            

        }
    }
}
