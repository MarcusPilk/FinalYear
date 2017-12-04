using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Label = System.Windows.Forms.Label;

namespace BusinessPlanWriter
{
    public partial class TaskPaneControl : UserControl
    {
        //Stops new form opening when button is clicked twice
        Form form1 = new Section1();
        Form form2 = new Section2();
        Form form3 = new Section3();
        Form form4 = new Section4();
        Form form5 = new Section5();
        Form form6 = new Section6();
        Form form7 = new Section7();



        public TaskPaneControl()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Business Plan Writer -Title Text
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form1.Show();
                //System.Windows.Forms.MessageBox.Show("Section 1 Clicked");
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form2.Show();
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form3.Show();
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form4.Show();
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form5.Show();
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form6.Show();
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form7.Show();
            }
        }

        private void TaskPaneControl_Load(object sender, EventArgs e)
        {

        }
    }
}
