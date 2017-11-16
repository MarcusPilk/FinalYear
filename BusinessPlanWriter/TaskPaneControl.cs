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
        Form form = new Section_1();

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
                form.Show();
                //System.Windows.Forms.MessageBox.Show("Section 1 Clicked");
            }
        }

        private void TaskPaneControl_Load(object sender, EventArgs e)
        {

        }
    }
}
