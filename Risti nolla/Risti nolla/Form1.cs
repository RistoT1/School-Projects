using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risti_nolla
{
    public partial class Form1 : Form
    {
        bool nextmarkX = true;
        bool winner = false;
        string[,] board = new string[3, 3];
        int row = 0;
        int col = 0;    
        public Form1()
        {
            InitializeComponent();


            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Click += napit;
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void napit(object sender, EventArgs e)
        {
            if (winner == false)
            {
                if (sender is Button button)
                {
                    if (string.IsNullOrEmpty(button.Text))
                    {
                        if (nextmarkX)
                        {
                            button.Text = "X";
                            nextmarkX = !nextmarkX;
                            Voitto();
                        }
                        else
                        {
                            button.Text += "O";
                            nextmarkX = !nextmarkX;
                            Voitto();
                        }
                    }
                }
            }
        }
        private void Voitto()
        {
            if (winner == false) 
            {
                if (b0_0.Text == "X" && b1_0.Text == "X" && b2_0.Text == "X" || b0_0.Text == "O" && b1_0.Text == "O" && b2_0.Text == "O")
                {

                    b0_0.BackColor = Color.Blue;
                    b1_0.BackColor = Color.Blue;
                    b2_0.BackColor = Color.Blue;
                    winner = true;

                }
                else if (b0_1.Text == "X" && b1_1.Text == "X" && b2_1.Text == "X" || b0_1.Text == "O" && b1_1.Text == "O" && b2_1.Text == "O")
                {

                    b0_1.BackColor = Color.Blue;
                    b1_1.BackColor = Color.Blue;
                    b2_1.BackColor = Color.Blue;
                    winner = true;
                }
                else if (b0_2.Text == "X" && b1_2.Text == "X" && b2_2.Text == "X" || b0_2.Text == "O" && b1_2.Text == "O" && b2_2.Text == "O")
                {

                    b0_2.BackColor = Color.Blue;
                    b1_2.BackColor = Color.Blue;
                    b2_2.BackColor = Color.Blue;
                    winner = true;
                }

                //Tarkistaa pystyrivit
                else if (b0_0.Text == "X" && b0_1.Text == "X" && b0_2.Text == "X" || b0_0.Text == "O" && b0_1.Text == "O" && b0_2.Text == "O")
                {

                    b0_0.BackColor = Color.Blue;
                    b0_1.BackColor = Color.Blue;
                    b0_2.BackColor = Color.Blue;
                    winner = true;
                }
                else if (b1_0.Text == "X" && b1_1.Text == "X" && b1_2.Text == "X" || b1_0.Text == "O" && b1_1.Text == "O" && b1_2.Text == "O")
                {

                    b1_0.BackColor = Color.Blue;
                    b1_1.BackColor = Color.Blue;
                    b2_2.BackColor = Color.Blue;
                    winner = true;
                }
                else if (b2_0.Text == "X" && b2_1.Text == "X" && b1_2.Text == "X" || b2_0.Text == "O" && b2_1.Text == "O" && b2_2.Text == "O")
                {

                    b2_0.BackColor = Color.Blue;
                    b2_1.BackColor = Color.Blue;
                    b2_2.BackColor = Color.Blue;
                    winner = true;
                }
                //tarkistaa ristiin
                else if (b0_0.Text == "X" && b1_1.Text == "X" && b2_2.Text == "X" || b0_0.Text == "O" && b1_1.Text == "O" && b2_2.Text == "O")
                {

                    b0_0.BackColor = Color.Blue;
                    b1_1.BackColor = Color.Blue;
                    b2_2.BackColor = Color.Blue;
                    winner = true;
                }
                else if (b2_0.Text == "X" && b1_1.Text == "X" && b0_2.Text == "X" || b2_0.Text == "O" && b1_1.Text == "O" && b0_2.Text == "O")
                {

                    b2_0.BackColor = Color.Blue;
                    b1_1.BackColor = Color.Blue;
                    b0_2.BackColor = Color.Blue;
                    winner = true;
                }
            }
        }   
            

        private void b1_0_Click(object sender, EventArgs e)
        {
        }

        private void btnNollaa_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Text = string.Empty;
                    button.BackColor = Color.White;
                }
                winner = false;

            }
        }
    }
}
