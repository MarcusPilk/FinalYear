using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools;
using CheckBox = System.Windows.Forms.CheckBox;
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
        CheckBox[] checkboxes;
       



        public TaskPaneControl()
        {
            InitializeComponent();
            this.checkboxes = new System.Windows.Forms.CheckBox[]{checkBox1,checkBox2,checkBox3,checkBox4,checkBox5,checkBox6,checkBox7};
            foreach (System.Windows.Forms.CheckBox cb in checkboxes)
            {
                cb.CheckedChanged += checkboxWasClicked;
            }
        }

        private void checkboxWasClicked(object sender, EventArgs e)
        {
            progressBar1.Value = (int)(((float)this.checkboxes.Count(cb => cb.Checked) / this.checkboxes.Length) * 100);
            if (progressBar1.Value == 100)
            {
                pdfButton.Visible = true;
            }
            else
            {
                pdfButton.Visible = false;
            }

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void egBP_Click(object sender, EventArgs e)
        {

        }
    }
}
