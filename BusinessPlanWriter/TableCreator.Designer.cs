namespace BusinessPlanWriter
{
    partial class TableCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableCreator));
            this.dataView = new System.Windows.Forms.DataGridView();
            this.addColumn = new System.Windows.Forms.Button();
            this.colName = new System.Windows.Forms.TextBox();
            this.submitTable = new System.Windows.Forms.Button();
            this.resetTable = new System.Windows.Forms.Button();
            this.delColumn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pasteData = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.AllowDrop = true;
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataView.Location = new System.Drawing.Point(13, 78);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.Size = new System.Drawing.Size(569, 255);
            this.dataView.TabIndex = 0;
            // 
            // addColumn
            // 
            this.addColumn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addColumn.Location = new System.Drawing.Point(507, 48);
            this.addColumn.Name = "addColumn";
            this.addColumn.Size = new System.Drawing.Size(75, 20);
            this.addColumn.TabIndex = 1;
            this.addColumn.Text = "New Column";
            this.addColumn.UseVisualStyleBackColor = true;
            this.addColumn.Click += new System.EventHandler(this.addColumn_Click);
            // 
            // colName
            // 
            this.colName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colName.Location = new System.Drawing.Point(329, 48);
            this.colName.Name = "colName";
            this.colName.Size = new System.Drawing.Size(172, 20);
            this.colName.TabIndex = 2;
            // 
            // submitTable
            // 
            this.submitTable.Location = new System.Drawing.Point(93, 580);
            this.submitTable.Name = "submitTable";
            this.submitTable.Size = new System.Drawing.Size(75, 23);
            this.submitTable.TabIndex = 3;
            this.submitTable.Text = "Refresh";
            this.submitTable.UseVisualStyleBackColor = true;
            this.submitTable.Click += new System.EventHandler(this.submitTable_Click);
            // 
            // resetTable
            // 
            this.resetTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetTable.Location = new System.Drawing.Point(12, 580);
            this.resetTable.Name = "resetTable";
            this.resetTable.Size = new System.Drawing.Size(75, 23);
            this.resetTable.TabIndex = 4;
            this.resetTable.Text = "Reset";
            this.resetTable.UseVisualStyleBackColor = true;
            this.resetTable.Click += new System.EventHandler(this.resetTable_Click);
            // 
            // delColumn
            // 
            this.delColumn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.delColumn.Location = new System.Drawing.Point(248, 47);
            this.delColumn.Name = "delColumn";
            this.delColumn.Size = new System.Drawing.Size(75, 20);
            this.delColumn.TabIndex = 5;
            this.delColumn.Text = "Delete Column";
            this.delColumn.UseVisualStyleBackColor = true;
            this.delColumn.Click += new System.EventHandler(this.delColumn_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 340);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(570, 234);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tables and Charts";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Column",
            "Bar",
            "Pie",
            "Line"});
            this.comboBox1.Location = new System.Drawing.Point(175, 580);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pasteData
            // 
            this.pasteData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pasteData.Location = new System.Drawing.Point(13, 48);
            this.pasteData.Name = "pasteData";
            this.pasteData.Size = new System.Drawing.Size(75, 19);
            this.pasteData.TabIndex = 11;
            this.pasteData.Text = "Paste";
            this.pasteData.UseVisualStyleBackColor = true;
            this.pasteData.Click += new System.EventHandler(this.pasteData_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(404, 580);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // TableCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(594, 614);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pasteData);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.delColumn);
            this.Controls.Add(this.resetTable);
            this.Controls.Add(this.submitTable);
            this.Controls.Add(this.colName);
            this.Controls.Add(this.addColumn);
            this.Controls.Add(this.dataView);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Creator";
            this.Load += new System.EventHandler(this.TableCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addColumn;
        private System.Windows.Forms.TextBox colName;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button submitTable;
        private System.Windows.Forms.Button resetTable;
        private System.Windows.Forms.Button delColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button pasteData;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}