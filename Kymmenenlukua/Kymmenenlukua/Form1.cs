using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Kymmenenlukua
{
    public partial class Form1 : Form
    {
        private int odotus = 500;
        private bool eka = false;
        public Form1()
        {
            InitializeComponent();
        }
        

        private async void btnSuurin_Click(object sender, EventArgs e)
        {
            int luku;
            var luvut = new List<int>();
            int max = 0;
            bool eiluku =false;
            
            
            
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBoxes)
                {
                    textBoxes.BackColor = Color.White;
                }
                
            }

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBoxes && int.TryParse(textBoxes.Text, out luku)) 
                {

                    luvut.Add(luku);
                    btnNolla.Visible = false;
                }
                else
                {
                    btnNolla.Visible = true;
                }
            }
            if (luvut.Count > 2)
            {
                max = luvut.Max();
                foreach (Control control in this.Controls)
                {   
                    if (control is TextBox textBoxes && int.TryParse(textBoxes.Text, out luku))
                    {   

                        textBoxes.BackColor = Color.White;
                        btnNolla.Visible = false;
                        if (luku == max)
                        {
                            textBoxes.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            textBoxes.BackColor = Color.White;
                            eiluku = true;
                        }

                    }
                }
                if (eiluku == true)
                {
                    btnNolla.Visible = true;
                }
                else
                {
                    btnNolla.Visible = false;
                }
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox textBoxes)
                    {
                        while (textBoxes.BackColor == Color.DarkGreen)
                        {
                            await Task.Delay(odotus);
                            textBoxes.ForeColor = Color.White;
                            await Task.Delay(odotus);
                            textBoxes.ForeColor = Color.Black;
                        }
                    }

                }
            }
        }

        private void btnNolla_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBoxes)
                {
                    textBoxes.Clear();
                    btnNolla.Visible = false;
                    textBoxes.BackColor = Color.White;

                }
               
            }
        }
    }
}
