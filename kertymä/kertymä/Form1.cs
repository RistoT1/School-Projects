using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kertymä
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJatka_Click(object sender, EventArgs e)
        {
            int kierros;
            int i = 0;
            int vastaus = 0;


            kierros = int.Parse(txtLukumaara.Text);

            while (i < kierros)
            {
                vastaus += i;
                i++;
                
            }
            MessageBox.Show($"{vastaus.ToString()} kierrosta kertymäksi saatiin: {vastaus.ToString()}");
        }
    }
}
