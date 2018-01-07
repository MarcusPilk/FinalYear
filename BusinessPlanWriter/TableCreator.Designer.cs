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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.addColumn = new System.Windows.Forms.Button();
            this.colName = new System.Windows.Forms.TextBox();
            this.submitTable = new System.Windows.Forms.Button();
            this.resetTable = new System.Windows.Forms.Button();
            this.delColumn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(13, 78);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(569, 495);
            this.dataView.TabIndex = 0;
            // 
            // addColumn
            // 
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
            this.colName.Location = new System.Drawing.Point(329, 48);
            this.colName.Name = "colName";
            this.colName.Size = new System.Drawing.Size(172, 20);
            this.colName.TabIndex = 2;
            // 
            // submitTable
            // 
            this.submitTable.Location = new System.Drawing.Point(506, 580);
            this.submitTable.Name = "submitTable";
            this.submitTable.Size = new System.Drawing.Size(75, 23);
            this.submitTable.TabIndex = 3;
            this.submitTable.Text = "Done";
            this.submitTable.UseVisualStyleBackColor = true;
            this.submitTable.Click += new System.EventHandler(this.submitTable_Click);
            // 
            // resetTable
            // 
            this.resetTable.Location = new System.Drawing.Point(425, 580);
            this.resetTable.Name = "resetTable";
            this.resetTable.Size = new System.Drawing.Size(75, 23);
            this.resetTable.TabIndex = 4;
            this.resetTable.Text = "Reset";
            this.resetTable.UseVisualStyleBackColor = true;
            // 
            // delColumn
            // 
            this.delColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.delColumn.Location = new System.Drawing.Point(248, 47);
            this.delColumn.Name = "delColumn";
            this.delColumn.Size = new System.Drawing.Size(75, 20);
            this.delColumn.TabIndex = 5;
            this.delColumn.Text = "Delete Column";
            this.delColumn.UseVisualStyleBackColor = true;
            this.delColumn.Click += new System.EventHandler(this.delColumn_Click);
            // 
            // TableCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(594, 614);
            this.Controls.Add(this.delColumn);
            this.Controls.Add(this.resetTable);
            this.Controls.Add(this.submitTable);
            this.Controls.Add(this.colName);
            this.Controls.Add(this.addColumn);
            this.Controls.Add(this.dataView);
            this.HelpButton = true;
            this.Name = "TableCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Creator";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
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
    }
}