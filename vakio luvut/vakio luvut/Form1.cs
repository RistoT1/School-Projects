using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace vakio_luvut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTulosta_Click(object sender, EventArgs e)
        {
            try
            {
                txtVastaus.Clear();
                int rivit;
                string vastaus = "";
                rivit = int.Parse(txtRivit.Text);       //rivien määrä
                Random random = new Random();           //random
                for (int i = 0; i < rivit; i++)         // kun i on pienempi kuin rivien määrä
                {
                    switch (random.Next(0, 3))          // generoi numeron 1-3 väliltä
                    {
                        case 0:                         //eri lopputulokset 
                            vastaus = "1";
                            break;
                        case 1:
                            vastaus = "X";
                            break;
                        case 2:
                            vastaus = "2";
                            break;
                    }
                    // printtaa vastauksen
                    txtVastaus.Text += $"rivi:{i + 1} {Environment.NewLine} {vastaus} {Environment.NewLine}";

                }
            }
            catch (Exception)
            {
                MessageBox.Show("syötä luku");
            }
            
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            try
            {

                using (SaveFileDialog saveFileDialog = new SaveFileDialog()) // uusi Savefile dialog
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    saveFileDialog.Title = "valitse sijainti";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Tiedoston nimi
                        string savefilePath = saveFileDialog.FileName;
                        File.WriteAllText(savefilePath, txtVastaus.Text);
                        MessageBox.Show("Tiedosto tallennettu", "Tallennus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe tallennuksessa {ex.Message}", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLue_Click(object sender, EventArgs e)
        {   
            try
            {
                //List <string> filteri = new List<string> {"rivi:1","rivi:2"};
                List<string> list = new List<string>();

                using (OpenFileDialog openFileDialog = new OpenFileDialog()) // uusi Savefile dialog
                {
                    // Filtteri eri tiedosto tyypeille mitkä näkyy.
                    openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                    openFileDialog.Title = "valitse sijainti";

                    if (openFileDialog.ShowDialog() == DialogResult.OK) // ok nappi painettu
                    {
                        //Tiedoston nimi
                        string openfilePath = openFileDialog.FileName;
                        // lataa nimen ja tekstin kentästä
                        list.Add(File.ReadAllText(openfilePath));
                        MessageBox.Show("Tiedosto ladattu", "Lataus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtVastaus.Text = string.Join("",list);
                        
                        /* YRITYKSENÄ OLI TEHDÄ FILTERI RIVIEN LUKEMISEEN 
                        var filteredlist = list.Where(item => filteri.Any(filter => item.Contains(filter))).ToList();

                        
                        StringBuilder result = new StringBuilder();  // Use StringBuilder for efficient string concatenation

                        foreach (var item in filteredlist)
                        {
                            result.Append(item.ToString());  // Append each item to the StringBuilder
                        }

                        txtVastaus.Text = result.ToString();  // Set the result to txtVastaus.Text

                        Console.WriteLine(string.Join("", filteredlist));
                        */


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe tallennuksessa {ex.Message}", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
