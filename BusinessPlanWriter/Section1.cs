using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Spire.Xls;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;

namespace BusinessPlanWriter
{
    public partial class Section1 : Form
    {
        TableCreator tableForm1 = new TableCreator("1.1");
        TableCreator tableForm2 = new TableCreator("1.2");
        TableCreator tableForm3 = new TableCreator("1.3");
        TableCreator tableForm4 = new TableCreator("1.4");


        public Section1( )
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Section1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Section1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void Section1_FormClosing(object sender, FormClosingEventArgs e)
        {
           this.Hide();
           e.Cancel = true;
        }

        


        private void Section1_Activated(object sender, System.EventArgs e)
        {
                Worksheet ws1 = Globals.ThisAddIn.GetWorksheet();

                this.textBox1.Text = ws1.Range["A2", "A2"].get_Value();
                this.textBox2.Text = ws1.Range["A5", "A5"].get_Value();
                this.textBox3.Text = ws1.Range["A8", "A8"].get_Value();
                this.textBox4.Text = ws1.Range["A11", "A11"].get_Value();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var text1 = this.textBox1.Text;
            var text2 = this.textBox2.Text;
            var text3 = this.textBox3.Text;
            var text4 = this.textBox4.Text;

            Worksheet ws = Globals.ThisAddIn.GetWorksheet();
            ws.Cells[2, 1] = Globals.ThisAddIn.checkCells(text1);
            ws.Cells[5, 1] = text2;
            ws.Cells[8, 1] = text3;
            ws.Cells[11, 1] = text4;

            




            if (!Globals.ThisAddIn.IsDirectoryEmpty("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages"))
            {
                //Avoids duplicate pictures of charts
                foreach (Picture picture in ws.Pictures())
                {
                    picture.Delete();
                }

                //Insert Chart 1
                try
                {
                    Range oRange = ws.Cells[3, 1];

                    oRange.ColumnWidth = 76;
                    oRange.RowHeight = 200;
                    float Left = (float)((double)oRange.Left);
                    float Top = (float)((double)oRange.Top);
                    const float ImageSize = 200;
                    Shape picture = ws.Shapes.AddPicture("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\1.1.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize * 2, ImageSize);
                    picture.Placement = XlPlacement.xlMoveAndSize;
                }
                catch (Exception exception)
                {
                    System.Windows.Forms.MessageBox.Show("No Chart for Section 1.1");
                }

                //Insert Chart 2
                try
                {
                    Range oRange = ws.Cells[6, 1];

                    oRange.ColumnWidth = 76;
                    oRange.RowHeight = 200;
                    float Left = (float)((double)oRange.Left);
                    float Top = (float)((double)oRange.Top);
                    const float ImageSize = 200;
                    Shape picture = ws.Shapes.AddPicture("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\1.2.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize * 2, ImageSize);
                    picture.Placement = XlPlacement.xlMoveAndSize;
                }
                catch (Exception exception)
                {
                    System.Windows.Forms.MessageBox.Show("No Chart for Section 1.2");
                }

                //Insert Chart 3
                try
                {
                    Range oRange = ws.Cells[9, 1];

                    oRange.ColumnWidth = 76;
                    oRange.RowHeight = 200;
                    float Left = (float)((double)oRange.Left);
                    float Top = (float)((double)oRange.Top);
                    const float ImageSize = 200;
                    Shape picture = ws.Shapes.AddPicture("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\1.3.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize * 2, ImageSize);
                    picture.Placement = XlPlacement.xlMoveAndSize;
                }
                catch (Exception exception)
                {
                    System.Windows.Forms.MessageBox.Show("No Chart for Section 1.3");
                }

                //Insert Chart 4
                try
                {
                    Range oRange = ws.Cells[12, 1];

                    oRange.ColumnWidth = 76;
                    oRange.RowHeight = 200;
                    float Left = (float)((double)oRange.Left);
                    float Top = (float)((double)oRange.Top);
                    const float ImageSize = 200;
                    Shape picture = ws.Shapes.AddPicture("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\1.4.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize * 2, ImageSize);
                    picture.Placement = XlPlacement.xlMoveAndSize;
                }
                catch (Exception exception)
                {
                    System.Windows.Forms.MessageBox.Show("No Chart for Section 1.4");
                }

            } 

        }

        public string getText(int id)
        {
            switch (id)
            {
                case 1:
                    return textBox1.Text;
                    break;
                case 2:
                    return textBox2.Text;
                    break;
                case 3:
                    return textBox3.Text;
                    break;
                case 4:
                    return textBox4.Text;
                    break;

            }
            return "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Worksheet ws1 = Globals.ThisAddIn.GetWorksheet();

            this.textBox1.Text = ws1.Range["A2", "A2"].get_Value();
            this.textBox2.Text = ws1.Range["A5", "A5"].get_Value();
            this.textBox3.Text = ws1.Range["A8", "A8"].get_Value();
            this.textBox4.Text = ws1.Range["A11", "A11"].get_Value();
        }
        public void save_All(string path, SaveFileDialog saveFileDialog)
        {
            StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());
            writer.WriteLine(textBox1.Text.Replace(Environment.NewLine,"?</> "));
            writer.WriteLine(tableForm1.save_All(path));

            writer.WriteLine(textBox2.Text.Replace(Environment.NewLine, "?</> "));
            writer.WriteLine(tableForm2.save_All(path));

            writer.WriteLine(textBox3.Text.Replace(Environment.NewLine, "?</> "));
            writer.WriteLine(tableForm3.save_All(path));

            writer.WriteLine(textBox4.Text.Replace(Environment.NewLine, "?</> "));
            writer.WriteLine(tableForm4.save_All(path));

            writer.Dispose();
            writer.Close();

        }

        public void load_All(OpenFileDialog openFileDialog)
        {
            StreamReader reader = new StreamReader(openFileDialog.OpenFile());
            textBox1.Text = reader.ReadLine().Replace("?</> ",Environment.NewLine);
            tableForm1.load_All(openFileDialog, reader);
            textBox2.Text = reader.ReadLine().Replace("?</> ", Environment.NewLine);
            tableForm2.load_All(openFileDialog, reader);
            textBox3.Text = reader.ReadLine().Replace("?</> ", Environment.NewLine);
            tableForm3.load_All(openFileDialog, reader);
            textBox4.Text = reader.ReadLine().Replace("?</> ", Environment.NewLine);
            tableForm4.load_All(openFileDialog, reader);
            reader.Dispose();
            reader.Close();
            
        }
    }
}
