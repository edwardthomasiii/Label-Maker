using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;

namespace Label_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean Slot = false;
        public Boolean Vehicle = false;
        public Boolean Battery = false;
        public Boolean charger = false;
        public Boolean slotnobar = false;
        public string datatb = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            SetalltoFalse();
            Control[] rvtb = RV.Controls.Find("ReportToolBar", true);

        }
        private void Checknames()
        {
            string name = TxtSheetName.Text;
            string column = TxtBoxColName.Text;
            datatb = Convert.ToString(TxtFileName.Text);
            string csr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + datatb + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";
            DataTable dt = new DataTable();
            OleDbConnection con = new OleDbConnection(csr);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select Column_name from Information_Schema.columns where Like ' ["+name+"$]'" );
           cmd.CommandType = CommandType.Text;
            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            oda.Fill(dt);
            TxtBoxColName.Text = dt.Rows[0][0].ToString();
           con.Close();
            
            

        }
        private void getdigits()
        {
            //clear the report viewer out
            RV.DataBindings.Clear();
            //  Set the strings needed
            string name = TxtSheetName.Text;
            string column = TxtBoxColName.Text;
            datatb = Convert.ToString(TxtFileName.Text);
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + datatb + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";
            //set the datatable
            DataTable dt = new DataTable();
            //establish the connection
            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("SELECT  Distinct(" + column + ") FROM [" + name + "$]WHERE  (NOT ([" + column + "] IS NULL))", con);
            //the command type for the connection
            oconn.CommandType = CommandType.Text;
            //sets the data adapter
            OleDbDataAdapter Oda = new OleDbDataAdapter(oconn);


            try
            {
                //Clears the report viewer} catch ()
                RV.LocalReport.DataSources.Clear();
            }
            catch (Exception rc)
            {
                MessageBox.Show("Error Clearing Out Previous Report!!!" +Environment.NewLine+ "Error is " + rc);

            }

            //uses the datatadapter to fill the datatable
            try
            {
                Oda.Fill(dt);
            }
            catch(Exception filldt)
            {
                MessageBox.Show("Error on Filling your DataTable!!" + Environment.NewLine+ "check your sheet name or Column Name"+Environment.NewLine+" Error Log "+Environment.NewLine+ filldt);
            }
                //sets the reportdatasource
                ReportDataSource rds = new ReportDataSource("ds", dt);
                //adds the report datasource to the report
                RV.LocalReport.DataSources.Add(rds);
            //sets the report to the appropriate name
            if (Vehicle == true)
            {
                RV.LocalReport.ReportEmbeddedResource = "Label_Maker.Vehicle_Labels.rdlc";
                Vehicle = false;
            }
            else if (Slot == true)
            {
                RV.LocalReport.ReportEmbeddedResource = "Label_Maker.Slot_Labels.rdlc";
                Slot = false;
            }
            else if (Battery == true)
            {
                RV.LocalReport.ReportEmbeddedResource = "Label_Maker.Battery_Labels.rdlc";
                Battery = false;
            }
            else if (charger == true)
            {
                RV.LocalReport.ReportEmbeddedResource = "Label_Maker.Charger_Labels.rdlc";
                charger = false;
            }
            else if (slotnobar == true)
            {
                RV.LocalReport.ReportEmbeddedResource = "Label_Maker.Slot_No_BarCode_Labels.rdlc";
                slotnobar = false;
            }   
            this.RV.RefreshReport();
            this.RV.SetDisplayMode(DisplayMode.PrintLayout);
           // this.RV.LocalReport.
        }

        private void SlotBtn_Click(object sender, EventArgs e)
        {
            Slot = true;
            pokeyoke();  
        }
        private void pokeyoke()
        {
            if (TxtSheetName.Text == "")
            {MessageBox.Show("Set the Sheet Name");
                setbooleantofalse();
            }
            else if (TxtBoxColName.Text == "")
            {
                MessageBox.Show("Set The Column Name");
                setbooleantofalse();
            }
            else{getdigits();}
        }
        private void XlBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select File";
            ofd.FileName = TxtFileName.Text;
            ofd.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel version 2007(*.xls)|*xls|CSV Files (*.csv)|*.csv";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                TxtFileName.Text = ofd.FileName;

            }
        }
        private void VehicleBtn_Click(object sender, EventArgs e)
        {
            Vehicle = true;
            pokeyoke();

        }
        private void setbooleantofalse()
        { Slot = false;Vehicle = false;Battery = false;charger = false;slotnobar = false;}
        private void SetalltoFalse()
        {
            CreatePanel.Visible = false;
            VehicleButton.Enabled = false;
           SlotButton.Enabled = false;
           BatteryButton.Enabled = false;
            ChargerButton.Enabled = false;
            SLotNoBarButton.Enabled = false;
        }
        private void SetalltoTrue()
        {
            CreatePanel.Visible = true;
            VehicleButton.Enabled = true;
            SlotButton.Enabled = true;
            BatteryButton.Enabled = true;
            ChargerButton.Enabled = true;
            SLotNoBarButton.Enabled = true;
        }
        private void TxtFileName_TextChanged(object sender, EventArgs e)
        {
            if (TxtFileName.Text!= null)
            {
                SetalltoTrue();
               // Checknames();
            }
            else
            {
                SetalltoFalse();
            }
        }
        private void BattBtn_Click(object sender, EventArgs e)
        {
            Battery = true;
            pokeyoke();
        }
        private void ChargerBtn_Click(object sender, EventArgs e)
        {
            charger = true;
            pokeyoke();
        }
        private void SlotsNoBarBtn_Click(object sender, EventArgs e)
        {
            slotnobar = true;
            pokeyoke();
        }

        private void SingleShotButton_Click(object sender, EventArgs e)
        {
            if (UploadPanel.Visible == true)
            {
                singleactive();
            }
            else
            uploadactive();
        }
        private void uploadactive()
        {
            SingleShotButton.Text = "Create Single Label";
            UploadPanel.Visible = true;
            SingleLabelTxtBox.Visible = false;
            SingleLabelTxtBox.Text = null;
            CreatePanel.Visible = false;
        }
        private void singleactive()
        {
            SingleShotButton.Text = "upload Label";
            UploadPanel.Visible = false;
            SingleLabelTxtBox.Visible = true;
            TxtFileName.Text = null;
            CreatePanel.Visible = false;
        }

        private void SingleLabelTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SingleLabelTxtBox.Text != "")
            {
                CreatePanel.Visible = true;
            }
            else
                CreatePanel.Visible = false;

        }
    }
}
