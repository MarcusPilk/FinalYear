using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Office.Interop.Excel;
using Spire.Pdf.General.Render.Font.OpenTypeFile;
using Spire.Xls;

namespace BusinessPlanWriter
{
    public partial class TableCreator : Form
    {
        //public static DataTable dataTable = new DataTable();
        private String[,] dataArrayList;
        private String[,] dataSeriesList;


        public TableCreator()
        {
            InitializeComponent();


//            int height = Screen.PrimaryScreen.WorkingArea.Height;
//            int width = Screen.PrimaryScreen.WorkingArea.Width;

//            this.Width = width;
//            this.Height = height;
//            dataView.Width = (int) (width - (width * 0.05));
//            dataView.Height = (int) (height - (height * 0.5));
//
//            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
//            resetTable.Location = new Point(workingArea.Left-150,workingArea.Bottom -100);
//            submitTable.Location = new Point(workingArea.Left - 100, workingArea.Bottom - 100);
        }

        private void bindData(String[,] array)
        {
            double x = 0.5;
            double y = 1.5;
            chart1.Series.Clear();

            for (int i = 0;i < dataView.RowCount-1; i++)
            {
                string seriesName = "Row: " + (i + 1);
                chart1.Series.Add(seriesName);
            }

            for (int i = 0; i <= array.GetUpperBound(1); i++)
            {
                ArrayList list = new ArrayList();

                for (int j = 0; j <= array.GetUpperBound(0); j++)
                {
                    int strToInt = Convert.ToInt32(array[j, i]);
                    list.Add(strToInt);
                }
                chart1.Series[i].Points.DataBindY(list);


            }
            int c = 0;
            foreach (var VARIABLE in dataView.Columns)
            {
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(x, y,dataView.Columns[c].Name );
                x++;
                c++;
                y++;
            }
            chart1.SaveImage("E:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\chart1.png", System.Drawing.Imaging.ImageFormat.Png);
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


        public static IEnumerable<T> SliceColumn<T>(T[,] array, int column)
        {
            for (var i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                yield return array[i, column];
            }
        }
        public static IEnumerable<T> SliceRow<T>(T[,] array, int row)
        {
            for (var i = array.GetLowerBound(1); i <= array.GetUpperBound(1); i++)
            {
                yield return array[row, i];
            }

        }

        




        private void submitTable_Click(object sender, EventArgs e)
        {
            int rows = dataView.RowCount-1;
            int cols = dataView.ColumnCount;
            Console.Out.WriteLine(rows + "  " + cols);
            dataArrayList = new string[rows,cols]; //check for null
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataArrayList[i, j] = dataView.Rows[i].Cells[j].Value.ToString();
                }
            }

            dataSeriesList = new string[cols,rows];
            for (int i = 0 ; i <= dataSeriesList.GetUpperBound(0); i++)
            {
                for (int j = 0 ; j <= dataSeriesList.GetUpperBound(1); j++)
                {
                    dataSeriesList[i, j] = dataArrayList[j, i];
                }
            }

            bindData(dataSeriesList);
            

            // Debug table creator
            //StringBuilder sb = new StringBuilder();
            //foreach (var VARIABLE in dataArrayList)
            //{
            //    sb.Append(VARIABLE.ToString());
            //}
            //MessageBox.Show(sb.ToString());

        }

        private void delColumn_Click(object sender, EventArgs e)
        {
            dataView.Columns.RemoveAt(dataView.ColumnCount-1);
        }

        private void resetTable_Click(object sender, EventArgs e)
        {
            dataView.Rows.Clear();
            dataView.Columns.Clear();
        }

        private void TableCreator_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString().Trim())
            {
                case "Bar":
                    chart1.Series[0].ChartType = SeriesChartType.Bar;
                    break;
                case "Column":
                    chart1.Series[0].ChartType = SeriesChartType.Column;
                    break;
                case "Pie":
                    chart1.Series[0].ChartType = SeriesChartType.Pie;
                    break;
                case "Line":
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    break;
                default:
                    chart1.Series[0].ChartType = SeriesChartType.Bar;
                    break;
            }
        }
    }
}
