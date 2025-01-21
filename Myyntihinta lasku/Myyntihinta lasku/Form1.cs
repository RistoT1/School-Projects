using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myyntihinta_lasku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Laske_Click(object sender, EventArgs e)
        {
            VastausL.ForeColor = Color.Black;
            try
            {
                double hinta;
                hinta = double.Parse(txthinta.Text);
                if (hinta > 100)
                {
                    hinta = hinta * 0.75;
                    hintaarvL.Text = "Hinta on yli 100€. Alennus voimassa";
                }
                else
                {
                    hintaarvL.Text = "Hinta on alle 100€. Alennus ei ole voimassa";
                }

                VastausL.Text = (hinta * 0.90).ToString("F2");
            }
            catch (Exception)
            {
                VastausL.Text = "Syötä lukuja";
                VastausL.ForeColor = Color.Red;
                hintaarvL.Text = "";
            }
            


        }
    }
}
