using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palidromi_tester
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }
        private List<string> palladromit = new List<string> { };
        private void btnJatka_Click(object sender, EventArgs e)
        {
            string syotesana = txtSana.Text.Replace(" ","").ToLower();
            char[] chars = syotesana.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            

            Console.WriteLine(syotesana + " " + reversed);
            if (syotesana == reversed && !string.IsNullOrEmpty(txtSana.Text))
            {
                palladromit.Add(syotesana);
                txtVastaus.Text = "palidromi: " + string.Join(", ", palladromit);
                txtVastauseiole.Clear();
            }
            else
            {
                txtVastauseiole.Text = syotesana +" ei ole palindromi";
            }
           
           

        }

        private void btnNollaa_Click(object sender, EventArgs e)
        {
            txtVastaus.Clear();
            txtSana.Clear();
            txtVastauseiole.Clear();
            palladromit = new List<string> { };
        }
    }
}
