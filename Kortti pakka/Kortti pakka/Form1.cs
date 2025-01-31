using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kortti_pakka
{
    public partial class Form1 : Form
    {
        Korttipakka korttipakka; //viittaus classiin
        public Form1()
        {
            InitializeComponent();
            korttipakka = new Korttipakka(); // "asentaa" classin 
        }
        private void bntButton_Click(object sender, EventArgs e)
        {
            btnJarjesta.Visible = true;
            btnSekoita.Visible = true;
            bntButton.Visible = false;
            int[] Pakka = korttipakka.tulostus; //pakka on taulukon tulostus 
            txtVastaus.Text = string.Join(",", Pakka);  //listaa pakan eli taulukon numerot
        }
        private void btnSekoita_Click(object sender, EventArgs e)
        {
            korttipakka.sekoitus(); // viittaus sekoitus voidiin 
            bntButton_Click(sender, e);
        }

        private void btnJarjesta_Click(object sender, EventArgs e) // järjestää kortit takaisin
        {
           korttipakka = new Korttipakka();
           bntButton_Click(sender, e); 
        }
    }
    class Korttipakka
    {
        public int[] taulukko; // asentaa taulukon
        Random rnd = new Random(); // asentaa uuden randomin
        public Korttipakka()
        {
            taulukko = new int[10]; //rajoittaa taulukkon 10 lukuun
            for (int i = 0; i < 10; i++) // numeroi ne 1-10
            {
                taulukko[i] = i + 1;
            }
        }

        public void sekoitus() //sekoitus
        {
            // Sekoittaa taulukon satunnaisesti käyttäen rnd.Next() arvoja
            taulukko = taulukko.OrderBy(x => rnd.Next(1, 11)).ToArray();
            Console.WriteLine(string.Join("", taulukko));
        }
        public int[] tulostus //tulostaa taulukon arvon 
        {
            get
            {
                return taulukko;
            }

        }

    }
}
