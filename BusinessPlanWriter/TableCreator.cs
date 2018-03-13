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
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Office.Interop.Excel;
using Spire.Pdf.General.Render.Font.OpenTypeFile;
using Spire.Xls;
using ListBox = System.Windows.Forms.ListBox;
using Series = Microsoft.Office.Interop.Excel.Series;

namespace BusinessPlanWriter
{
    public partial class TableCreator : Form
    {
        //public static DataTable dataTable = new DataTable();
        private String[,] dataArrayList;
        private String[,] dataSeriesList;
        private String name;
        private static int chartPalette = 0;


        public TableCreator(String name)
        {
            InitializeComponent();
            this.name = name;


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
                                 //row1 col 1                    //row2 col1
            //MessageBox.Show(array[0, 0].ToString() + "\r\n" + array[0,1].ToString());
            //check if first col = row names
            if (array[0, 0].Any(chr => char.IsLetter(chr)))
            {
                for (int i = 0; i < dataView.RowCount - 1; i++)
                {
                    string seriesName = array[0, i].ToString();
                    chart1.Series.Add(seriesName);
                }

                for (int i = 0; i <= array.GetUpperBound(1); i++)
                {
                    ArrayList list = new ArrayList();

                    for (int j = 1; j <= array.GetUpperBound(0); j++)
                    {
                        int strToInt = Convert.ToInt32(array[j, i]);
                        list.Add(strToInt);
                    }
                    chart1.Series[i].Points.DataBindY(list);

              }

                int c = 1;

                for (int i = 1; i < dataView.ColumnCount ; i++)
                {
                    chart1.ChartAreas[0].AxisX.CustomLabels.Add(x, y, dataView.Columns[i].Name);
                    x++;
                    y++;
                }
            }
            else
            {

                for (int i = 0; i < dataView.RowCount - 1; i++)
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
                    chart1.ChartAreas[0].AxisX.CustomLabels.Add(x, y, dataView.Columns[c].Name);
                    x++;
                    c++;
                    y++;
                }
            }

            
            chart1.SaveImage("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\"+name+ ".png", System.Drawing.Imaging.ImageFormat.Png);
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
            dataArrayList = new string[rows,cols]; //check for null
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataArrayList[i, j] = dataView.Rows[i].Cells[j].Value.ToString();
                }
            }
            //check if first col = row names
            if (dataArrayList[0, 0].Any(x => !char.IsLetter(x)))
            {
                
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
            if (dataView.CurrentCell == null)
            {
                dataView.Columns.RemoveAt(dataView.ColumnCount - 1);

            }
            else
            {
                dataView.Columns.RemoveAt(dataView.CurrentCell.ColumnIndex);

            }
        }

        private void resetTable_Click(object sender, EventArgs e)
        {
            dataView.Rows.Clear();
            dataView.Columns.Clear();
            chart1.Series.Clear();
            chart1.Annotations.Clear();
        }



        private void TableCreator_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString().Trim())
            {
                case "Bar":
                    foreach (var series in chart1.Series)
                    {
                        series.ChartType = SeriesChartType.Bar;
                    }
                    chart1.SaveImage("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\" + name + ".png", System.Drawing.Imaging.ImageFormat.Png);

                    break;
                case "Column":
                    foreach (var series in chart1.Series)
                    {
                        series.ChartType = SeriesChartType.Column;
                    }
                    chart1.SaveImage("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\" + name + ".png", System.Drawing.Imaging.ImageFormat.Png);

                    break;
                case "Pie":
                    MessageBox.Show("Please be aware, if you have more than one row filled in, the Pie Chart will not show correctly.\r\nPlease choose a different chart to prevent loss of data during display ");
                    foreach (var series in chart1.Series)
                    {
                        series.ChartType = SeriesChartType.Pie;
                    }
                    chart1.SaveImage("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\" + name + ".png", System.Drawing.Imaging.ImageFormat.Png);

                    break;
                case "Line":
                    foreach (var series in chart1.Series)
                    {
                        series.ChartType = SeriesChartType.Line;
                    }
                    chart1.SaveImage("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\" + name + ".png", System.Drawing.Imaging.ImageFormat.Png);

                    break;
                default:
                    foreach (var series in chart1.Series)
                    {
                        series.ChartType = SeriesChartType.Column;
                    }
                    chart1.SaveImage("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\" + name + ".png", System.Drawing.Imaging.ImageFormat.Png);

                    break;
            }
        }
        internal string save_All(string path)
        {
            String dataToString = "";
            if (dataArrayList == null)
            {
                return "ARRAY EMPTY";
            }
            else
            {
                dataToString += "ARRAY " + (dataArrayList.GetUpperBound(0) + 1) + "," +
                                (dataArrayList.GetUpperBound(1) + 1) + "\r\n";
                for (int i = 0; i <= dataArrayList.GetUpperBound(1); i++)
                {
                    dataToString += dataView.Columns[i].Name + ",";
                }


                for (int i = 0; i <= dataArrayList.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= dataArrayList.GetUpperBound(1); j++)
                    {
                        if (j == dataArrayList.GetUpperBound(1) && i == dataArrayList.GetUpperBound(0))
                        {
                            dataToString += dataArrayList[i, j];
                        }
                        else
                        {
                            dataToString += dataArrayList[i, j] + ",";
                        }
                    }
                }
                return dataToString;
            }

        }

        // Parsing reader means it continues from where it stopped.
        public void load_All(OpenFileDialog openFileDialog, StreamReader reader)
        {
            
            String s = reader.ReadLine();
            if (s.Contains("ARRAY EMPTY"))
            {
                return;
            }
            else
            {
                s = s.Replace("ARRAY", String.Empty);
                String[] elements = Regex.Split(s, ",");
                var x = Convert.ToInt32(elements[0]);
                var y = Convert.ToInt32(elements[1]);
                String[] dataElements = Regex.Split(reader.ReadLine(), ",");
                int e = 0;
                dataView.ColumnCount = y;

                for (int i=0; i < y ;i++)
                {
                    dataView.Columns[i].Name = dataElements[e];
                    e++;
                }

                for (int i = 0; i < x; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataView);
                    for (int j = 0; j < y; j++)
                    {
                        row.Cells[j].Value = dataElements[e];
                        e++;
                    }
                    dataView.Rows.Add(row);
                }
                submitTable_Click(this, EventArgs.Empty); //recreate table
            }
        }

        private void pasteData_Click(object sender, EventArgs e)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dataView.RowCount > 0)
                    dataView.Rows.Clear();

                if (dataView.ColumnCount > 0)
                    dataView.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                int j = 0;
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            dataView.Columns.Add(pastedRowCells[i], pastedRowCells[i]);

                        columnsAdded = true;
                        continue;
                    }

                    dataView.Rows.Add();
                    int myRowIndex = dataView.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dataView.Rows[j])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
                    }
                    j++;
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            switch (chartPalette%13)
            {
                case 0:
                    chart1.Palette = ChartColorPalette.None;
                    chartPalette++;
                    break;
                case 1:
                    chart1.Palette = ChartColorPalette.Bright;
                    chartPalette++;
                    break;
                case 2:
                    chart1.Palette = ChartColorPalette.BrightPastel;
                    chartPalette++;
                    break;
                case 3:
                    chart1.Palette = ChartColorPalette.Berry;
                    chartPalette++;
                    break;
                case 4:
                    chart1.Palette = ChartColorPalette.Chocolate;
                    chartPalette++;
                    break;
                case 5:
                    chart1.Palette = ChartColorPalette.EarthTones;
                    chartPalette++;
                    break;
                case 6:
                    chart1.Palette = ChartColorPalette.Excel;
                    chartPalette++;
                    break;
                case 7:
                    chart1.Palette = ChartColorPalette.Fire;
                    chartPalette++;
                    break;
                case 8:
                    chart1.Palette = ChartColorPalette.Grayscale;
                    chartPalette++;
                    break;
                case 9:
                    chart1.Palette = ChartColorPalette.Light;
                    chartPalette++;
                    break;
                case 10:
                    chart1.Palette = ChartColorPalette.Pastel;
                    chartPalette++;
                    break;
                case 11:
                    chart1.Palette = ChartColorPalette.SeaGreen;
                    chartPalette++;
                    break;
                case 12:
                    chart1.Palette = ChartColorPalette.SemiTransparent;
                    chartPalette++;
                    break;
                    default:
                        chart1.Palette = ChartColorPalette.Pastel;
                        chartPalette++;
                        break;
            }
        }
    }
}
