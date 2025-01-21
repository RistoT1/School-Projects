using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txtTallenus_ja_luku
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    saveFileDialog.Title = "valitse sijainti";
                    
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string savefilePath = saveFileDialog.FileName;
                        File.WriteAllText(savefilePath, textBoxData.Text);
                        MessageBox.Show("Tiedosto tallennettu", "Tallennus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe tallennuksessa {ex.Message}", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string nykytxt = textBoxData.Text;
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                { 
                    openFileDialog.Filter = "Text documents (.txt)|*.txt";
                    openFileDialog.Title = "valitse sijainti";
                    
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string openfilePath = openFileDialog.FileName;
                        textBoxData.Text = nykytxt + File.ReadAllText(openfilePath);
                        MessageBox.Show("Tiedosto ladattu onnistuneesti!", "load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }                         
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Virhe Latauksessa {ex.Message}", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }
    }
}
