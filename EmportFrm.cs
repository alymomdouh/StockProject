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
    public partial class EmportFrm : Form
    {
        public EmportFrm()
        {
            InitializeComponent();
        }
        Linqconnection linq1 = new Linqconnection();
        Context con = new Context();
        private void EmportFrm_Load(object sender, EventArgs e)
        {
            emportstorecombobox.DataSource = con.Stocks.ToList();
            emportstorecombobox.DisplayMember = "Stock_Name";
            emportstorecombobox.ValueMember = "Stock_ID";

            cmItemName.DataSource=con.Items.ToList();
            cmItemName.DisplayMember = "Item_Name";
            cmItemName.ValueMember = "Item_ID";
            dataGridEmport.ClearSelection();

        }

        private void emportbtnadd_Click(object sender, EventArgs e)
        {
            if (importamounttxt.Text != null && emportstorecombobox.SelectedIndex > -1 && cmItemName.SelectedIndex > -1)
            {

                linq1.add_new_obj(new StockContainsItems
                    {
                        Stock_ID = Int32.Parse(emportstorecombobox.SelectedValue.ToString()),
                        Item_ID = Int32.Parse(cmItemName.SelectedValue.ToString()),
                        Item_Amount = Int32.Parse(importamounttxt.Text),
                    });
                linq1.add_new_obj(new StockHistory
                {
                    Stock_ID = Int32.Parse(emportstorecombobox.SelectedValue.ToString()),
                    Item_ID = Int32.Parse(cmItemName.SelectedValue.ToString()),
                    Amount = Int32.Parse(importamounttxt.Text),
                    ProcessType = "emport",
                    ProcessDate = DateTime.Now.ToLocalTime()
                }); ;
                
                int num;
                bool parseOK = Int32.TryParse(emportstorecombobox.SelectedValue.ToString(), out num);
                dataGridEmport.DataSource = linq1.fill_data_withStock(num);
                importamounttxt.Text = "";
            }
        }

        //private void emportudate_Click(object sender, EventArgs e)
        //{
        //    linq1.make_update(new StockContainsItems
        //    {
        //        Stock_ID= Int32.Parse(emportstorecombobox.SelectedValue.ToString()),
        //        Item_ID= Int32.Parse(cmItemName.SelectedValue.ToString()),
        //        Item_Amount=Int32.Parse(importamounttxt.Text) ,

        //    });
        //    int num;
        //    bool parseOK = Int32.TryParse(emportstorecombobox.SelectedValue.ToString(), out num);
        //    dataGridEmport.DataSource = linq1.fill_data_withStock(num);
        //}
        
        private void dataGridEmport_SelectionChanged(object sender, EventArgs e)
        {
            //dataGridEmport.ClearSelection();
            //if (dataGridEmport.CurrentRow != null)
            //{
            //    importamounttxt.Text = dataGridEmport.CurrentRow.Cells["Item_Amount"].Value.ToString();
            //    //cmItemName.SelectedValue = int.Parse(dataGridEmport.CurrentRow.Cells["Item_amount"].Value.ToString());
            //    //cmItemName.SelectedIndex = cmItemName.Items.IndexOf(dataGridEmport.CurrentRow.Cells["Item_Name"].Value.ToString());
            //}
        }

        private void cmItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void emportstorecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;
            bool parseOK = Int32.TryParse(emportstorecombobox.SelectedValue.ToString(), out num);
            dataGridEmport.DataSource = linq1.fill_data_withStock(num);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            datelabel.Text = DateTime.Now.ToLocalTime() + "\n" + DateTime.Now.DayOfWeek.ToString();

        }
    }
}
