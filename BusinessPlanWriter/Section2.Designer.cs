namespace BusinessPlanWriter
{
    partial class Section2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CompanySummary = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.createTable1 = new System.Windows.Forms.Button();
            this.StartupSummary = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.createTable2 = new System.Windows.Forms.Button();
            this.CompanyHistory = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.createTable3 = new System.Windows.Forms.Button();
            this.LocationFacilities = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.createTable4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.CompanySummary.SuspendLayout();
            this.StartupSummary.SuspendLayout();
            this.CompanyHistory.SuspendLayout();
            this.LocationFacilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CompanySummary);
            this.tabControl1.Controls.Add(this.StartupSummary);
            this.tabControl1.Controls.Add(this.CompanyHistory);
            this.tabControl1.Controls.Add(this.LocationFacilities);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 564);
            this.tabControl1.TabIndex = 0;
            // 
            // CompanySummary
            // 
            this.CompanySummary.Controls.Add(this.textBox1);
            this.CompanySummary.Controls.Add(this.createTable1);
            this.CompanySummary.Location = new System.Drawing.Point(4, 22);
            this.CompanySummary.Name = "CompanySummary";
            this.CompanySummary.Padding = new System.Windows.Forms.Padding(3);
            this.CompanySummary.Size = new System.Drawing.Size(561, 538);
            this.CompanySummary.TabIndex = 0;
            this.CompanySummary.Text = "Company Summary";
            this.CompanySummary.UseVisualStyleBackColor = true;
            this.CompanySummary.Click += new System.EventHandler(this.CompanySummary_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 469);
            this.textBox1.TabIndex = 12;
            // 
            // createTable1
            // 
            this.createTable1.Location = new System.Drawing.Point(466, 509);
            this.createTable1.Name = "createTable1";
            this.createTable1.Size = new System.Drawing.Size(88, 23);
            this.createTable1.TabIndex = 11;
            this.createTable1.Text = "Create Table";
            this.createTable1.UseVisualStyleBackColor = true;
            this.createTable1.Click += new System.EventHandler(this.createTable1_Click);
            // 
            // StartupSummary
            // 
            this.StartupSummary.Controls.Add(this.textBox2);
            this.StartupSummary.Controls.Add(this.createTable2);
            this.StartupSummary.Location = new System.Drawing.Point(4, 22);
            this.StartupSummary.Name = "StartupSummary";
            this.StartupSummary.Padding = new System.Windows.Forms.Padding(3);
            this.StartupSummary.Size = new System.Drawing.Size(561, 538);
            this.StartupSummary.TabIndex = 1;
            this.StartupSummary.Text = "Startup Summary";
            this.StartupSummary.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 35);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(548, 469);
            this.textBox2.TabIndex = 13;
            // 
            // createTable2
            // 
            this.createTable2.Location = new System.Drawing.Point(466, 509);
            this.createTable2.Name = "createTable2";
            this.createTable2.Size = new System.Drawing.Size(88, 23);
            this.createTable2.TabIndex = 12;
            this.createTable2.Text = "Create Table";
            this.createTable2.UseVisualStyleBackColor = true;
            this.createTable2.Click += new System.EventHandler(this.createTable2_Click);
            // 
            // CompanyHistory
            // 
            this.CompanyHistory.Controls.Add(this.textBox3);
            this.CompanyHistory.Controls.Add(this.createTable3);
            this.CompanyHistory.Location = new System.Drawing.Point(4, 22);
            this.CompanyHistory.Name = "CompanyHistory";
            this.CompanyHistory.Size = new System.Drawing.Size(561, 538);
            this.CompanyHistory.TabIndex = 2;
            this.CompanyHistory.Text = "Company History";
            this.CompanyHistory.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 35);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(548, 469);
            this.textBox3.TabIndex = 13;
            // 
            // createTable3
            // 
            this.createTable3.Location = new System.Drawing.Point(463, 509);
            this.createTable3.Name = "createTable3";
            this.createTable3.Size = new System.Drawing.Size(88, 23);
            this.createTable3.TabIndex = 12;
            this.createTable3.Text = "Create Table";
            this.createTable3.UseVisualStyleBackColor = true;
            this.createTable3.Click += new System.EventHandler(this.createTable3_Click);
            // 
            // LocationFacilities
            // 
            this.LocationFacilities.Controls.Add(this.textBox4);
            this.LocationFacilities.Controls.Add(this.createTable4);
            this.LocationFacilities.Location = new System.Drawing.Point(4, 22);
            this.LocationFacilities.Name = "LocationFacilities";
            this.LocationFacilities.Size = new System.Drawing.Size(561, 538);
            this.LocationFacilities.TabIndex = 3;
            this.LocationFacilities.Text = "Location and Facilities";
            this.LocationFacilities.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 35);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(548, 469);
            this.textBox4.TabIndex = 13;
            // 
            // createTable4
            // 
            this.createTable4.Location = new System.Drawing.Point(463, 509);
            this.createTable4.Name = "createTable4";
            this.createTable4.Size = new System.Drawing.Size(88, 23);
            this.createTable4.TabIndex = 12;
            this.createTable4.Text = "Create Table";
            this.createTable4.UseVisualStyleBackColor = true;
            this.createTable4.Click += new System.EventHandler(this.createTable4_Click);
            // 
            // Section2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(594, 614);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Section2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Section 2";
            this.Load += new System.EventHandler(this.Section2_Load);
            this.tabControl1.ResumeLayout(false);
            this.CompanySummary.ResumeLayout(false);
            this.CompanySummary.PerformLayout();
            this.StartupSummary.ResumeLayout(false);
            this.StartupSummary.PerformLayout();
            this.CompanyHistory.ResumeLayout(false);
            this.CompanyHistory.PerformLayout();
            this.LocationFacilities.ResumeLayout(false);
            this.LocationFacilities.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CompanySummary;
        private System.Windows.Forms.TabPage StartupSummary;
        private System.Windows.Forms.TabPage CompanyHistory;
        private System.Windows.Forms.TabPage LocationFacilities;
        private System.Windows.Forms.Button createTable1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button createTable2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button createTable3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button createTable4;
    }
}