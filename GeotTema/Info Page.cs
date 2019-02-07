using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeotTema
{
    public partial class Info_Page : Form
    {
        List<Table> table = new List<Table>();
        public Info_Page()
        {
            InitializeComponent();

            dataGridView1.DataSource = table;
            //dataGridView1.DislayMember
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlCommands db = new SqlCommands();
            table = db.GetTable(SearchBox.Text);
        }
    }
}
