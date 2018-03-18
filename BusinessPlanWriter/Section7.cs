using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Spire.Xls;
using Spire.Xls.Core.Spreadsheet;
using Application = Microsoft.Office.Interop.Excel.Application;
using Borders = Microsoft.Office.Interop.Excel.Borders;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
using XlLineStyle = Microsoft.Office.Interop.Excel.XlLineStyle;

namespace BusinessPlanWriter
{
    public partial class Section7 : Form
    {
        public string cellrg = ""; 
        public Section7()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

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

        private void Section7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Add Column
            dataGridView1.Columns.Add(textBox1.Text, textBox1.Text);
            dataGridView2.Columns.Add("", "");
            dataGridView3.Columns.Add("", "");
            dataGridView4.Columns.Add("", "");
            dataGridView5.Columns.Add("", "");
            }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.RemoveAt(dataGridView1.ColumnCount-1);
            dataGridView2.Columns.RemoveAt(dataGridView1.ColumnCount - 1);
            dataGridView3.Columns.RemoveAt(dataGridView1.ColumnCount - 1);
            dataGridView4.Columns.RemoveAt(dataGridView1.ColumnCount - 1);
            dataGridView5.Columns.RemoveAt(dataGridView1.ColumnCount - 1);

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateDGV();
        }

        private void updateDGV()
        {
            //DGV1
            double total = 0.0;
            try
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (dataGridView1[col.Index, 0].Value == null || dataGridView1[col.Index, 0].Value.ToString().Any(chr => char.IsLetter(chr)))
                    {
                        dataGridView2[col.Index, 0].Value = null;
                    }
                    else
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            if (dataGridView1[col.Index, i].Value == null)
                            {
                                total += 0;
                            }
                            else
                            {
                                string val = dataGridView1[col.Index, i].Value.ToString();
                                double dVal = Convert.ToDouble(val);
                                total += dVal;
                            }

                        }
                        dataGridView2[col.Index, 0].Value = total.ToString();
                    }
                    total = 0;
                }
                //DGV3
                total = 0.0;
                foreach (DataGridViewColumn col in dataGridView3.Columns)
                {
                    if (dataGridView3[col.Index, 0].Value == null || dataGridView3[col.Index, 0].Value.ToString().Any(chr => char.IsLetter(chr)) || dataGridView1[col.Index, 0].Value.ToString().Any(chr => char.IsLetter(chr)))
                    {
                        dataGridView4[col.Index, 0].Value = null;
                    }
                    else
                    {
                        for (int i = 0; i < dataGridView3.RowCount - 1; i++)
                        {
                            if (dataGridView3[col.Index, i].Value == null)
                            {
                                total += 0;
                            }
                            else
                            {
                                string val = dataGridView3[col.Index, i].Value.ToString();
                                double dVal = Convert.ToDouble(val);
                                total += dVal;
                            }

                        }
                        dataGridView4[col.Index, 0].Value = total.ToString();
                    }
                    total = 0;
                }
            }
            catch
            {

            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.ThisAddIn.setCurrency(comboBox1.SelectedItem.ToString());
            MessageBox.Show("Currency changed to: " + Globals.ThisAddIn.getCurrency());

        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateDGV();
        }

        private void Section7_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                dataGridView1.Height = 350;
                dataGridView3.Height = 350;
            }
            else
            {
                dataGridView1.Height = 170;
                dataGridView3.Height = 170;
            }


        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0.0;
            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                if (dataGridView2[col.Index, 0].Value == null  &&
                    dataGridView4[col.Index, 0].Value == null )
                {
                    dataGridView5[col.Index, 0].Value = "";
                }
                else if (dataGridView2[col.Index, 0].Value == null)
                {
                    dataGridView5[col.Index, 0].Value =
                        (0 - Convert.ToDouble(dataGridView4[col.Index, 0].Value.ToString())).ToString();
                }
                else if (dataGridView4[col.Index, 0].Value == null)
                {
                    dataGridView5[col.Index, 0].Value =
                        (0 + Convert.ToDouble(dataGridView2[col.Index, 0].Value.ToString())).ToString();
                }
                else
                {
                    string val1 = dataGridView2[col.Index, 0].Value.ToString();
                    double dVal1 = Convert.ToDouble(val1);
                    string val2 = dataGridView4[col.Index, 0].Value.ToString();
                    double dVal2 = Convert.ToDouble(val2);
                    total += dVal1 - dVal2;
                    dataGridView5[col.Index, 0].Value = total.ToString();
                }
                
                total = 0;
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            //create cashflow worksheet
            string name = "Cash Flow";
            bool exists = false;
            Workbook wb = Globals.ThisAddIn.Application.ActiveWorkbook; 
            foreach (Worksheet sheets in wb.Worksheets )
            {
                if (sheets.Name.Equals(name))
                {
                    sheets.Activate();
                    sheets.Visible = XlSheetVisibility.xlSheetVisible;
                    exists = true;
                    sheets.Cells.ClearContents();
                }
                
            }
            if (!exists)
            {
                {
                    Worksheet newWorksheet;
                    newWorksheet = (Worksheet)Globals.ThisAddIn.Application.Worksheets.Add();
                    newWorksheet.Name = name;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Would you like to add a total column?", "Row Totals", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView1.Columns.Add("Total", "Total");
                dataGridView2.Columns.Add("", "");
                dataGridView3.Columns.Add("", "");
                dataGridView4.Columns.Add("", "");
                dataGridView5.Columns.Add("", "");
                int x = dataGridView1.ColumnCount - 1;
                double total = 0.0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        int y = row.Index;
                        for (int i = 1; i < x; i++)
                        {
                            string a = dataGridView1[i, y].Value.ToString();
                            double d = Convert.ToDouble(a);
                            total += d;
                        }
                        dataGridView1[x, y].Value = total.ToString();
                        total = 0;
                    }
                    catch
                    {
                        
                    }
                }
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    int y = row.Index;
                    for (int i = 1; i < x; i++)
                    {
                        total += Convert.ToDouble(dataGridView2[i, y].Value.ToString());
                    }
                    dataGridView2[x, y].Value = total.ToString();
                    total = 0;
                }
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    try
                    {
                        int y = row.Index;
                        for (int i = 1; i < x; i++)
                        {
                            total += Convert.ToDouble(dataGridView3[i, y].Value.ToString());
                        }
                        dataGridView3[x, y].Value = total.ToString();
                        total = 0;
                    }
                    catch
                    {
                        
                    }
                }
                foreach (DataGridViewRow row in dataGridView4.Rows)
                {
                    int y = row.Index;
                    for (int i = 1; i < x; i++)
                    {
                        total += Convert.ToDouble(dataGridView4[i, y].Value.ToString());
                    }
                    dataGridView4[x, y].Value = total.ToString();
                    total = 0;
                }
                foreach (DataGridViewRow row in dataGridView5.Rows)
                {
                    int y = row.Index;
                    for (int i = 1; i < x; i++)
                    {
                        total += Convert.ToDouble(dataGridView5[i, y].Value.ToString());
                    }
                    dataGridView5[x, y].Value = total.ToString();
                    total = 0;
                }
            }

            // Excel Heading
            int range = 1;
            char c = 'A';
            string cellRngLength = ((char)(c + (dataGridView1.ColumnCount-1))).ToString();
            cellrg = cellRngLength + range;
            Worksheet ws = Globals.ThisAddIn.GetWorksheet();
            ws.Cells[1, 1] = "Cash Flow Forecast";
            string cellRng = "A" + range;
            ws.Range[cellRng].Font.Size = 20;
            ws.Range[cellRng].Font.Bold = true;

            // Excel Subheading
            range++;
            ws.Cells[2, 1] = "Income";
            cellRng = "A" + range;
            ws.Range[cellRng].Font.Size = 14;

            //Extract Income
            range++;
            cellRng = "A" + range;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            ws.Range[cellRng].Select();
            ws.PasteSpecial(ws.Range[cellRng], Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            dataGridView1.RowHeadersVisible = true;

            range += dataGridView1.RowCount;
            cellRng = "A" + range;
            cellrg = cellRngLength + range;

            Borders border = ws.Range[cellRng, cellrg].Borders;
            border[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlDouble;

            // Extract Total
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectAll();
            dataObj = dataGridView2.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            ws.Range[cellRng].Select();
            ws.PasteSpecial(ws.Range[cellRng], Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            dataGridView2.RowHeadersVisible = true;

            // Excel Subheading
            range++;
            ws.Cells[range, 1] = "Expenses";
            cellRng = "A" + range;
            ws.Range[cellRng].Font.Size = 14;

            //Extract Expenses
            range++;
            cellRng = "A" + range;

            dataGridView3.RowHeadersVisible = false;
            dataGridView3.SelectAll();
            dataObj = dataGridView3.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            ws.Range[cellRng].Select();
            ws.PasteSpecial(ws.Range[cellRng], Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            dataGridView3.RowHeadersVisible = true;

            range += dataGridView3.RowCount-1;
            cellRng = "A" + range;
            cellrg = cellRngLength + range;

            border = ws.Range[cellRng, cellrg].Borders;
            border[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlDouble;


            // Extract Total
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.SelectAll();
            dataObj = dataGridView4.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            ws.Range[cellRng].Select();
            ws.PasteSpecial(ws.Range[cellRng], Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            dataGridView4.RowHeadersVisible = true;

            // Excel Subheading
            range++;
            ws.Cells[range, 1] = "Total";
            cellRng = "A" + range;
            ws.Range[cellRng].Font.Size = 14;

            //Extract Total
            range++;
            cellRng = "A" + range;

            dataGridView5.RowHeadersVisible = false;
            dataGridView5.SelectAll();
            dataObj = dataGridView5.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            ws.Range[cellRng].Select();
            ws.PasteSpecial(ws.Range[cellRng], Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            dataGridView5.RowHeadersVisible = true;
            range++;
            cellRng = "A" + range;
            cellrg = cellRngLength + range;

            ws.Range["B4", cellrg].NumberFormat = ThisAddIn.currency+ "#,###.00";
            string topR = cellRngLength + "3";

            border = ws.Range[topR, cellrg].Borders;
            border[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            ws.Range["A1"].EntireColumn.AutoFit();

            this.Hide();

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            dataGridView5.Rows.Clear();
            dataGridView5.Columns.Clear();

        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dataGridView1.RowCount > 0)
                    dataGridView1.Rows.Clear();

                if (dataGridView1.ColumnCount > 0)
                    dataGridView1.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                int j = 0;
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                        {
                            dataGridView1.Columns.Add(pastedRowCells[i], pastedRowCells[i]);
                            dataGridView2.Columns.Add("", "");
                            dataGridView3.Columns.Add("", "");
                            dataGridView4.Columns.Add("", "");
                            dataGridView5.Columns.Add("", "");
                        }

                        columnsAdded = true;
                        continue;
                    }

                    dataGridView1.Rows.Add();
                    int myRowIndex = dataGridView1.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dataGridView1.Rows[j])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
                    }
                    j++;
                }
            }
        }

        private void pasteButton2_Click(object sender, EventArgs e)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dataGridView3.RowCount > 0)
                {
                    dataGridView3.Rows.Clear();
                }
                    

//                if (dataGridView3.ColumnCount > 0)
//                    dataGridView3.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                int j = 0;
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

//                    if (!columnsAdded)
//                    {
//                        for (int i = 0; i < pastedRowCells.Length; i++)
//                            dataGridView3.Columns.Add("","");
//
//                        columnsAdded = true;
//                        continue;
//                    }

                    dataGridView3.Rows.Add();
                    int myRowIndex = dataGridView3.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dataGridView3.Rows[j])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
                    }
                    j++;
                }
            }
        }

        public void save_All(StreamWriter writer, string path)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (dataGridView1.ColumnCount == 0)
            {
                writer.WriteLine("ARRAY EMPTY");
            }
            else
            {
                stringBuilder.Append("ARRAY " + dataGridView1.ColumnCount.ToString() + "," +
                                     (dataGridView1.RowCount - 1).ToString() + "\r\n");
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (dataGridView1.Columns[i].Name == null)
                    {
                        stringBuilder.Append(" ,");
                    }
                    else
                    {
                        stringBuilder.Append(dataGridView1.Columns[i].Name + ",");
                    }
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                        {
                            
                        }
                        else
                        {
                            stringBuilder.Append(cell.Value.ToString() + ",");

                        }

                    }
                }
            }

            stringBuilder.Append("\r\n");

                if (dataGridView3.ColumnCount == 0)
                {
                    writer.WriteLine("ARRAY EMPTY");
                }
                else
                {
                    stringBuilder.Append("ARRAY " + dataGridView3.ColumnCount.ToString() + "," +
                                         (dataGridView3.RowCount - 1).ToString() + "\r\n");

                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value == null)
                            {

                            }
                            else
                            {
                                stringBuilder.Append(cell.Value.ToString() + ",");

                            }
                    }
                    }

                }
            writer.WriteLine(stringBuilder.ToString());


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void load_All(StreamReader reader)
        {
            String s = reader.ReadLine();
            if (s.Contains("ARRAY EMPTY"))
            {
            }
            else
            {
                s = s.Replace("ARRAY", String.Empty);
                String[] elements = Regex.Split(s, ",");
                var col = Convert.ToInt32(elements[0]);
                var row = Convert.ToInt32(elements[1]);
                String[] tableData = Regex.Split(reader.ReadLine(), ",");
                int e = 0;
                dataGridView1.ColumnCount = col;
                dataGridView2.ColumnCount = col;
                dataGridView3.ColumnCount = col;
                dataGridView4.ColumnCount = col;
                dataGridView5.ColumnCount = col;
                for (int i = 0; i < col; i++)
                {
                    if (tableData[e] == null || tableData[e] == "")
                    {
                        dataGridView1.Columns[i].Name = "";
                    }
                    else
                    {
                        dataGridView1.Columns[i].Name = tableData[e];
                    }
                    e++;
                }

                for (int i = 0; i < row; i++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    for (int j = 0; j < col; j++)
                    {
                        if (tableData[e] == null || tableData[e] == "")
                        {
                            newRow.Cells[j].Value = "";
                        }
                        else
                        {
                            newRow.Cells[j].Value = tableData[e];
                        }
                        e++;
                    }
                    dataGridView1.Rows.Add(newRow);

                }


            }

            s = reader.ReadLine();
            if (s.Contains("ARRAY EMPTY"))
            {
            }
            else
            {
                s = s.Replace("ARRAY", String.Empty);
                String[] elements = Regex.Split(s, ",");
                var col = Convert.ToInt32(elements[0]);
                var row = Convert.ToInt32(elements[1]);
                String[] tableData = Regex.Split(reader.ReadLine(), ",");
                int e = 0;

                for (int i = 0; i < row; i++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView3);
                    for (int j = 0; j < col; j++)
                    {
                        if (tableData[e] == null || tableData[e] == "")
                        {
                            newRow.Cells[j].Value = "";
                        }
                        else
                        {
                            newRow.Cells[j].Value = tableData[e];
                        }
                        e++;
                    }
                    dataGridView3.Rows.Add(newRow);

                }


            }
            updateDGV();
        }
    }
}
