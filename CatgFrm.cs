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
    public partial class CatgFrm : Form
    {
        public CatgFrm()
        {
            InitializeComponent();
        }
        Linqconnection linq1 = new Linqconnection();
        private void Btnaddcatg_Click(object sender, EventArgs e)
        {
            if (catgnametxt.Text != null)
            { 
                linq1.add_new_obj(new Catg() { Catg_Name = catgnametxt.Text });
                catgview.DataSource = linq1.fill_data_grid_view("Catg");
                catgnametxt.Text = "";
            }
        }

        private void CatgFrm_Load(object sender, EventArgs e)
        { 
            catgview.DataSource = linq1.fill_data_grid_view("Catg");
            catgnametxt.Text = " ";
        }

        private void Catgview_SelectionChanged(object sender, EventArgs e)
        {
            if (catgview.CurrentRow != null)
            {
                catgnametxt.Text = catgview.CurrentRow.Cells["Catg_Name"].Value.ToString();
            }
        }

        private void Btnupdatecatg_Click(object sender, EventArgs e)
        {
            if (catgview.CurrentRow != null && catgnametxt.Text != "")
            { 
                int cid = int.Parse(catgview.CurrentRow.Cells["Catg_ID"].Value.ToString()); 
                linq1.make_update(new Catg { Catg_ID = cid, Catg_Name = catgnametxt.Text }); 
                catgview.DataSource = linq1.fill_data_grid_view("Catg");
                catgnametxt.Text = " ";
            }
        }

        private void Btndeletecatg_Click(object sender, EventArgs e)
        {
            if (catgview.CurrentRow != null)
            { 
                int cid = int.Parse(catgview.CurrentRow.Cells["Catg_ID"].Value.ToString());
                linq1.make_delete(new Catg { Catg_ID = cid });
                catgview.DataSource = linq1.fill_data_grid_view("Catg");
                catgnametxt.Text = "";
            }
        }
    }
}
