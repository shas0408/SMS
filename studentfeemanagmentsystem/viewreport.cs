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
    public partial class viewreport : Form
    {
        public viewreport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcome obj11 = new welcome();
            obj11.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=student_db;Uid=root;Pwd=root1234;";
            using (MySqlConnection sqlConn = new MySqlConnection(connString))
            {
                string sqlQuery = "SELECT * from studentdatabase Where SubmissionFees = 'Paid'";
                MySqlCommand cnd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataAdapter da = new MySqlDataAdapter(cnd);
                DataTable studentdatabase = new DataTable();
                da.Fill(studentdatabase);
                dataGridView1.DataSource = new BindingSource(studentdatabase, null);
                
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            welcome obj11 = new welcome();
            obj11.ShowDialog();
        }

        

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=student_db;Uid=root;Pwd=root1234;";
            using (MySqlConnection sqlConn = new MySqlConnection(connString))
            {
                string sqlQuery = "SELECT * from studentdatabase";
                MySqlCommand cnd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataAdapter da = new MySqlDataAdapter(cnd);
                DataTable studentdatabase = new DataTable();
                da.Fill(studentdatabase);
                dataGridView1.DataSource = new BindingSource(studentdatabase, null);
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=student_db;Uid=root;Pwd=root1234;";
            using (MySqlConnection sqlConn = new MySqlConnection(connString))
            {
                string sqlQuery = "SELECT * from studentdatabase where SubmissionFees='Paid'";
                MySqlCommand cnd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataAdapter da = new MySqlDataAdapter(cnd);
                DataTable studentdatabase = new DataTable();
                da.Fill(studentdatabase);
                dataGridView1.DataSource = new BindingSource(studentdatabase, null);

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=student_db;Uid=root;Pwd=root1234;";
            using (MySqlConnection sqlConn = new MySqlConnection(connString))
            {
                string sqlQuery = "SELECT * from studentdatabase where SubmissionFees='UnPaid'";
                MySqlCommand cnd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataAdapter da = new MySqlDataAdapter(cnd);
                DataTable studentdatabase = new DataTable();
                da.Fill(studentdatabase);
                dataGridView1.DataSource = new BindingSource(studentdatabase, null);

            }
        }

        private void jano_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
