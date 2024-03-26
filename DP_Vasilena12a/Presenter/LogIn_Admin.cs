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
    public partial class LogIn_Admin : Form
    {
        public LogIn_Admin()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LogIn_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Products);
            // TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Data);
            // TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Products);
            // TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Data);

        }
    }
}
