using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuukaudet
{
    public partial class Kuukaudet : Form
    {
        public Kuukaudet()
        {
            InitializeComponent();
        }

        private void Jatka_Click(object sender, EventArgs e)
        {
            VastausL.ForeColor = Color.Black;
            //lista kuukaudet
            string[] kuukaudet = { "Tammi", "Helmi","Maalis","Huhti","Touko","Kesä","Heinä","Elo","Syys","Loka","Marras","Joulu" };
            try
            {
                int luku1 = int.Parse(txtKuukausi.Text); //parcetus käyttäjän syötöstä
                if (luku1 > 0 || luku1 <=12)            // jos luku kuukauden numero katsoo listasta oikean luvun.
                {
                    VastausL.Text = kuukaudet[luku1-1];
                }

            }
            catch (Exception)           // error tilanteiden hallinta
            {
                VastausL.Text = "anna numero väliltä 1-12";
                VastausL.ForeColor = Color.Red;
            }
        }
    }
}
