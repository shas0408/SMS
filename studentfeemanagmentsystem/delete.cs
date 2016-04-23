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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=student_db;Uid=root;Pwd=root1234;");
                string cmd = ("DELETE FROM  studentdatabase where Studentid = " + Convert.ToInt32(textBox1.Text) + "");
                MySqlCommand command = new MySqlCommand(cmd, con);
                con.Open();
                command.ExecuteReader();
                con.Close();
                MessageBox.Show("Account has been Deleted");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Please Enter Numbers in Student Id");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=student_db;Uid=root;Pwd=root1234;";
            using (MySqlConnection sqlConn = new MySqlConnection(connString))
            {
                string sqlQuery = @"SELECT * from studentdatabase";
                MySqlCommand cnd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataAdapter da = new MySqlDataAdapter(cnd);
                DataTable studentdatabase = new DataTable();
                da.Fill(studentdatabase);
                dataGridView1.DataSource = new BindingSource(studentdatabase, null);

            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

    }
}
