﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;

namespace BusinessPlanWriter
{
    public partial class BPRibbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btn_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet cuWorksheet = Globals.ThisAddIn.GetWorksheet();
        }
    }
}