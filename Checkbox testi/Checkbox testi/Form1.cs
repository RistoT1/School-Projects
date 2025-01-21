using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_testi
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

        private void btnLaske_Click(object sender, EventArgs e)
        {
            int tulos = 0;
            int arvo = 0;
            int yhteensa = 0;
            
            
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox checkBox && checkBox.Checked)
                {

                    if (int.TryParse(checkBox.Text, out arvo))
                    {
                        tulos += arvo;
                        yhteensa += 1;
                    }
                }

            }
            Tulos2.Text = tulos.ToString();
            Tulos1.Text = yhteensa.ToString();
        }
    }
}
