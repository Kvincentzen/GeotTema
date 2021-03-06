﻿using System;
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
        public string name = "sql_admin";
        public string pass = "Passw0rd";
        public Info_Page()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Info_PageGridView.DataSource = ipdb.SearchTable(SearchBox.Text);
        }

        private void LandeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Info_Page_Load(object sender, EventArgs e)
        {
            Info_PageGridView.DataSource = ipdb.GetTable();
            string query = string.Format("select * from Lande");
            DataTable dt = SqlCommands.GetData(query);
            chart1.DataSource = dt;
            chart1.Series[0].XValueMember = "Lande";
            chart1.Series[0].YValueMembers = "Fodselsrate";
            chart1.DataBind();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Info_PageGridView.DataSource = ipdb.SearchTable(SearchBox.Text);
        }
    }
}
