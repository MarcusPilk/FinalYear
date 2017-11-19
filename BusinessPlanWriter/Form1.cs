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
    public partial class Section_1 : Form
    {
        public Section_1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Section_1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Section_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void Section_1_FormClosing(object sender, FormClosingEventArgs e)
        {
           this.Hide();
           e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
