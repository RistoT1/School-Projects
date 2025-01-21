using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tulosta_luvt1
{
    public partial class Form1 : Form
    {

        bool lukuylos = true;
        
        public Form1()
        {
            InitializeComponent();
            txtLuku.TextChanged += new System.EventHandler(txtLuku_TextChanged);
        }
        private void txtLuku_TextChanged(object sender, EventArgs e)
        {   
            txtVastaus.Clear();
            try
            {
                
                int luku;
                if (string.IsNullOrEmpty(txtLuku.Text))
                {
                    return;
                }
                else 
                {
                    luku = int.Parse(txtLuku.Text);
                }
                int loppuluku = luku;

                if (lukuylos == true) 
                {
                    for (int i = 1; i <= luku; i++)
                    {
                        if (i == luku)
                        {
                            txtVastaus.Text += i.ToString();
                        }
                        else
                        {
                            txtVastaus.Text += i.ToString() + ", ";
                        }
                    }
                }
                else 
                {
                    for(int i = 1; i <= luku; i++) 
                    {
                       
                        if (luku == i)
                        {
                            txtVastaus.Text += loppuluku.ToString() + " ";
                        }
                        else
                        {
                            txtVastaus.Text += loppuluku.ToString() + ", ";
                        }
                        loppuluku--;
                    }
                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Syötä vain positiivisia lukuja");
            }
        }
        private void btnJatka_Click(object sender, EventArgs e)
        {
            lukuylos = !lukuylos;
            txtLuku_TextChanged(sender, e);
            
        }
    }
}
