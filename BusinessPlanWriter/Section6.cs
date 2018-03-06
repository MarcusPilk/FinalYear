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
    public partial class Section6 : Form
    {
        public Section6()
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

        private void Section6_Load(object sender, EventArgs e)
        {

        }
    }
}
