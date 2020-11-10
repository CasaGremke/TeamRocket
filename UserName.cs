using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamRock
{
    public partial class UserName : Form
    {
        static int attempt = 3;
        public UserName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            

            if ((this.txtUserName.Text == "Admin"))
            {
                attempt = 0;

                Game ad = new Game();
                ad.ShowDialog();


            }
            else
            {
               MessageBox.Show("Wrong Password");
                
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserName_Load(object sender, EventArgs e)
        {

        }
    }
}
