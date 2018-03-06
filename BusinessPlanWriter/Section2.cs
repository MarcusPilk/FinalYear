using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessPlanWriter
{
    public partial class Section2 : Form
    {
        TableCreator tableForm1 = new TableCreator("2.1");
        TableCreator tableForm2 = new TableCreator("2.2");
        TableCreator tableForm3 = new TableCreator("2.3");
        TableCreator tableForm4 = new TableCreator("2.4");
        public Section2()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;

        }

        private void Section2_Load(object sender, EventArgs e)
        {

        }

        private void CompanySummary_Click(object sender, EventArgs e)
        {

        }

        private void createTable1_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Create Table Button");
            tableForm1.Show();
            createTable1.Text = "Edit Table";

        }
        private void createTable2_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Create Table Button");
            tableForm2.Show();
            createTable2.Text = "Edit Table";

        }
        private void createTable3_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Create Table Button");
            tableForm3.Show();
            createTable3.Text = "Edit Table";

        }
        private void createTable4_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Create Table Button");
            tableForm4.Show();
            createTable4.Text = "Edit Table";

        }
    }
}
