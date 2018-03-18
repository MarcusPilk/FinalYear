using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools;
using Office = Microsoft.Office.Core;

namespace BusinessPlanWriter
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            myUserControl1 = new TaskPaneControl();
            myCustomTaskPane = this.CustomTaskPanes.Add(myUserControl1, "Business Plan Writer");
            myCustomTaskPane.VisibleChanged += new EventHandler(myCustomTaskPane_VisibleChanged);


            Office.CommandBar cellbar = this.Application.CommandBars["Cell"];
            Office.CommandBarButton button = (Office.CommandBarButton)cellbar.FindControl(Office.MsoControlType.msoControlButton, 0, "MYRIGHTCLICKMENU", Missing.Value, Missing.Value);
            if (button == null)
            {
                // add the button
                button = (Office.CommandBarButton)cellbar.Controls.Add(Office.MsoControlType.msoControlButton, Missing.Value, Missing.Value, cellbar.Controls.Count, true);
                button.Caption = "Check Selection";
                button.BeginGroup = true;
                button.Tag = "MYRIGHTCLICKMENU";
                button.Click += new Office._CommandBarButtonEvents_ClickEventHandler(MyButton_Click);
            }

        }
        public static string currency = "";


        private void MyButton_Click(Office.CommandBarButton ctrl, ref bool canceldefault)
        {
            Excel.Range selection = Globals.ThisAddIn.Application.Selection as Excel.Range;
            MessageBox.Show(GetWorksheet().Name + "!"+selection.AddressLocal);
        }

        public bool IsDirectoryEmpty(string path) => !Directory.EnumerateFileSystemEntries(path).Any();



        private void myCustomTaskPane_VisibleChanged(object sender, EventArgs e)
        {
            Globals.Ribbons.Ribbon.toggleButton1.Checked = myCustomTaskPane.Visible;
        }

        public Microsoft.Office.Tools.CustomTaskPane TaskPane
        {
            get
            {
                return myCustomTaskPane;
            }
        }


        public string checkCells(string text)
        {
            string output = "";
            foreach (string word in text.Split(' '))
            {
                if (word.StartsWith("<") && word.EndsWith(">"))
                {
                    //string cell = word.Split('<', '>')[1];
                    //output += "'& " + GetWorksheet().Range[cell, cell].get_Value() + "&'";
                    //output += "\"&" + cell + "&\" ";
                    Excel.Range range = Globals.ThisAddIn.Application.InputBox("Please choose a range!",
                        "Please choose a cell for referencing: " + word.Split('<', '>')[1], Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        8);
                    output += range.Text + " ";
                }
                else
                {
                    output += word + " ";
                }
            }
            //MessageBox.Show(output);

            return output;
        }




        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public Excel.Worksheet GetWorksheet()
        {
            Excel.Worksheet wS = (Excel.Worksheet) Application.ActiveSheet;
            String n = wS.Name;
            //System.Windows.Forms.MessageBox.Show(n);
            return (Excel.Worksheet) Application.ActiveSheet;
        }

        private TaskPaneControl myUserControl1;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;
        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion

        public void setCurrency(string curr)
        {
            currency = curr;
        }

        public string getCurrency()
        {
            if (currency.Length.Equals(0))
            {
                return "";
            }
            else
            {
                return currency;
            }
        }


    }




    }
