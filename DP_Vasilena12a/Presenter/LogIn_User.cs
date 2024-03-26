using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_Vasilena12a.Presenter
{
    public partial class LogIn_User : Form
    {
        public LogIn_User()
        {
            InitializeComponent();
        }

        private void LogIn_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Data);
            // TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Data' table. You can move, or remove it, as needed.
            //this.dataTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Data);

        }
    }
}
