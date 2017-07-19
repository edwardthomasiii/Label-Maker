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
    
    public partial class ErrorMessageForm : Form
    {
  
   
        public ErrorMessageForm(string Error_Value)
        {
            InitializeComponent();
            ErrorLabel.Text = Error_Value;
       
        }

        private void ErrorLoad(object sender, EventArgs e)
        {
            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
