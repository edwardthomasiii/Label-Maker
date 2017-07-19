namespace Label_Wizard
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.FileLocation = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SheetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.XXlBtn = new Elliptical_Button.Elliptical_Button();
            this.SlotButton = new Elliptical_Button.Elliptical_Button();
            this.SLotNoBarButton = new Elliptical_Button.Elliptical_Button();
            this.VehicleButton = new Elliptical_Button.Elliptical_Button();
            this.BatteryButton = new Elliptical_Button.Elliptical_Button();
            this.ChargerButton = new Elliptical_Button.Elliptical_Button();
            this.SingleShotButton = new Elliptical_Button.Elliptical_Button();
            this.SingleLabelTxtBox = new System.Windows.Forms.TextBox();
            this.UploadPanel = new System.Windows.Forms.Panel();
            this.ExcelPanel = new System.Windows.Forms.Panel();
            this.HeaderBtn = new Elliptical_Button.Elliptical_Button();
            this.HeaderTextBox = new System.Windows.Forms.TextBox();
            this.CreatePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SingleLabelPanel = new System.Windows.Forms.Panel();
            this.HelpBtn = new Elliptical_Button.Elliptical_Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UploadPanel.SuspendLayout();
            this.ExcelPanel.SuspendLayout();
            this.CreatePanel.SuspendLayout();
            this.SingleLabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            this.ofd.Filter = "Excel 97-2003 Workbook(*.xls)|*.xls|Excel Workbook(*.xlsx)|*.xlsx| CSV(MS-DOS)(*." +
    "csv) |*.csv";
            // 
            // FileLocation
            // 
            this.FileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLocation.Location = new System.Drawing.Point(210, 30);
            this.FileLocation.Margin = new System.Windows.Forms.Padding(4);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(901, 29);
            this.FileLocation.TabIndex = 0;
            this.FileLocation.TextChanged += new System.EventHandler(this.FileLocation_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Viewer);
            this.panel1.Location = new System.Drawing.Point(13, 334);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 395);
            this.panel1.TabIndex = 2;
            // 
            // Viewer
            // 
            this.Viewer.AllowDrop = true;
            this.Viewer.AutoScroll = true;
            this.Viewer.AutoSize = true;
            this.Viewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer.Font = new System.Drawing.Font("Tahoma", 28F);
            reportDataSource3.Name = "ds";
            reportDataSource3.Value = null;
            this.Viewer.LocalReport.DataSources.Add(reportDataSource3);
            this.Viewer.LocalReport.EnableExternalImages = true;
            this.Viewer.LocalReport.EnableHyperlinks = true;
            this.Viewer.LocalReport.ReportEmbeddedResource = "Label_Wizard.Battery_Labels.rdlc";
            this.Viewer.Location = new System.Drawing.Point(0, 0);
            this.Viewer.Margin = new System.Windows.Forms.Padding(8);
            this.Viewer.Name = "Viewer";
            this.Viewer.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.Viewer.ShowFindControls = false;
            this.Viewer.ShowPrintButton = false;
            this.Viewer.ShowZoomControl = false;
            this.Viewer.Size = new System.Drawing.Size(980, 391);
            this.Viewer.TabIndex = 1;
            // 
            // SheetName
            // 
            this.SheetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetName.Location = new System.Drawing.Point(127, 16);
            this.SheetName.Margin = new System.Windows.Forms.Padding(4);
            this.SheetName.Name = "SheetName";
            this.SheetName.Size = new System.Drawing.Size(265, 29);
            this.SheetName.TabIndex = 4;
            this.SheetName.Text = "Sheet1";
            this.SheetName.TextChanged += new System.EventHandler(this.SheetName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sheet Name\r\nin Excel File";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Label_Wizard.Properties.Resources.LESTERSCCALOGO;
            this.pictureBox1.Location = new System.Drawing.Point(1038, 458);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // XXlBtn
            // 
            this.XXlBtn.BackColor = System.Drawing.Color.Transparent;
            this.XXlBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("XXlBtn.BackgroundImage")));
            this.XXlBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.XXlBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.XXlBtn.FlatAppearance.BorderSize = 0;
            this.XXlBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.XXlBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.XXlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XXlBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XXlBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.XXlBtn.Location = new System.Drawing.Point(15, 13);
            this.XXlBtn.Margin = new System.Windows.Forms.Padding(4);
            this.XXlBtn.Name = "XXlBtn";
            this.XXlBtn.Size = new System.Drawing.Size(187, 63);
            this.XXlBtn.TabIndex = 13;
            this.XXlBtn.Text = "Get File";
            this.XXlBtn.UseVisualStyleBackColor = false;
            this.XXlBtn.Click += new System.EventHandler(this.XXlBtn_Click);
            // 
            // SlotButton
            // 
            this.SlotButton.BackColor = System.Drawing.Color.Transparent;
            this.SlotButton.BackgroundImage = global::Label_Wizard.Properties.Resources.DisabledMirror;
            this.SlotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlotButton.Enabled = false;
            this.SlotButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SlotButton.FlatAppearance.BorderSize = 0;
            this.SlotButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SlotButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SlotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlotButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlotButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SlotButton.Location = new System.Drawing.Point(18, 13);
            this.SlotButton.Margin = new System.Windows.Forms.Padding(4);
            this.SlotButton.Name = "SlotButton";
            this.SlotButton.Size = new System.Drawing.Size(234, 63);
            this.SlotButton.TabIndex = 14;
            this.SlotButton.Text = "Slot Labels";
            this.SlotButton.UseVisualStyleBackColor = false;
            this.SlotButton.Click += new System.EventHandler(this.SlotButton_Click);
            // 
            // SLotNoBarButton
            // 
            this.SLotNoBarButton.BackColor = System.Drawing.Color.Transparent;
            this.SLotNoBarButton.BackgroundImage = global::Label_Wizard.Properties.Resources.DisabledMirror;
            this.SLotNoBarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SLotNoBarButton.Enabled = false;
            this.SLotNoBarButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SLotNoBarButton.FlatAppearance.BorderSize = 0;
            this.SLotNoBarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SLotNoBarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SLotNoBarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SLotNoBarButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLotNoBarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SLotNoBarButton.Location = new System.Drawing.Point(254, 13);
            this.SLotNoBarButton.Margin = new System.Windows.Forms.Padding(4);
            this.SLotNoBarButton.Name = "SLotNoBarButton";
            this.SLotNoBarButton.Size = new System.Drawing.Size(234, 65);
            this.SLotNoBarButton.TabIndex = 15;
            this.SLotNoBarButton.Text = "Slot Labels\r\n(No Bar Code)";
            this.SLotNoBarButton.UseVisualStyleBackColor = false;
            this.SLotNoBarButton.Click += new System.EventHandler(this.SLotNoBarButton_Click);
            // 
            // VehicleButton
            // 
            this.VehicleButton.BackColor = System.Drawing.Color.Transparent;
            this.VehicleButton.BackgroundImage = global::Label_Wizard.Properties.Resources.DisabledMirror;
            this.VehicleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VehicleButton.Enabled = false;
            this.VehicleButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.VehicleButton.FlatAppearance.BorderSize = 0;
            this.VehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VehicleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VehicleButton.Location = new System.Drawing.Point(496, 13);
            this.VehicleButton.Margin = new System.Windows.Forms.Padding(4);
            this.VehicleButton.Name = "VehicleButton";
            this.VehicleButton.Size = new System.Drawing.Size(234, 63);
            this.VehicleButton.TabIndex = 15;
            this.VehicleButton.Text = "Vehicle Labels";
            this.VehicleButton.UseVisualStyleBackColor = false;
            this.VehicleButton.Click += new System.EventHandler(this.VehicleButton_Click);
            // 
            // BatteryButton
            // 
            this.BatteryButton.BackColor = System.Drawing.Color.Transparent;
            this.BatteryButton.BackgroundImage = global::Label_Wizard.Properties.Resources.DisabledMirror;
            this.BatteryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BatteryButton.Enabled = false;
            this.BatteryButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BatteryButton.FlatAppearance.BorderSize = 0;
            this.BatteryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BatteryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BatteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatteryButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BatteryButton.Location = new System.Drawing.Point(977, 12);
            this.BatteryButton.Margin = new System.Windows.Forms.Padding(4);
            this.BatteryButton.Name = "BatteryButton";
            this.BatteryButton.Size = new System.Drawing.Size(234, 63);
            this.BatteryButton.TabIndex = 16;
            this.BatteryButton.Text = "Battery Labels";
            this.BatteryButton.UseVisualStyleBackColor = false;
            this.BatteryButton.Click += new System.EventHandler(this.BatteryButton_Click);
            // 
            // ChargerButton
            // 
            this.ChargerButton.BackColor = System.Drawing.Color.Transparent;
            this.ChargerButton.BackgroundImage = global::Label_Wizard.Properties.Resources.DisabledMirror;
            this.ChargerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChargerButton.Enabled = false;
            this.ChargerButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ChargerButton.FlatAppearance.BorderSize = 0;
            this.ChargerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ChargerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ChargerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChargerButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChargerButton.Location = new System.Drawing.Point(738, 13);
            this.ChargerButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChargerButton.Name = "ChargerButton";
            this.ChargerButton.Size = new System.Drawing.Size(230, 60);
            this.ChargerButton.TabIndex = 17;
            this.ChargerButton.Text = "Charger Labels";
            this.ChargerButton.UseVisualStyleBackColor = false;
            this.ChargerButton.Click += new System.EventHandler(this.ChargerButton_Click);
            // 
            // SingleShotButton
            // 
            this.SingleShotButton.BackColor = System.Drawing.Color.Transparent;
            this.SingleShotButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SingleShotButton.BackgroundImage")));
            this.SingleShotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SingleShotButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SingleShotButton.FlatAppearance.BorderSize = 0;
            this.SingleShotButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SingleShotButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SingleShotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingleShotButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.SingleShotButton.ForeColor = System.Drawing.Color.White;
            this.SingleShotButton.Location = new System.Drawing.Point(224, 28);
            this.SingleShotButton.Name = "SingleShotButton";
            this.SingleShotButton.Size = new System.Drawing.Size(234, 64);
            this.SingleShotButton.TabIndex = 18;
            this.SingleShotButton.Text = "Multi Label input";
            this.SingleShotButton.UseVisualStyleBackColor = false;
            this.SingleShotButton.Click += new System.EventHandler(this.SingleShotButton_Click);
            // 
            // SingleLabelTxtBox
            // 
            this.SingleLabelTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleLabelTxtBox.Location = new System.Drawing.Point(136, 4);
            this.SingleLabelTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.SingleLabelTxtBox.Name = "SingleLabelTxtBox";
            this.SingleLabelTxtBox.Size = new System.Drawing.Size(159, 29);
            this.SingleLabelTxtBox.TabIndex = 19;
            this.SingleLabelTxtBox.TextChanged += new System.EventHandler(this.SingleLabelTxtBox_TextChanged);
            // 
            // UploadPanel
            // 
            this.UploadPanel.BackColor = System.Drawing.Color.Transparent;
            this.UploadPanel.Controls.Add(this.ExcelPanel);
            this.UploadPanel.Controls.Add(this.XXlBtn);
            this.UploadPanel.Controls.Add(this.FileLocation);
            this.UploadPanel.Location = new System.Drawing.Point(15, 200);
            this.UploadPanel.Name = "UploadPanel";
            this.UploadPanel.Size = new System.Drawing.Size(1236, 127);
            this.UploadPanel.TabIndex = 20;
            this.UploadPanel.Visible = false;
            // 
            // ExcelPanel
            // 
            this.ExcelPanel.Controls.Add(this.HeaderBtn);
            this.ExcelPanel.Controls.Add(this.HeaderTextBox);
            this.ExcelPanel.Controls.Add(this.label1);
            this.ExcelPanel.Controls.Add(this.SheetName);
            this.ExcelPanel.Location = new System.Drawing.Point(210, 66);
            this.ExcelPanel.Name = "ExcelPanel";
            this.ExcelPanel.Size = new System.Drawing.Size(923, 61);
            this.ExcelPanel.TabIndex = 14;
            this.ExcelPanel.Visible = false;
            // 
            // HeaderBtn
            // 
            this.HeaderBtn.BackColor = System.Drawing.Color.Transparent;
            this.HeaderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeaderBtn.BackgroundImage")));
            this.HeaderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeaderBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.HeaderBtn.FlatAppearance.BorderSize = 0;
            this.HeaderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HeaderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HeaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HeaderBtn.Location = new System.Drawing.Point(400, 7);
            this.HeaderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderBtn.Name = "HeaderBtn";
            this.HeaderBtn.Size = new System.Drawing.Size(228, 46);
            this.HeaderBtn.TabIndex = 15;
            this.HeaderBtn.Text = "Have Header?";
            this.HeaderBtn.UseVisualStyleBackColor = false;
            this.HeaderBtn.Click += new System.EventHandler(this.HeaderBtn_Click);
            // 
            // HeaderTextBox
            // 
            this.HeaderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderTextBox.Location = new System.Drawing.Point(636, 16);
            this.HeaderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderTextBox.Name = "HeaderTextBox";
            this.HeaderTextBox.Size = new System.Drawing.Size(265, 29);
            this.HeaderTextBox.TabIndex = 6;
            this.HeaderTextBox.Text = "F1";
            this.HeaderTextBox.Visible = false;
            this.HeaderTextBox.TextChanged += new System.EventHandler(this.HeaderTextBox_TextChanged);
            // 
            // CreatePanel
            // 
            this.CreatePanel.BackColor = System.Drawing.Color.Transparent;
            this.CreatePanel.Controls.Add(this.SlotButton);
            this.CreatePanel.Controls.Add(this.SLotNoBarButton);
            this.CreatePanel.Controls.Add(this.VehicleButton);
            this.CreatePanel.Controls.Add(this.ChargerButton);
            this.CreatePanel.Controls.Add(this.BatteryButton);
            this.CreatePanel.Location = new System.Drawing.Point(12, 115);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(1239, 93);
            this.CreatePanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Input Label ID";
            // 
            // SingleLabelPanel
            // 
            this.SingleLabelPanel.BackColor = System.Drawing.Color.Transparent;
            this.SingleLabelPanel.Controls.Add(this.label3);
            this.SingleLabelPanel.Controls.Add(this.SingleLabelTxtBox);
            this.SingleLabelPanel.Location = new System.Drawing.Point(723, 21);
            this.SingleLabelPanel.Name = "SingleLabelPanel";
            this.SingleLabelPanel.Size = new System.Drawing.Size(334, 71);
            this.SingleLabelPanel.TabIndex = 22;
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.Transparent;
            this.HelpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HelpBtn.BackgroundImage")));
            this.HelpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HelpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            this.HelpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HelpBtn.Location = new System.Drawing.Point(30, 25);
            this.HelpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(187, 63);
            this.HelpBtn.TabIndex = 14;
            this.HelpBtn.Text = "Instructions\r\n";
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::Label_Wizard.Properties.Resources.MTCSilouhetteLogo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 778);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.SingleLabelPanel);
            this.Controls.Add(this.CreatePanel);
            this.Controls.Add(this.SingleShotButton);
            this.Controls.Add(this.UploadPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CCA Label Wizard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UploadPanel.ResumeLayout(false);
            this.UploadPanel.PerformLayout();
            this.ExcelPanel.ResumeLayout(false);
            this.ExcelPanel.PerformLayout();
            this.CreatePanel.ResumeLayout(false);
            this.SingleLabelPanel.ResumeLayout(false);
            this.SingleLabelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox FileLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SheetName;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer Viewer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Elliptical_Button.Elliptical_Button XXlBtn;
        private Elliptical_Button.Elliptical_Button SLotNoBarButton;
        private Elliptical_Button.Elliptical_Button SlotButton;
        private Elliptical_Button.Elliptical_Button VehicleButton;
        private Elliptical_Button.Elliptical_Button BatteryButton;
        private Elliptical_Button.Elliptical_Button ChargerButton;
        private Elliptical_Button.Elliptical_Button SingleShotButton;
        private System.Windows.Forms.TextBox SingleLabelTxtBox;
        private System.Windows.Forms.Panel UploadPanel;
        private System.Windows.Forms.Panel CreatePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel SingleLabelPanel;
        private Elliptical_Button.Elliptical_Button HelpBtn;
        private System.Windows.Forms.Panel ExcelPanel;
        private System.Windows.Forms.TextBox HeaderTextBox;
        private Elliptical_Button.Elliptical_Button HeaderBtn;
    }
}

