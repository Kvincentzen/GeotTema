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
        SqlCommands ipdb = new SqlCommands();
        List<Table> table = new List<Table>();
        public Info_Page()
        {
            InitializeComponent();
            //SqlCommands db = new SqlCommands();
            //dataGridView1.DataSource = db.GetTable ;
            //dataGridView1.DislayMember
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //table = db.SearchTable(SearchBox.Text);
            Info_PageGridView.DataSource = ipdb.SearchTable(SearchBox.Text);
        }

        private void LandeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Info_Page_Load(object sender, EventArgs e)
        {
            Info_PageGridView.DataSource = ipdb.GetTable("*");

        }
    }
}
