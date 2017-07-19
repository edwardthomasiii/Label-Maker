using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Data.Odbc;
using System.Linq;
using System.Collections.Generic;

namespace Label_Wizard
{

    public partial class Form1 : Form
    {
        // the public variables used to set report process in motion
        public Boolean error = false;//error trap if it finds one this event is thrownto true
        public string errortext = "";//the text to display for errors
        public string location = "";//where the file is located for datat queries
        public string Sheet = "";//this is used for excel to identify what sheet you are working off of
        public string header = ""; //this is used if you have a column header in your excel spreadsheet
        public Boolean headerswitch = false; //this is used if you do not have a header in your excel file
        public string Column = "";//this is used forthe data table to get or set the public name of the column
        public string dbl = "no";//this is used to determine if this is a double printing or not
        public Boolean Vehicle = false;//sets the vehicle reporting sequence in motion
        public Boolean Slot = false;//sets the Slot reporting sequence in motion
        public Boolean Battery = false;//sets the Battery reporting sequence in motion
        public Boolean Charger = false;//sets the charger reporting sequence in motion
        public Boolean slotnobarcode = false;//sets the slot without barcode reporting sequence in motion
        public Boolean commatrick = false;//sets the csv file process in motion
        public DataTable MasterData = new DataTable();//the datatable that is used with the csv importing function
        //this starts the whole program, leave this in place here since it run sequentially down the rows and will come up based on commands recieved for the application
        public Form1()
        {
            InitializeComponent();
        }
        //this loads the initial form on the application
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // check on header name to build the report
        private void checkheaders()
        {
            if (Path.GetExtension(FileLocation.Text) == ".csv") { commatrick = true; }
            else if (commatrick == false)
                error = false;
            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + location + ";Extended Properties='Excel 12.0 XML;HDR=No';";
            OleDbConnection con = new OleDbConnection(cs);
            OleDbCommand cmd = new OleDbCommand("select * from [" + Sheet + "$]", con);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {

                con.Open();
                try
                {
                    OleDbDataReader drd = cmd.ExecuteReader();
                    if (drd.HasRows)
                    {
                        drd.Read();
                    }
                    else
                    {
                        drd.Close();
                        con.Close();
                        error = false;
                    }
                }
                catch (Exception)
                {
                    errortext = "Check your Sheet Name Please!";
                    ErrorMessageForm emf = new ErrorMessageForm(errortext);
                    emf.ShowDialog();
                    error = true;
                }


            }

        }
        //gets the excel file for reading into the label maker
        private void XXlBtn_Click(object sender, EventArgs e)
        {
            ofd.Title = "Select File";
            ofd.FileName = FileLocation.Text;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileLocation.Text = ofd.FileName;
                if (Path.GetExtension(FileLocation.Text) == ".xlsx" || Path.GetExtension(FileLocation.Text) == ".xls")
                {
                    ExcelPanel.Visible = true;
                }
                else if (Path.GetExtension(FileLocation.Text) == ".csv" | SingleLabelPanel.Visible == true)
                {
                    ExcelPanel.Visible = false;
                }
            }
        }
        //generates labels based on textbox instad of a datatable import from excel
        private void SingleShotButton_Click(object sender, EventArgs e)
        {
            disabledbutton();
            if (SingleLabelPanel.Visible == true)
            {
                SingleShotButton.Text = "Single Label Input";
                UploadPanel.Visible = true;
                SingleLabelPanel.Visible = false;
                SingleLabelTxtBox.Text = null;
                disabledbutton();
                ExcelPanel.Visible = false;
                HeaderTextBox.Visible = false;
            }
            else if (SingleLabelPanel.Visible == false)
            {
                SingleShotButton.Text = "Multi Label input";
                UploadPanel.Visible = false;
                SingleLabelPanel.Visible = true;
                FileLocation.Text = "";
                disabledbutton();
            }
        }
        //enables buttons or panels based on textboxes
        private void enabledbutton()
        {
            SlotButton.Enabled = true;
            SlotButton.BackgroundImage = Properties.Resources.Normal;
            SlotButton.ForeColor = System.Drawing.Color.White;
            BatteryButton.Enabled = true;
            BatteryButton.ForeColor = System.Drawing.Color.White;
            BatteryButton.BackgroundImage = Properties.Resources.Normal;
            SLotNoBarButton.Enabled = true;
            SLotNoBarButton.ForeColor = System.Drawing.Color.White;
            SLotNoBarButton.BackgroundImage = Properties.Resources.Normal;
            VehicleButton.Enabled = true;
            VehicleButton.ForeColor = System.Drawing.Color.White;
            VehicleButton.BackgroundImage = Properties.Resources.Normal;
            ChargerButton.Enabled = true;
            ChargerButton.ForeColor = System.Drawing.Color.White;
            ChargerButton.BackgroundImage = Properties.Resources.Normal;

        }
        //disables buttons and panels if information is missing
        private void disabledbutton()
        {
            SlotButton.Enabled = false;
            SlotButton.BackgroundImage = Properties.Resources.DisabledMirror;
            SlotButton.ForeColor = System.Drawing.Color.Black;
            BatteryButton.Enabled = false;
            BatteryButton.ForeColor = System.Drawing.Color.Black;
            BatteryButton.BackgroundImage = Properties.Resources.DisabledMirror;
            BatteryButton.ForeColor = System.Drawing.Color.Black;
            SLotNoBarButton.Enabled = false;
            SLotNoBarButton.ForeColor = System.Drawing.Color.Black;
            SLotNoBarButton.BackgroundImage = Properties.Resources.DisabledMirror;
            VehicleButton.Enabled = false;
            VehicleButton.ForeColor = System.Drawing.Color.Black;
            VehicleButton.BackgroundImage = Properties.Resources.DisabledMirror;
            ChargerButton.Enabled = false;
            ChargerButton.ForeColor = System.Drawing.Color.Black;
            ChargerButton.BackgroundImage = Properties.Resources.DisabledMirror;
            ExcelPanel.Visible = false;
            HeaderTextBox.Visible = false;
        }
        //checks to see if the textbox is holding the correct informaiton as far as size, or valid extension 
        private void checkstatus()
        {
            if (SingleLabelTxtBox.Text.Length == 0 && SingleLabelPanel.Visible == true)
            {
                disabledbutton();
                errortext = "Put Your Label ID In !";
                ErrorMessageForm emf = new ErrorMessageForm(errortext);
                emf.ShowDialog();
                error = true;

            }
            else if (FileLocation.Text.Length != 0 && UploadPanel.Visible == true)
            {
                filelocation();
            }
            else if (FileLocation.Text.Length == 0 && UploadPanel.Visible == true)
            {
                disabledbutton();
                errortext = "Locate Your File First";
                ErrorMessageForm emf = new ErrorMessageForm(errortext);
                emf.ShowDialog();
                error = true;
            }

        }
        //checks to see if a single label is presesnt, if not it fails
        private void SingleLabel()
        {
            if (SingleLabelTxtBox.Text.Length != 0 && SingleLabelPanel.Visible == true)
            {
                enabledbutton();
                //this is where the code goes to generate your label
                //Clear the report viewer Bindings out
                Viewer.DataBindings.Clear();
                //Clears the report viewer
                Viewer.LocalReport.DataSources.Clear();
                //set the binding datasource needed
                //make the datatable
                DataTable sdt = new DataTable();
                DataColumn basic = new DataColumn();
                basic.ColumnName = "number";
                sdt.Columns.Add(basic);

                //populate the datatable with the values
                sdt.Rows.Add(SingleLabelTxtBox.Text);
                //two labels or one...that is the question here
                if (dbl == "yes")
                {
                    sdt.Rows.Add(SingleLabelTxtBox.Text);
                    dbl = "no";
                }
                //Fill Report DataSource with new Table
                ReportDataSource sds = new ReportDataSource("ds", sdt);
                //adds the report datasource to the report
                Viewer.LocalReport.DataSources.Add(sds);
                //sets the report to the appropriate name
                ReportTypeLocator();
                //this refreshes the Reportviewer
                this.Viewer.RefreshReport();
                //this sets the display mode
                this.Viewer.SetDisplayMode(DisplayMode.PrintLayout);
                SingleLabelTxtBox.Text = "";
            }
            //this is what you will see if it fails
            else if (SingleLabelTxtBox.Text.Length == 0 && SingleLabelPanel.Visible == true)
            {

                errortext = "Need the Label ID Before Proceeding";
                ErrorMessageForm emf = new ErrorMessageForm(errortext);
                emf.ShowDialog();
                error = true;
            }
        }
        //validators for extension types
        private void filelocation()
        {
            string cext = Path.GetExtension(FileLocation.Text);
            if (cext == ".csv") { commatrick = true; csvread(); }
            else if (commatrick == false)
            {
                if (FileLocation.Text.Length != 0 && UploadPanel.Visible == true)
                {
                    string ext = FileLocation.Text;
                    string extent = Path.GetExtension(ext);
                    if (extent == ".xlsx" | extent == ".xls")
                    {
                        //  enabledbutton();
                        //this is where the code goes to generate your label
                        location = FileLocation.Text;
                        Sheet = SheetName.Text;
                        Column = "Number";
                        // checkheaders();
                        readingxlsxfile();
                    }
                    else if (extent != ".xlsx" | extent != ".xls")
                    {
                        errortext = "This is an Unusable format!!!! " + Environment.NewLine + "Please save your File as an" + Environment.NewLine + "Excel Workbook with extension *.xlsx " + Environment.NewLine + "or Extension *.xls ";
                        ErrorMessageForm emf = new ErrorMessageForm(errortext);
                        emf.ShowDialog();
                        error = true;
                    }

                }
            }
        }
        //Locks the Buttons if no values are present in single label mode
        private void SingleLabelTxtBox_TextChanged(object sender, EventArgs e)
        {
            int tl = SingleLabelTxtBox.Text.Length;
            if (tl > 0)
            { enabledbutton(); }
            else { disabledbutton(); }
        }
        //unlocks the buttons if there is something in the multilabel load textbox
        private void FileLocation_TextChanged(object sender, EventArgs e)
        {
            enabledbutton();

        }
        //Fires the Slot Report
        private void SlotButton_Click(object sender, EventArgs e)
        {
            dbl = "no";
            {
                Slot = true;
                if (SingleLabelPanel.Visible == true)
                {
                    if (SingleLabelTxtBox.Text.Length <= 7)
                    {
                        SingleLabel();
                        disabledbutton();
                    }
                    else
                    {
                        errortext = "Too Many Characters to display correctly" + Environment.NewLine + " reduce the label characters to 7 or less ";
                        ErrorMessageForm emf = new ErrorMessageForm(errortext);
                        emf.ShowDialog();
                        error = true;

                    }
                }
                else if (UploadPanel.Visible == true)
                { filelocation(); }
            }
        }
        //Fires the Vehicle Report
        private void VehicleButton_Click(object sender, EventArgs e)
        {
            dbl = "yes";
            Vehicle = true;
            if (SingleLabelPanel.Visible == true)
            {
                if (SingleLabelTxtBox.Text.Length <= 7)
                {
                    SingleLabel();
                    disabledbutton();
                }
                else
                {
                    errortext = "too many characters for label to display correctly" + Environment.NewLine + " reduce the label characters to 7 or less ";
                    ErrorMessageForm emf = new ErrorMessageForm(errortext);
                    emf.ShowDialog();
                    error = true;

                }
            }
            else if (UploadPanel.Visible == true)
            { filelocation(); }
        }
        //Fires the Battery Report
        private void BatteryButton_Click(object sender, EventArgs e)
        {
            dbl = "yes";
            Battery = true;
            if (SingleLabelPanel.Visible == true)
            {
                if (SingleLabelTxtBox.Text.Length <= 7)
                {

                    SingleLabel();
                    disabledbutton();

                }
                else
                {
                    errortext = "too many characters for label to display correctly" + Environment.NewLine + " reduce the label characters to 7 or less ";
                    ErrorMessageForm emf = new ErrorMessageForm(errortext);
                    emf.ShowDialog();
                    error = true;
                }

            }
            else if (UploadPanel.Visible == true)
            { filelocation(); }
        }
        //Fires the Slot No Bar Code report
        private void SLotNoBarButton_Click(object sender, EventArgs e)
        {
            dbl = "no";
            slotnobarcode = true;
            if (SingleLabelPanel.Visible == true)
            {
                if (SingleLabelTxtBox.Text.Length <= 7)
                {

                    SingleLabel();
                    disabledbutton();

                }
                else
                {
                    errortext = "too many characters for label to display correctly" + Environment.NewLine + " reduce the label characters to 7 or less ";
                    ErrorMessageForm emf = new ErrorMessageForm(errortext);
                    emf.ShowDialog();
                    error = true;
                }
            }
            else if (UploadPanel.Visible == true)
            {
                if (dbl == "yes")
                {
                    dbl = "no";
                    filelocation();
                }
                else
                {
                    filelocation();
                }
            }
        }
        //Fires the Charger Report
        private void ChargerButton_Click(object sender, EventArgs e)
        {
            dbl = "no";
            Charger = true;
            if (SingleLabelPanel.Visible == true)
            {
                if (SingleLabelTxtBox.Text.Length <= 7)
                {
                    SingleLabel();
                    disabledbutton();
                }
                else
                {
                    errortext = "too many characters for label to display correctly" + Environment.NewLine + " reduce the label characters to 7 or less ";
                    ErrorMessageForm emf = new ErrorMessageForm(errortext);
                    emf.ShowDialog();
                    error = true;
                }
            }
            else if (UploadPanel.Visible == true)
            {
                if (dbl == "yes") { dbl = "no"; filelocation(); Charger = true; } else filelocation();
            }

        }
        //Locates what type of Report you are firing
        private void ReportTypeLocator()
        {
            if (Vehicle == true)
            {
                Viewer.LocalReport.ReportEmbeddedResource = "Label_Wizard.Vehicle_Labels.rdlc";
                Vehicle = false;
            }
            else if (Slot == true)
            {
                Viewer.LocalReport.ReportEmbeddedResource = "Label_Wizard.Slot_Labels.rdlc";
                Slot = false;
            }
            else if (Battery == true)
            {
                Viewer.LocalReport.ReportEmbeddedResource = "Label_Wizard.Battery_Labels.rdlc";
                Battery = false;
            }
            else if (Charger == true)
            {
                Viewer.LocalReport.ReportEmbeddedResource = "Label_Wizard.Charger_Labels.rdlc";
                Charger = false;
            }
            else if (slotnobarcode == true)
            {
                Viewer.LocalReport.ReportEmbeddedResource = "Label_Wizard.Slot_No_BarCode_Labels.rdlc";
                slotnobarcode = false;
            }
        }
        //this entire string determines if the report is a csv file or an excel file and runs if it is an excel file
        private void readingxlsxfile()
        {
            header = HeaderTextBox.Text;
            //gets teh extension of the file name from the open file dialog
            string ext = Path.GetExtension(ofd.FileName);
            //if its a csv file this will fire the csv reader
            if (ext == ".csv") { commatrick = true; csvread(); }
            Clearall();
            checkheaders();
            if (commatrick == false)
                //if it is an excel file it will try to fire the excel reader
                if (error != true)
                {

                    try
                    {
                        //the excel datatable used 
                        DataTable xldt = new DataTable();
                        //the connection string used for the commands


                        if (headerswitch == true)
                        {
                            //creates a temporary datatable to cut the headers out
                            DataTable temp = new DataTable();
                            string cs = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileLocation.Text + "; Extended Properties =\"Excel 12.0 XML;HDR=Yes;IMEX=1;\"");
                            //this assigns the connection string to the connection for OLEDB
                            OleDbConnection con = new OleDbConnection(cs);
                            OleDbCommand cmd = new OleDbCommand("SELECT  F1 as [Number] from [" + SheetName.Text + "$] WHERE (NOT (  F1 IS NULL))", con);
                            OleDbDataAdapter oledba = new OleDbDataAdapter(cmd);
                            //skip the first row since it contains headers
                            oledba.Fill(temp);
                            IEnumerable<DataRow> erc = temp.AsEnumerable().Skip(1);
                            //this cuts the header or if there is a name like the header out of the datatable
                            List<String> removecol = new List<string> { header };
                            List<DataRow> RowsDelete = new List<DataRow>();
                            foreach (DataRow row in temp.Rows)
                            {
                                if (removecol.Contains(row["Number"].ToString()))
                                { RowsDelete.Add(row); }
                            }
                            foreach (DataRow row in RowsDelete)
                            { temp.Rows.Remove(row); }
                            temp.AcceptChanges();
                            xldt = temp;
                            con.Close();
                        }
                        else if (headerswitch == false)
                        {

                            string cs = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileLocation.Text + "; Extended Properties =\"Excel 12.0 XML;HDR=No;\"");
                            //this assigns the connection string to the connection for OLEDB
                            OleDbConnection con = new OleDbConnection(cs);
                            OleDbCommand cmd = new OleDbCommand("SELECT  F1 as [Number] from [" + SheetName.Text + "$] WHERE (NOT ( F1 IS NULL))", con);
                            OleDbDataAdapter oledba = new OleDbDataAdapter(cmd);
                            //Stay on target...... and fill the datatable with the data adapter
                            oledba.Fill(xldt);
                            //shut the door
                            con.Close();
                        }

                        // checks for double label requirements
                        if (dbl == "yes")
                        {
                            //fill a new datatable
                            DataTable temp2 = new DataTable();
                            //the double dataconnection command to populate the doubled dataTable
                            string cs = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileLocation.Text + @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileLocation.Text + "; Extended Properties =\"Excel 12.0 XML;HDR=No;\"");
                            //this assigns the connection string to the connection for OLEDB
                            OleDbConnection con = new OleDbConnection(cs);
                            OleDbConnection dcon = new OleDbConnection(cs);
                            //the double command to populate the doubled dataTable
                            OleDbCommand dcmd = new OleDbCommand("SELECT  F1 as [Number] from [" + SheetName.Text + "$] WHERE (NOT ( F1 IS NULL))", con);
                            //the double datattable adapter that is used to get the datat adapted into the datatable
                            OleDbDataAdapter doledba = new OleDbDataAdapter(dcmd);
                            //fills the double data adapter
                            doledba.Fill(temp2);
                            if (headerswitch == true)
                            {
                                List<String> removecol = new List<string> { header };
                                List<DataRow> RowsDelete = new List<DataRow>();
                                foreach (DataRow row in temp2.Rows)
                                {
                                    if (removecol.Contains(row["Number"].ToString()))
                                    { RowsDelete.Add(row); }
                                }
                                foreach (DataRow row in RowsDelete)
                                { temp2.Rows.Remove(row); }
                                temp2.AcceptChanges();
                                con.Close();
                            }

                            //Merges records to old datatable
                            xldt.Merge(temp2, true);
                            //sort the old datatable in an an ascending format
                            xldt.DefaultView.Sort = "Number" + " asc ";
                            //Resets the double switch
                            dbl = "no";
                            //populates the datatable the way the reportviewer needs it
                            xldt = xldt.DefaultView.ToTable();
                            //shuts the double connection
                            dcon.Close();
                        }
                        //establishes the report datasource for the labels
                        ReportDataSource rds = new ReportDataSource();
                        //adds the name of the report datasource, this is the report data source name on all of the reports.
                        rds.Name = "ds";
                        //populates the report datasource with the excel datatable
                        rds.Value = xldt;
                        //adds the report datasource to the report
                        Viewer.LocalReport.DataSources.Add(rds);
                        //sets the report to the appropriate name
                        ReportTypeLocator();
                        //refreshes the report viewer with the new data and report
                        this.Viewer.RefreshReport();
                        //this shows the report in a print layout
                        this.Viewer.SetDisplayMode(DisplayMode.PrintLayout);
                    }
                    catch (Exception xlopen)
                    {
                        errortext = Convert.ToString(xlopen);
                        ErrorMessageForm emf = new ErrorMessageForm(errortext);
                        emf.ShowDialog();
                        error = true;
                        commatrick = false;

                    }
                }

        }
        //Clears everythinig out
        private void Clearall()
        {
            Viewer.LocalReport.DataSources.Clear();
            Viewer.Clear();
        }
        //fires the CCA Label Wizard Manual
        private void HelpBtn_Click(object sender, EventArgs e)
        {

            Help help = new Help();
            help.Show();
        }
        //fires the CSV Reader Command
        private void csvread()
        {
            //clears the data from the existing datatable if this is  re-run
            if (MasterData.Columns.Contains("Number"))
            {
                MasterData.Reset();
                MasterData.Clear();

            }

            //set the file location based on object file dialog
            string folder = Path.GetDirectoryName(ofd.FileName);
            // set the file name based on object file dialog
            string filename = Path.GetFileName(ofd.FileName);
            //odbc connection type
            OdbcConnection odbccon = new OdbcConnection(@"Driver={Microsoft Text Driver (*.txt; *.csv)};Dbq=" + folder + ";Extensions=asc,csv,tab,txt;Persist Security Info=False");
            //odbc datatadapter to get the data
            OdbcDataAdapter odbcda = new OdbcDataAdapter("select * from[" + filename + "]", odbccon);
            //datatable
            odbcda.Fill(MasterData);
            odbccon.Close();
            MasterData.Columns[0].ColumnName = "Number";
            //if the labels need to be doubled up this will do that function
            if (dbl == "yes")
            {

                DataTable DDT = new DataTable();

                if (DDT.Rows.Count > 0)
                { DDT.Reset(); DDT.Clear(); }
                odbccon.Open();
                odbcda.Fill(DDT);
                DDT.Columns[0].ColumnName = "Number";
                MasterData.Merge(DDT);
                DataView dv = MasterData.DefaultView;
                dv.Sort = "Number asc";
            }
            ReportDataSource rds = new ReportDataSource();
            //adds the name of the report datasource, this is the report data source name on all of the reports.
            rds.Name = "ds";
            //populates the report datasource with the datatable
            rds.Value = MasterData;
            //adds the report datasource to the report
            Viewer.LocalReport.DataSources.Add(rds);
            //sets the report to the appropriate name
            ReportTypeLocator();
            //refreshes the report viewer with the new data and report
            this.Viewer.RefreshReport();
            //this shows the report in a print layout
            this.Viewer.SetDisplayMode(DisplayMode.PrintLayout);

        }

        private void HeaderRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (HeaderTextBox.Visible == false)
            {
                HeaderTextBox.Visible = true;
            }
            else if (HeaderTextBox.Visible == true)
            {
                HeaderTextBox.Visible = false;
            }
        }

        private void SheetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeaderBtn_Click(object sender, EventArgs e)
        {

            headerswitchtag();
        }

        private void HeaderTextBox_TextChanged(object sender, EventArgs e)
        {
            if (HeaderTextBox.Text.Length > 0)
            {
                HeaderTextBox.Visible = true;
                headerswitch = true;
            }
            else if (HeaderTextBox.Text.Length < 2)
            {
                HeaderTextBox.Visible = false;
                headerswitch = false;
            }
        }

        private void headerswitchtag()
        {
           
            if (HeaderTextBox.Visible == false)
            {
                HeaderTextBox.Visible = true;
                headerswitch = true;
                HeaderTextBox.Text = "F1";
            }
            else if (HeaderTextBox.Visible == true)
            {
                HeaderTextBox.Text = "F1";
                if (HeaderTextBox.Text == "F1")
                {
                    HeaderTextBox.Visible = false;
                    headerswitch = false;
                }
               
            }
        }

    }
    
}
