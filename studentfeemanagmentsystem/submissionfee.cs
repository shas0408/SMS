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
    public partial class submissionfee : Form
    {
        public submissionfee()
        {
            InitializeComponent();
        }


       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcome obj2 = new welcome();
            obj2.ShowDialog();
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=student_db;Uid=root;Pwd=root1234;");
            try
            {
                string cmd = ("INSERT INTO studentdatabase  (StudentId, UserName, FatheName, Program, Address, EmailAddress, CellNo, SubmissionFees) VALUES (" + Convert.ToInt32(textBox1.Text) + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "' ) ");
                MySqlCommand command = new MySqlCommand(cmd, con);
                con.Open();
                command.ExecuteReader();
                con.Close();

                string connString = "Server=localhost;Database=student_db;Uid=root;Pwd=root1234;";
                using (MySqlConnection sqlConn = new MySqlConnection(connString))
                {
                    string sqlQuery = "SELECT * from studentdatabase";
                    MySqlCommand cnd = new MySqlCommand(sqlQuery, sqlConn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cnd);
                    DataTable studentdatabase = new DataTable();
                    da.Fill(studentdatabase);
                    dataGridView1.DataSource = new BindingSource(studentdatabase, null);
                    MessageBox.Show("Account has been Created");
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Please Enter Numbers");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void submissionfee_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
