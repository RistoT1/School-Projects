using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merkkien_tulostus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>(); //lista sanoille
        string sana = "";
        private void btnEtuperin_Click(object sender, EventArgs e)
        {   
            list.Clear(); // tyhjentää listan
            sana = txtSana.Text.Replace(" ", "");// korvaa välilyönnit
            char[] chars = sana.ToCharArray(); //
            int kirjainMaara = (int)numericUpDown1.Value;
            if (kirjainMaara > sana.Length)
            {
                kirjainMaara = sana.Length;
                
            }
            if (!string.IsNullOrEmpty(sana) && kirjainMaara <= sana.Length)
            {
                for (int i = 0; i < kirjainMaara; i++)
                {
                    list.Add(chars[i].ToString());
                }
                txtVastaus.Text = string.Join("", list);
            }     
        }

        private void btnTakaperin_Click(object sender, EventArgs e)
        {
            list.Clear();
            sana = txtSana.Text.Replace(" ", "");
            char[] chars = sana.ToCharArray();
            Array.Reverse(chars);
            int kirjainMaara = (int)numericUpDown1.Value;

            if (kirjainMaara > sana.Length)
            {
                kirjainMaara = sana.Length;

            }
            if (!string.IsNullOrEmpty(sana))
            {
                for (int i = 0; i < kirjainMaara; i++)
                {
                    list.Add(chars[i].ToString());
                }
                txtVastaus.Text = string.Join("", list);
            }
        }
    }
}
