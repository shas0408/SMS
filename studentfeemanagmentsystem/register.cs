using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace studentfeemanagmentsystem
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            //   string retypepassword;

            username = textBox1.Text;
            password = textBox2.Text;
            // retypepassword = textBox3.Text;

            FileStream wr1 = new FileStream("login.txt", FileMode.Append, FileAccess.Write);
            StreamWriter wr2 = new StreamWriter(wr1);
            wr2.Write(" UserName :");
            wr2.Write(username);
            wr2.Write(" Password :");
            wr2.Write(password);
            //  wr2.Write(" Retypepassword :");
            // wr2.Write(retypepassword);
            wr2.WriteLine("\n");
            wr2.Close();
            this.Close();
            MessageBox.Show("Congradulation!!account Has Created.");
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
