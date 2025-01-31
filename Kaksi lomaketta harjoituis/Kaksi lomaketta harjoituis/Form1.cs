using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaksi_lomaketta_harjoituis
{
    public partial class Form1 : Form
    {
        private List<User> users;
        public Form1()
        {
            InitializeComponent();
            users = new List<User>
            {
                new User { Username = "Pekka", Password = "1234" },
                new User { Username = "Martti", Password = "5678" },
                new User { Username = "Pirkko", Password = "abcd" }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             

        }

        private void btnJatka_Click(object sender, EventArgs e)
        {
            string Tunnus = txtTunnus.Text;
            string salasana = txtSalasana.Text;
            
            User user = users.FirstOrDefault(users => users.Username == Tunnus && users.Password == salasana );
            if ( user != null ) 
            {
                MessageBox.Show("Tervetuloa");
            }        
            else
            {
                MessageBox.Show("Tunnus tai salasana on väärin");
            }

        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
