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
    public partial class searchstudent : Form
    {
        public searchstudent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string connString = "Server=localhost;Database=student_db;Uid=root;Pwd=root1234;";
                using (MySqlConnection sqlConn = new MySqlConnection(connString))
                {
                    string sqlQuery = "SELECT * from studentdatabase where StudentId='" + textBox1.Text + "'";
                    MySqlCommand cnd = new MySqlCommand(sqlQuery, sqlConn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cnd);
                    DataTable studentdatabase = new DataTable();
                    da.Fill(studentdatabase);
                    dataGridView1.DataSource = new BindingSource(studentdatabase, null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Please Enter Number");
            }





            //string connString = "Server=localhost;Database=student_db;Uid=root;Pwd=root1234;";

            //using (MySqlConnection sqlConn = new MySqlConnection(connString))
            //{
            //    string sqlQuery = "SELECT * from studentdatabase";
            //    MySqlCommand cnd = new MySqlCommand(sqlQuery, sqlConn);
            //    MySqlDataAdapter da = new MySqlDataAdapter(cnd);
            //    DataTable studentdatabase = new DataTable();
            //    da.Fill(studentdatabase);
            //    dataGridView1.DataSource = new BindingSource(studentdatabase, null);
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }







    }
}