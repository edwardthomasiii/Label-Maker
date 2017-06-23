namespace Label_Maker
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TxtSheetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxColName = new System.Windows.Forms.TextBox();
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
            this.CreatePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UploadPanel.SuspendLayout();
            this.CreatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TxtFileName
            // 
            this.TxtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFileName.Location = new System.Drawing.Point(227, 29);
            this.TxtFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(755, 29);
            this.TxtFileName.TabIndex = 0;
            this.TxtFileName.TextChanged += new System.EventHandler(this.TxtFileName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.RV);
            this.panel1.Location = new System.Drawing.Point(56, 414);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 351);
            this.panel1.TabIndex = 2;
            // 
            // RV
            // 
            this.RV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource5.Name = "ds";
            reportDataSource5.Value = null;
            this.RV.LocalReport.DataSources.Add(reportDataSource5);
            this.RV.LocalReport.ReportEmbeddedResource = "Label_Maker.Battery_Labels.rdlc";
            this.RV.Location = new System.Drawing.Point(0, 0);
            this.RV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RV.Name = "RV";
            this.RV.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.RV.ShowFindControls = false;
            this.RV.ShowPrintButton = false;
            this.RV.ShowZoomControl = false;
            this.RV.Size = new System.Drawing.Size(987, 347);
            this.RV.TabIndex = 1;
            // 
            // TxtSheetName
            // 
            this.TxtSheetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSheetName.Location = new System.Drawing.Point(299, 77);
            this.TxtSheetName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSheetName.Name = "TxtSheetName";
            this.TxtSheetName.Size = new System.Drawing.Size(265, 29);
            this.TxtSheetName.TabIndex = 4;
            this.TxtSheetName.Text = "Sheet1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sheet Name in Excel File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Column Name";
            // 
            // TxtBoxColName
            // 
            this.TxtBoxColName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxColName.Location = new System.Drawing.Point(727, 77);
            this.TxtBoxColName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBoxColName.Name = "TxtBoxColName";
            this.TxtBoxColName.Size = new System.Drawing.Size(265, 29);
            this.TxtBoxColName.TabIndex = 8;
            this.TxtBoxColName.Text = "Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Label_Maker.Properties.Resources.LESTERSCCALOGO;
            this.pictureBox1.Location = new System.Drawing.Point(19, 130);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 131);
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
            this.XXlBtn.Location = new System.Drawing.Point(14, 13);
            this.XXlBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XXlBtn.Name = "XXlBtn";
            this.XXlBtn.Size = new System.Drawing.Size(187, 63);
            this.XXlBtn.TabIndex = 13;
            this.XXlBtn.Text = "Get File";
            this.XXlBtn.UseVisualStyleBackColor = false;
            this.XXlBtn.Click += new System.EventHandler(this.XlBtn_Click);
            // 
            // SlotButton
            // 
            this.SlotButton.BackColor = System.Drawing.Color.Transparent;
            this.SlotButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlotButton.BackgroundImage")));
            this.SlotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlotButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SlotButton.FlatAppearance.BorderSize = 0;
            this.SlotButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SlotButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SlotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlotButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlotButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SlotButton.Location = new System.Drawing.Point(4, 4);
            this.SlotButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SlotButton.Name = "SlotButton";
            this.SlotButton.Size = new System.Drawing.Size(234, 63);
            this.SlotButton.TabIndex = 14;
            this.SlotButton.Text = "Slot Labels";
            this.SlotButton.UseVisualStyleBackColor = false;
            this.SlotButton.Click += new System.EventHandler(this.SlotBtn_Click);
            // 
            // SLotNoBarButton
            // 
            this.SLotNoBarButton.BackColor = System.Drawing.Color.Transparent;
            this.SLotNoBarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SLotNoBarButton.BackgroundImage")));
            this.SLotNoBarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SLotNoBarButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SLotNoBarButton.FlatAppearance.BorderSize = 0;
            this.SLotNoBarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SLotNoBarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SLotNoBarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SLotNoBarButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLotNoBarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SLotNoBarButton.Location = new System.Drawing.Point(4, 75);
            this.SLotNoBarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SLotNoBarButton.Name = "SLotNoBarButton";
            this.SLotNoBarButton.Size = new System.Drawing.Size(234, 99);
            this.SLotNoBarButton.TabIndex = 15;
            this.SLotNoBarButton.Text = "Slot Labels\r\n(No Bar Code)";
            this.SLotNoBarButton.UseVisualStyleBackColor = false;
            this.SLotNoBarButton.Click += new System.EventHandler(this.SlotsNoBarBtn_Click);
            // 
            // VehicleButton
            // 
            this.VehicleButton.BackColor = System.Drawing.Color.Transparent;
            this.VehicleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VehicleButton.BackgroundImage")));
            this.VehicleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VehicleButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.VehicleButton.FlatAppearance.BorderSize = 0;
            this.VehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VehicleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VehicleButton.Location = new System.Drawing.Point(246, 4);
            this.VehicleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VehicleButton.Name = "VehicleButton";
            this.VehicleButton.Size = new System.Drawing.Size(234, 63);
            this.VehicleButton.TabIndex = 15;
            this.VehicleButton.Text = "Vehicle Labels";
            this.VehicleButton.UseVisualStyleBackColor = false;
            this.VehicleButton.Click += new System.EventHandler(this.VehicleBtn_Click);
            // 
            // BatteryButton
            // 
            this.BatteryButton.BackColor = System.Drawing.Color.Transparent;
            this.BatteryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BatteryButton.BackgroundImage")));
            this.BatteryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BatteryButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BatteryButton.FlatAppearance.BorderSize = 0;
            this.BatteryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BatteryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BatteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatteryButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BatteryButton.Location = new System.Drawing.Point(482, 4);
            this.BatteryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BatteryButton.Name = "BatteryButton";
            this.BatteryButton.Size = new System.Drawing.Size(234, 63);
            this.BatteryButton.TabIndex = 16;
            this.BatteryButton.Text = "Battery Labels";
            this.BatteryButton.UseVisualStyleBackColor = false;
            this.BatteryButton.Click += new System.EventHandler(this.BattBtn_Click);
            // 
            // ChargerButton
            // 
            this.ChargerButton.BackColor = System.Drawing.Color.Transparent;
            this.ChargerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChargerButton.BackgroundImage")));
            this.ChargerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChargerButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ChargerButton.FlatAppearance.BorderSize = 0;
            this.ChargerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ChargerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ChargerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChargerButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChargerButton.Location = new System.Drawing.Point(478, 75);
            this.ChargerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChargerButton.Name = "ChargerButton";
            this.ChargerButton.Size = new System.Drawing.Size(234, 86);
            this.ChargerButton.TabIndex = 17;
            this.ChargerButton.Text = "Charger Labels";
            this.ChargerButton.UseVisualStyleBackColor = false;
            this.ChargerButton.Click += new System.EventHandler(this.ChargerBtn_Click);
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
            this.SingleShotButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleShotButton.Location = new System.Drawing.Point(58, 12);
            this.SingleShotButton.Name = "SingleShotButton";
            this.SingleShotButton.Size = new System.Drawing.Size(274, 80);
            this.SingleShotButton.TabIndex = 18;
            this.SingleShotButton.Text = "Multi Label input";
            this.SingleShotButton.UseVisualStyleBackColor = false;
            this.SingleShotButton.Click += new System.EventHandler(this.SingleShotButton_Click);
            // 
            // SingleLabelTxtBox
            // 
            this.SingleLabelTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleLabelTxtBox.Location = new System.Drawing.Point(563, 36);
            this.SingleLabelTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.SingleLabelTxtBox.Name = "SingleLabelTxtBox";
            this.SingleLabelTxtBox.Size = new System.Drawing.Size(159, 29);
            this.SingleLabelTxtBox.TabIndex = 19;
            this.SingleLabelTxtBox.TextChanged += new System.EventHandler(this.SingleLabelTxtBox_TextChanged);
            // 
            // UploadPanel
            // 
            this.UploadPanel.BackColor = System.Drawing.Color.Transparent;
            this.UploadPanel.Controls.Add(this.XXlBtn);
            this.UploadPanel.Controls.Add(this.TxtFileName);
            this.UploadPanel.Controls.Add(this.TxtSheetName);
            this.UploadPanel.Controls.Add(this.label1);
            this.UploadPanel.Controls.Add(this.label2);
            this.UploadPanel.Controls.Add(this.TxtBoxColName);
            this.UploadPanel.Location = new System.Drawing.Point(30, 289);
            this.UploadPanel.Name = "UploadPanel";
            this.UploadPanel.Size = new System.Drawing.Size(1028, 113);
            this.UploadPanel.TabIndex = 20;
            this.UploadPanel.Visible = false;
            // 
            // CreatePanel
            // 
            this.CreatePanel.BackColor = System.Drawing.Color.Transparent;
            this.CreatePanel.Controls.Add(this.SlotButton);
            this.CreatePanel.Controls.Add(this.SLotNoBarButton);
            this.CreatePanel.Controls.Add(this.VehicleButton);
            this.CreatePanel.Controls.Add(this.ChargerButton);
            this.CreatePanel.Controls.Add(this.BatteryButton);
            this.CreatePanel.Location = new System.Drawing.Point(345, 104);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(713, 179);
            this.CreatePanel.TabIndex = 2;
            this.CreatePanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Input Label ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::Label_Maker.Properties.Resources.MTCSilouhetteLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 778);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreatePanel);
            this.Controls.Add(this.UploadPanel);
            this.Controls.Add(this.SingleLabelTxtBox);
            this.Controls.Add(this.SingleShotButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "CCA Label Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UploadPanel.ResumeLayout(false);
            this.UploadPanel.PerformLayout();
            this.CreatePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TxtFileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtSheetName;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer RV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxColName;
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
    }
}

