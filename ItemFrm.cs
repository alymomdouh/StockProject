using LogLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProject
{
    public partial class ItemFrm : Form
    {
        public ItemFrm()
        {
            InitializeComponent();
        }
        Linqconnection linq1 = new Linqconnection();
        string imgpath = "not save"; 
        private void ItemFrm_Load(object sender, EventArgs e)
        { 
            full_in_DataGridView(); 
        }
        private void make_empty()
        {
            imgpath = "";
            //itemimage.Image.Dispose();
            itemimage.Image = null;
            itemtxt.Text = " ";
        }
        public void full_in_DataGridView()
        {
            itemcatgcombox.DataSource = linq1.fill_data_grid_view("Catg");
            itemcatgcombox.DisplayMember = "Catg_Name";  
            itemcatgcombox.ValueMember = "Catg_ID"; 
            itemview.DataSource = linq1.make_datatable();// to full up datagridview
            make_empty();
        }
         
        private void Btnadditem_Click(object sender, EventArgs e)
        {
            if (itemtxt.Text !="" && itemcatgcombox.SelectedIndex>-1 && itemimage.Image.ToString()!="")
            {
                linq1.add_new_obj(new Item()
                {
                    Item_Name = itemtxt.Text,
                    Item_Image = imgpath, 
                    Item_Catg_ID = int.Parse(itemcatgcombox.SelectedValue.ToString())
                });
                full_in_DataGridView(); 
            }
        } 
        private void Btnitemimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images|*.jpg;*.png;*.gif;*.bmp;";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                itemimage.Image = Image.FromFile(ofd.FileName);
                imgpath = ofd.FileName; 
            } 
        } 
        private void Btnupdateitem_Click(object sender, EventArgs e)
        {
            if (itemview.CurrentRow != null && itemtxt.Text != "" && itemcatgcombox.SelectedIndex > -1)
            {
                //MessageBox.Show(itemview.CurrentRow.Cells["Item_ID"].Value.ToString()+"  " +itemcatgcombox.SelectedValue.ToString());
                int cid = int.Parse(itemview.CurrentRow.Cells["Item_ID"].Value.ToString()); 
                linq1.make_update(new Item
                {
                    Item_ID=cid,
                    Item_Name = itemtxt.Text,
                    Item_Image = imgpath,//"not save", 
                    Item_Catg_ID = int.Parse(itemcatgcombox.SelectedValue.ToString())
                });
                itemtxt.Text = ""; 
                 itemtxt.Text = " "; 
                 itemimage.Image = null; 
                full_in_DataGridView();
            }
        } 
        private void Itemview_SelectionChanged(object sender, EventArgs e)
        {
            itemimage.Image = null;itemtxt.Text = "";
            if (itemview.CurrentRow != null)
            {
                itemview.CurrentRow.Height = 200;
                itemtxt.Text = itemview.CurrentRow.Cells["Item_Name"].Value.ToString(); 
                itemcatgcombox.SelectedItem = int.Parse(itemview.CurrentRow.Cells["Item_Catg_ID"].Value.ToString());
                  itemcatgcombox.SelectedValue = itemview.CurrentRow.Cells["Item_Catg_ID"].Value; 
                if (itemview.CurrentRow.Cells["Item_Image"].Value.ToString() !=""&& File.Exists(@"imgs/" +itemview.CurrentRow.Cells["Item_Image"].Value.ToString())) 
                {
                     itemimage.Image =  Image.FromFile(@"imgs/" + itemview.CurrentRow.Cells["Item_Image"].Value.ToString());
                    imgpath = @"imgs/" + itemview.CurrentRow.Cells["Item_Image"].Value.ToString(); 
                }
            }
        }
         private void Btndeleteitem_Click(object sender, EventArgs e)
        {
            if (itemview.CurrentRow != null)
            {
                int cid = int.Parse(itemview.CurrentRow.Cells["Item_ID"].Value.ToString());
                linq1.make_delete(new Item { Item_ID = cid });
                itemview.DataSource = linq1.fill_data_grid_view("Item");
                itemtxt.Text = "";
            }
        } 
    }
}
