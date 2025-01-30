using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merkkijono
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJatka_Click(object sender, EventArgs e)
        {
            string[] arvosanat = {"Hylätty","välttävä","tyydytyttävä","hyvä","kiitettävä","erinomainen"};
            double luku;
            try
            {
                luku = double.Parse(txtArvosana.Text);

                if (luku < 0 || luku >= arvosanat.Length )
                {
                    MessageBox.Show("luku ei ole alueelta");
                }
                else
                {
                    VastausL.Text = arvosanat[(int)luku];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Syötä luku");
            }

        }
    }
}
