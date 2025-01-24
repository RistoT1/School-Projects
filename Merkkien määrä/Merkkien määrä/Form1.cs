using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merkkien_määrä
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJatka_Click(object sender, EventArgs e)
        {
            string sana = txtSana.Text.Replace(" ","");
            int sananpituus = txtSana.TextLength;
            if (!string.IsNullOrEmpty(sana) ) 
            {
                MessageBox.Show($"Sanasi pituus on: {sananpituus.ToString()}");
            }
            
        }
    }
}
