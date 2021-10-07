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
    public partial class ExportFrm : Form
    {
        public ExportFrm()
        {
            InitializeComponent();
        }
        Linqconnection linq1 = new Linqconnection();
        Context con = new Context();
        private void ExportFrm_Load(object sender, EventArgs e)
        {
            exportstorecombox.DataSource = con.Stocks.ToList();
            exportstorecombox.DisplayMember = "Stock_Name";
            exportstorecombox.ValueMember = "Stock_ID";

            cmboxitemexport.DataSource = con.Items.ToList();
            cmboxitemexport.DisplayMember = "Item_Name";
            cmboxitemexport.ValueMember = "Item_ID";



        }

        private void exportbtnadd_Click(object sender, EventArgs e)
        {
            if (exportamounttxt.Text != null && exportstorecombox.SelectedIndex > -1 && cmboxitemexport.SelectedIndex > -1)
            {
                linq1.SetQeuntityItem(new StockContainsItems
                {
                    Stock_ID = Int32.Parse(exportstorecombox.SelectedValue.ToString()),
                    Item_ID = Int32.Parse(cmboxitemexport.SelectedValue.ToString()),
                    Item_Amount = Int32.Parse(exportamounttxt.Text),
                });
                linq1.add_new_obj(new StockHistory
                {
                    Stock_ID = Int32.Parse(exportstorecombox.SelectedValue.ToString()),
                    Item_ID = Int32.Parse(cmboxitemexport.SelectedValue.ToString()),
                    Amount = Int32.Parse(exportamounttxt.Text),
                    ProcessType = "export",
                    ProcessDate = DateTime.Now.ToLocalTime()
                }); ;
                int num;
                bool parseOK = Int32.TryParse(exportstorecombox.SelectedValue.ToString(), out num);
                exportview.DataSource = linq1.fill_data_withStock(num);
                exportamounttxt.Text = "";
            }
        }

        private void exportview_SelectionChanged(object sender, EventArgs e)
        {

            exportview.ClearSelection();
            //if (dataGridEmport.CurrentRow != null)
            //{
            //    importamounttxt.Text = dataGridEmport.CurrentRow.Cells["Item_Amount"].Value.ToString();
            //    //cmItemName.SelectedValue = int.Parse(dataGridEmport.CurrentRow.Cells["Item_amount"].Value.ToString());
            //    //cmItemName.SelectedIndex = cmItemName.Items.IndexOf(dataGridEmport.CurrentRow.Cells["Item_Name"].Value.ToString());
            //}
        } 
        private void exportstorecombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;
            bool parseOK = Int32.TryParse(exportstorecombox.SelectedValue.ToString(), out num);
            exportview.DataSource = linq1.fill_data_withStock(num);
        } 
        private void TimerExport_Tick(object sender, EventArgs e)
        {
            datelabel.Text = DateTime.Now.ToLocalTime() + "\n" + DateTime.Now.DayOfWeek.ToString();
            //System.DateTime.Now.ToString("dddd"); 
        }
    }
}
