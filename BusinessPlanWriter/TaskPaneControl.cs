using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools;
using CheckBox = System.Windows.Forms.CheckBox;
using Label = System.Windows.Forms.Label;
using Table = Spire.Pdf.Exporting.XPS.Schema.Table;

namespace BusinessPlanWriter
{
    public partial class TaskPaneControl : UserControl
    {
        //Stops new form opening when button is clicked twice
        Section1 form1 = new Section1();
        Section2 form2 = new Section2();
        Section3 form3 = new Section3();
        Section4 form4 = new Section4();
        Section5 form5 = new Section5();
        Section6 form6 = new Section6();
        Section7 form7 = new Section7();
        CheckBox[] checkboxes;
       



        public TaskPaneControl()
        {
            InitializeComponent();
            this.checkboxes = new System.Windows.Forms.CheckBox[]{checkBox1,checkBox2,checkBox3,checkBox4,checkBox5,checkBox6,checkBox7};
            foreach (System.Windows.Forms.CheckBox cb in checkboxes)
            {
                cb.CheckedChanged += checkboxWasClicked;
            }
        }

        private void checkboxWasClicked(object sender, EventArgs e)
        {
            progressBar1.Value = (int)(((float)this.checkboxes.Count(cb => cb.Checked) / this.checkboxes.Length) * 100);
            if (progressBar1.Value == 100)
            {
                pdfButton.Visible = true;
            }
            else
            {
                pdfButton.Visible = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form1.Show();
                //System.Windows.Forms.MessageBox.Show("Section 1 Clicked");
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form2.Show();
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form3.Show();
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form4.Show();
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form5.Show();
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form6.Show();
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Write pop up box code here
                form7.Show();
            }
        }

        private void TaskPaneControl_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void egBP_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "D:\\Documents\\compTemplate.txt";
            form1.load_All(openFileDialog);
            MessageBox.Show("Example File Loaded Successfully!");
        }

        private void saveBP_Click(object sender, EventArgs e)
        {
            // Open file browser to choose specific save destination
            //FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            //folderBrowser.ShowDialog();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save Business Plan";
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;


            MessageBox.Show(path);
            form1.save_All(path,saveFileDialog);

            
            
        }

        private void loadBP_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File|*.txt";
            openFileDialog.Title = "Open Business Plan";
            openFileDialog.ShowDialog();

            MessageBox.Show(openFileDialog.FileName);
            form1.load_All(openFileDialog);
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            createDoc();
        }

        private void createDoc()
        {
            try
            {
                //Create an instance for word app
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.
                winword.Visible = false;

                //Create a missing variable for missing value
                object missing = System.Reflection.Missing.Value;

                //Create a new document
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);


                //Add the footers into the document
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = DateTime.Today.ToLongDateString();
                }

                //adding text to document
                document.Content.SetRange(0, 0);
                document.Content.Text = "This is test document " + Environment.NewLine;

                //Add paragraph with Heading 1 style
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 1";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Text = "Executive Summary";
                para1.Range.InsertParagraphAfter();

                //Add 1.1
                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                para2.Range.Text = form1.getText(1) + Environment.NewLine; ;
                para2.Range.InsertParagraphAfter();

                //Add Chart
                Microsoft.Office.Interop.Word.Paragraph para3 = document.Content.Paragraphs.Add(ref missing);
                InlineShape pic = para3.Range.InlineShapes.AddPicture("D:\\Documents\\FinalProject\\BusinessPlanWriter\\BPWChartImages\\1.1.png");
                


                //Save the document
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF|*.pdf|Word|*.doc;*.docx";
                saveFileDialog.Title = "Export Business Plan";
                saveFileDialog.ShowDialog();

                object filename = saveFileDialog.FileName;
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
