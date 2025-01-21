﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kertotaulu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnJatka_Click(object sender, EventArgs e)
        {
            try
            {
                int kierrokset = 20;
                int i = 0;
                List<int> list = new List<int>();
                int luku = int.Parse(txtLuku.Text);
              
                for (i = 0; i <= kierrokset; i++)
                {
                    list.Add(i*luku);
                }
                MessageBox.Show($"kertotaulu for loopilla {string.Join(", ",list)}");
                i = 0;
                list.Clear();
                while (i <= kierrokset) 
                {
                    list.Add(luku*i);
                    i++;
                }
                MessageBox.Show($"kertotaulu while loopilla {string.Join(", ", list)}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Syötä kelvollinen luku" );
            }
            
            
        }
    }
}
