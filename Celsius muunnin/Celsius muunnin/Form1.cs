using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_muunnin
{
    public partial class Form1 : Form
    {   

        bool fahreinheitb = true;
        public Form1()
        {
            InitializeComponent();
            txtF.TextChanged += new EventHandler(laske);        
        }
    

        void laske(object sender, EventArgs e)
        {   
            try
            {
                double input, Vastaus;
                input = double.Parse(txtF.Text);


                if (fahreinheitb == true)
                { 
                    Vastaus = (5.0 / 9) * (input - 32);
                    VastausL.Text = Vastaus.ToString("F2");
                }
                else
                {
                    Vastaus = (input * 9 / 5) + 32;
                    VastausL.Text = Vastaus.ToString("F2");
                }
            }
            catch (Exception)
            {

                return;
            }
        }
        private void Laske_Click(object sender, EventArgs e)
        {
            string temp = FahreinheitL.Text;

            FahreinheitL.Text = CelsiusL.Text; 
            CelsiusL.Text = temp; 
            VastausL.Text = "";
            fahreinheitb = !fahreinheitb;
            
            laske(sender, e);
           


        }
    }
}
