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
                SqlCommands.CreateLogin(textBox1.Text, textBox2.Text);

            }
            else
            {

            }
        }
    }
}
