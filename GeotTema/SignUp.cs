using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace GeotTema
{
    public partial class SignUp : Form
    {
        SqlCommands sudb = new SqlCommands();
        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                string name = textBox1.Text;
                string pass = textBox2.Text;
                SqlCommands.CreateLogin(name, pass);
                SqlCommands lgin = new SqlCommands();
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
                    MessageBox.Show("Bad Pass");
                }
            }
            else
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn f1 = new SignIn();
            f1.ShowDialog();
            this.Close();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                label6.Text = "Password er ens";
            }
            else if (textBox2.Text != textBox3.Text) 
            {
                label6.Text = "Password er ikke ens";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == textBox3.Text)
            {
                label6.Text = "Password er ens";
            }
            else if (textBox2.Text != textBox3.Text)
            {
                label6.Text = "Password er ikke ens";
            }
        }
    }
}
