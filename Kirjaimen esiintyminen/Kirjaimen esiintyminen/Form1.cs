using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirjaimen_esiintyminen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJatka_Click(object sender, EventArgs e)
        {
            try
            {   
                string sana = txtSana.Text; //úser input
                char kirjain = Convert.ToChar(txtKirjain.Text); // konvertaa kirjaimen char
                char[] list = sana.ToCharArray(); // tekee sanan kirjaimiksi charlistaan
                int maara = 0;  //samojen kirjainmien määrä

                for (int i = 0; i < list.Length; i++) //
                {
                    if (list[i] == kirjain && !string.IsNullOrEmpty(sana))
                    {
                        maara++;
                        
                    }     
                }
                if (maara > 0)
                { 
                    MessageBox.Show(maara.ToString()); 
                }
                else
                {
                    MessageBox.Show("ei löytynyt samoja kirjaimia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Syötä kirjain",ex.Message);
            }
            
        }
    }
}
