namespace Label_Wizard

{
    partial class Help
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HelpViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TablesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablesBindingSource
            // 
            this.TablesBindingSource.DataSource = typeof(ADOX.Tables);
            // 
            // HelpViewer
            // 
            this.HelpViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HelpViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpViewer.DocumentMapWidth = 45;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TablesBindingSource;
            this.HelpViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.HelpViewer.LocalReport.EnableHyperlinks = true;
            this.HelpViewer.LocalReport.ReportEmbeddedResource = "Label_Wizard.CCA_Label_Wizard_Manualv2.rdlc";
            this.HelpViewer.Location = new System.Drawing.Point(0, 0);
            this.HelpViewer.Name = "HelpViewer";
            this.HelpViewer.ShowPrintButton = false;
            this.HelpViewer.ShowRefreshButton = false;
            this.HelpViewer.Size = new System.Drawing.Size(1008, 724);
            this.HelpViewer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HelpViewer);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 724);
            this.panel1.TabIndex = 1;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 735);
            this.Controls.Add(this.panel1);
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer HelpViewer;
        private System.Windows.Forms.BindingSource TablesBindingSource;
        private System.Windows.Forms.Panel panel1;
    }
}