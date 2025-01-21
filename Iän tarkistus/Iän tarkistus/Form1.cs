using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iän_tarkistus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Jatka_Click(object sender, EventArgs e)
        {
            try
            {
                int ika ;
                ika = int.Parse(txtika.Text);

                if (ika >= 0 && ika <= 120)
                {
                    MessageBox.Show("Tervetuloa");
                }
                else 
                {
                    MessageBox.Show("anna hyväksyttävä ikä 0-120");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ongelma tapahtui");
            }
          
        }
    }
}
