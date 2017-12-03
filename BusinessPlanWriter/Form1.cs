﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

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
            this.Hide();
            var text1 = this.textBox1.Text;
            var text2 = this.textBox2.Text;
            var text3 = this.textBox3.Text;
            var text4 = this.textBox4.Text;
            String[] strArray = new string[] { text1, text2, text3, text4 };

            Worksheet ws = Globals.ThisAddIn.GetWorksheet();
            Range range = ws.Range["A1", "D1"];

            range.Value = strArray;
        }
    }
}
