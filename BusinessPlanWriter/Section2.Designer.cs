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
            this.StartupSummary = new System.Windows.Forms.TabPage();
            this.CompanyHistory = new System.Windows.Forms.TabPage();
            this.LocationFacilities = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(569, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // CompanySummary
            // 
            this.CompanySummary.Controls.Add(this.textBox1);
            this.CompanySummary.Location = new System.Drawing.Point(4, 22);
            this.CompanySummary.Name = "CompanySummary";
            this.CompanySummary.Padding = new System.Windows.Forms.Padding(3);
            this.CompanySummary.Size = new System.Drawing.Size(561, 563);
            this.CompanySummary.TabIndex = 0;
            this.CompanySummary.Text = "Company Summary";
            this.CompanySummary.UseVisualStyleBackColor = true;
            this.CompanySummary.Click += new System.EventHandler(this.CompanySummary_Click);
            // 
            // StartupSummary
            // 
            this.StartupSummary.Controls.Add(this.textBox2);
            this.StartupSummary.Location = new System.Drawing.Point(4, 22);
            this.StartupSummary.Name = "StartupSummary";
            this.StartupSummary.Padding = new System.Windows.Forms.Padding(3);
            this.StartupSummary.Size = new System.Drawing.Size(561, 563);
            this.StartupSummary.TabIndex = 1;
            this.StartupSummary.Text = "Startup Summary";
            this.StartupSummary.UseVisualStyleBackColor = true;
            // 
            // CompanyHistory
            // 
            this.CompanyHistory.Controls.Add(this.textBox3);
            this.CompanyHistory.Location = new System.Drawing.Point(4, 22);
            this.CompanyHistory.Name = "CompanyHistory";
            this.CompanyHistory.Size = new System.Drawing.Size(561, 563);
            this.CompanyHistory.TabIndex = 2;
            this.CompanyHistory.Text = "Company History";
            this.CompanyHistory.UseVisualStyleBackColor = true;
            // 
            // LocationFacilities
            // 
            this.LocationFacilities.Controls.Add(this.textBox4);
            this.LocationFacilities.Location = new System.Drawing.Point(4, 22);
            this.LocationFacilities.Name = "LocationFacilities";
            this.LocationFacilities.Size = new System.Drawing.Size(561, 563);
            this.LocationFacilities.TabIndex = 3;
            this.LocationFacilities.Text = "Location and Facilities";
            this.LocationFacilities.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 500);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(548, 500);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(548, 500);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(548, 500);
            this.textBox4.TabIndex = 1;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}