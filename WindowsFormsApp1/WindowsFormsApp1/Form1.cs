using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Jatka_Click(object sender, EventArgs e)
        {
          
            if (txtNimi.Text.Length < 3)
            {
                txtVaara.ForeColor = Color.Red;
            }
            if (txtNimi.Text.Length > 3 && txtNimi.Text.Length < 6)
            {
                txtVaara.ForeColor = Color.Black;
                MessageBox.Show("Heissan " + txtNimi.Text);
                
            }
            if(txtNimi.Text.Length > 6 && txtNimi.Text.Length < 10)
            {
                txtVaara.ForeColor = Color.Black;
                MessageBox.Show("outo " + txtNimi.Text);
            }

        }

        private void txtNimi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
