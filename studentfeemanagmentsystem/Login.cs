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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream filestream = new FileStream("login.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(filestream);
            string filereader = File.ReadAllText("login.txt");
            int i = 0;
            while ((filereader = reader.ReadLine()) != null)
            {
                if (filereader.Contains(textBox1.Text) && filereader.Contains(textBox2.Text))
                {

                    i++;
                    welcome obj10 = new welcome();
                    obj10.ShowDialog();
                    
                    
                }

               // else if (filereader.Contains(textBox1.Text) != filereader.Contains(textBox2.Text))
                //{

             //       MessageBox.Show("You are Not Register");
                    
               // }
               
            }
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            register obj9 = new register();
            obj9.ShowDialog();
            

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            
            

        }
    }
}
