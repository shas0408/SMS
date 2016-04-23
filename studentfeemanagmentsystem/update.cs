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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            welcome obj7 = new welcome();
            obj7.ShowDialog();
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=student_db;Uid=root;Pwd=root1234;");
                string cmd = ("UPDATE studentdatabase SET  UserName='" + textBox2.Text + "', FatheName='" + textBox3.Text + "', Program='" + textBox4.Text + "', Address='" + textBox5.Text + "', EmailAddress='" + textBox6.Text + "', CellNo='" + textBox7.Text + "', SubmissionFees = '" + textBox8.Text + "'Where StudentId='" + textBox1.Text + "'");
                MySqlCommand command = new MySqlCommand(cmd, con);
                con.Open();
                command.ExecuteReader();
                con.Close();
                MessageBox.Show("Account has been Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Please Enter Numbers");
            }

         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connString = @"Server=localhost;Database=student_db;Uid=root;Pwd=root1234;";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
