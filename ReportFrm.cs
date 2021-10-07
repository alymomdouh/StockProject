using LogLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProject
{
    public partial class ReportFrm : Form
    {
        public ReportFrm()
        {
            InitializeComponent();
        }
        Linqconnection linq1 = new Linqconnection();
        Context con = new Context();
        private void exportview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReportFrm_Load(object sender, EventArgs e)
        {
            reportcombox.DataSource = con.Stocks.ToList();
            reportcombox.DisplayMember = "Stock_Name";
            reportcombox.ValueMember = "Stock_ID";
        }

        private void reportcombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;
            bool parseOK = Int32.TryParse(reportcombox.SelectedValue.ToString(), out num);
            exportview.DataSource = linq1.fill_data_withStock(num);

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
