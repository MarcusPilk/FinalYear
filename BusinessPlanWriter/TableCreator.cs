using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessPlanWriter
{
    public partial class TableCreator : Form
    {
        //public static DataTable dataTable = new DataTable();
        private String[,] dataArrayList;
      
      
        public TableCreator()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void addColumn_Click(object sender, EventArgs e)
        {
            String s = colName.Text;
            dataView.Columns.Add(s, s);
            colName.Clear();
        }

        private void submitTable_Click(object sender, EventArgs e)
        {
            int rows = dataView.RowCount-1;
            int cols = dataView.ColumnCount;
            Console.Out.WriteLine(rows + "  " + cols);
            dataArrayList = new string[rows,cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataArrayList[i, j] = dataView.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Debug table creator
            StringBuilder sb = new StringBuilder();
            foreach (var VARIABLE in dataArrayList)
            {
                sb.Append(VARIABLE.ToString());
            }
            MessageBox.Show(sb.ToString());

        }

        private void delColumn_Click(object sender, EventArgs e)
        {
            dataView.Columns.RemoveAt(dataView.ColumnCount-1);
        }
    }
}
