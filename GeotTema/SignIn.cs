using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GeotTema
{
    public partial class SignIn : Form
    {
        SqlCommands lgin = new SqlCommands();
        public SignIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contact your host admin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = lgin.Login(textBox1.Text, textBox2.Text);
            if (b == true)
            {
                this.Hide();
                Info_Page f2 = new Info_Page();
                f2.ShowDialog();
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Du kunne ikke logge ind ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp f3 = new SignUp();
            f3.ShowDialog();
            this.Close();
        }
    }
}
