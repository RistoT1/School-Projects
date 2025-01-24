using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etsi_kirjaimia_merkkijonosta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJatka_Click(object sender, EventArgs e)
        {   
            TxtVastausK.Clear();
            txtVastaus.Clear();
            string sana1 = txtSana1.Text.ToLower();
            string sana2 = txtSana2.Text.ToLower();
            char[] sana1char = sana1.ToCharArray().Distinct().ToArray();
            char[] sana2char = sana2.ToCharArray(); 
            List<string> Used = new List<string>();
            int summa = 0;
            List<int> summaLista = new List<int>();
            
            
            foreach(char c in sana1char) // c eli ensimmäinen sanan kirjaimet
            {
                summa = 0; // nollaa summan

                foreach (char ch in sana2char)  //ch eli toisen sanan kirjaimet
                {
                    if (c == ch) // jos kirjain sanasta1 on sama kuin kirjain sanasta2 // ohjelma käy läpi koko alemman sanan kerran ennen kun jatkaa eteen päin
                    {
                        summa++;                  
                    }
                }
                if (summa > 0) // jos summa on isompi kuin nolla lisää listaan
                {
                    summaLista.Add(summa);
                    Used.Add(c.ToString());
                }     
                else // jos 0 niin lisää sen ei löydettyihin kirjaimiin
                {
                    txtVastaus.AppendText($"Kirjain: {c}: {summa}{Environment.NewLine}");
                } 
            }
            for (int i = 0; i < summaLista.Count; i++) // lisää kirjaimet listatsta löydettyihin kirjaimiin.
            {
                TxtVastausK.Text += "Kirjain " + (string.Join("", Used[i]) + ": " + string.Join("", summaLista[i])) + Environment.NewLine;
            }



        }
    }
}
