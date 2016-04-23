using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace studentfeemanagmentsystem
{
    public partial class inquery : Form
    {
        public inquery()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=student_db;Uid=root;Pwd=root1234;";
            using (MySqlConnection sqlConn = new MySqlConnection(connString))
            {
                string sqlQuery = "SELECT * FROM studentdatabase WHERE Dates BETWEEN '18' AND '19'";
                MySqlCommand cnd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataAdapter da = new MySqlDataAdapter(cnd);
                DataTable studentdatabase = new DataTable();
                da.Fill(studentdatabase);
                dataGridView1.DataSource = new BindingSource(studentdatabase, null);
            }
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            welcome obj12 = new welcome();
            obj12.ShowDialog();
        }
    }
}
