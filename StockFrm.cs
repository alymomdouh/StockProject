using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogLayer;

namespace StockProject
{
    public partial class StockFrm : Form
    {
        public StockFrm()
        {
            InitializeComponent();
        }
        Linqconnection linq1 = new Linqconnection();
        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (stocknametxt.Text != null)
            { 
                linq1.add_new_obj(new Stock() {Stock_Name= stocknametxt.Text }); 
                storeView.DataSource= linq1.fill_data_grid_view("Stock");
                stocknametxt.Text = "";
            }
        }

        private void StockFrm_Load(object sender, EventArgs e)
        {
            stocknametxt.Text = " ";
            storeView.DataSource = linq1.fill_data_grid_view("Stock");
            stocknametxt.Text =" ";
        }

        private void StoreView_SelectionChanged(object sender, EventArgs e)
        {
            if (storeView.CurrentRow != null)
            {
                stocknametxt.Text = storeView.CurrentRow.Cells["Stock_Name"].Value.ToString();
            }
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            if (storeView.CurrentRow != null && stocknametxt.Text != "")
            { 
                int sid = int.Parse(storeView.CurrentRow.Cells["Stock_ID"].Value.ToString()); 
                 linq1.make_update(new Stock { Stock_ID = sid, Stock_Name = stocknametxt.Text }); 
                stocknametxt.Text = "";
                storeView.DataSource = linq1.fill_data_grid_view("Stock");
                stocknametxt.Text = " ";
            }
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            if (storeView.CurrentRow != null)
            { 
                int sid = int.Parse(storeView.CurrentRow.Cells["Stock_ID"].Value.ToString()); 
                linq1.make_delete(new Stock { Stock_ID = sid });
                storeView.DataSource = linq1.fill_data_grid_view("Stock");
                stocknametxt.Text = "";
            }
        }
    }
}
