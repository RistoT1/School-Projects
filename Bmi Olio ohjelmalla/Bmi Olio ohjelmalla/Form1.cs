using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bmi_Olio_ohjelmalla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJatka_Click(object sender, EventArgs e)
        {
            double paino, pituus, vastaus;
            
            paino = double.Parse(txtPaino.Text);
            pituus = double.Parse(txtPituus.Text);

            Bmi bmi = new Bmi();
            bmi.Pai = paino;
            bmi.Pit = pituus;
            vastaus = bmi.BmiLaske();
            txtVastaus.Text = vastaus.ToString("F2");
            Console.WriteLine(txtVastaus.Text +" "+ bmi.Pai+" "+ bmi.Pit);
            
            
        }
    }
    class Bmi
    {
        private double pai, pit;
        public double BmiLaske() 
        { 
           return (pai / Math.Pow(pit,2) * 10000);
        }
        public Bmi() 
        {
            pai = 0;
            pit = 0;
        }
        public double Pai
        {
            set
            {
                pai = value;
            }
            get
            {
                return pai;
            }
        }
        public double Pit
        {
            set
            {
                pit = value;
            }
            get
            {
                return pit;
            }
        }
    }
}
