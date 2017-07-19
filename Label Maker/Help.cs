using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_Wizard
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {

         
            this.HelpViewer.RefreshReport();
            HelpViewer.ZoomMode = ZoomMode.Percent;
            this.HelpViewer.ZoomPercent = 150;
            

        }

        private void OverView_Click(object sender, EventArgs e)
        {
          
            ReportDataSource ADOX = new ReportDataSource();
            ADOX.Name = "Tables";
            HelpViewer.LocalReport.DataSources.Clear();
          HelpViewer.LocalReport.DataSources.Add(ADOX);
             HelpViewer.LocalReport.ReportEmbeddedResource = "LabelMaker.CCA_Label_Wizard_Manual.rdlc";
            HelpViewer.RefreshReport();
        }
    }
}
