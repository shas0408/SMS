using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace studentfeemanagmentsystem
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iONCLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void uPDATESTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update obj5 = new update();
            obj5.ShowDialog();
          
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void sUBMITESTUDENTFEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            submissionfee obj1 = new submissionfee();
            obj1.ShowDialog();


        }

        private void submitStudentFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            submissionfee obj1 = new submissionfee();
            obj1.ShowDialog();   

        }

        private void dELETESTUDENTRECORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete obj3 = new delete();
            obj3.ShowDialog();
        }

        private void deleteStudentRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update obj5 = new update();
            obj5.ShowDialog();
          

           
        }

        private void finalReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewreport obj4 = new viewreport();
            obj4.ShowDialog();
        }

        private void searchStudentRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            searchstudent f9 = new searchstudent();
            f9.ShowDialog();
        }

        private void sEARCHSTUDENTRECORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchstudent f9 = new searchstudent();
            f9.ShowDialog();
        }

        private void fINALREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewreport obj4 = new viewreport();
            obj4.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want to Exit Click Ok.","Important Message");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}
