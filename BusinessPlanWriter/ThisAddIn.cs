using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;

namespace BusinessPlanWriter
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            myUserControl1 = new TaskPaneControl();
            myCustomTaskPane = this.CustomTaskPanes.Add(myUserControl1, "Business Plan Writer");
            myCustomTaskPane.VisibleChanged += new EventHandler(myCustomTaskPane_VisibleChanged);
        }



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



        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public Excel.Worksheet GetWorksheet()
        {
            Excel.Worksheet wS = (Excel.Worksheet) Application.ActiveSheet;
            String n = wS.Name;
            System.Windows.Forms.MessageBox.Show(n);
            return (Excel.Worksheet) Application.ActiveSheet;
        }

        private TaskPaneControl myUserControl1;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;
        private Section_1 section1Form;
        private Form mySection1Form;
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
    }




    }
