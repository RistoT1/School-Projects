using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matti_ja_Arto
{
    public partial class Form1 : Form
    {
        int ika1, ika2;
        string nimi1, nimi2;
        bool wave1 = true;
        bool wave2 = true;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void NollaB_Click(object sender, EventArgs e)
        {   //Nollaus nappi ja tekstien desing muutos
            wave1 = true;               
            wave2 = true;               
            label1.Text = "nimi1";
            label2.Text = "nimi2";
            txtInput1.Text = "";
            txtInput2.Text = "";
            Vastaus.Text = "---";
        }

        private void Jatka_Click(object sender, EventArgs e)
        {
            

            if (wave1 == true)
            {
                
                nimi1 = txtInput1.Text; //kerää nimet
                nimi2 = txtInput2.Text;
                if (nimi1.Length > 0 && nimi2.Length >0)    //tarkistaa ettei nimi ole tyhjä
                { 
                    label1.Text = "ikä1";           
                    label2.Text = "ikä2";
                    txtInput1.Text = "";
                    txtInput2.Text = "";
                    wave1 = false;          //kerää iät


                }
                else
                {
                    return;     //jos nimi tyhjä return;
                }
            }
            else
            {

                try
                {               //koikeilee parsettaa
                    ika1 = int.Parse(txtInput1.Text);
                    ika2 = int.Parse(txtInput2.Text);
                    wave2 = false;
                }
                catch (Exception)
                {
                    //luvut ei ole oikein
                    Vastaus.Text = "laita molemmat luvut";
                    Vastaus.ForeColor = Color.Red;  
                }
            }
            if (wave2 == false)
            {   
                //laskee iät yhteen ja printtaa nimet + kokonais ikä
                int ika = ika1 + ika2;
                Vastaus.ForeColor = Color.Black;
                Vastaus.Text = nimi1+ " ja "+nimi2 +" Ovat yhteensä "+ ika.ToString() + "-Vuotta";

            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
