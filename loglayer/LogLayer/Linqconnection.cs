using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; 
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;
using System.Data;
using Image = System.Drawing.Image;
using System.Data.Entity;
using System.Drawing.Imaging;

namespace LogLayer
{
    public class Linqconnection
    {
        public Linqconnection()
        {
            saveseeddate();
        }
        Context con = new Context();
        static string a="e";
        List<string> deletedimgs = new List<string>();
        private void saveseeddate()
        {
            Context con1 = new Context();
            Stock stock1 = con1.Stocks.Select(s => s).FirstOrDefault();
            if (stock1==null)
            {
                IList<Stock> stockL = new List<Stock>();
                stockL.Add(new Stock { Stock_Name = "stock1" });
                stockL.Add(new Stock { Stock_Name = "stock2" });
                stockL.Add(new Stock { Stock_Name = "stock3" });
                stockL.Add(new Stock { Stock_Name = "stock4" });
                stockL.Add(new Stock { Stock_Name = "stock5" });
                //foreach (Stock st in stockL) { context.Stocks.Add(st); } 
                con1.Stocks.AddRange(stockL);
                con1.SaveChanges();
            }
            Catg cat11 = con1.Catgs.Select(s => s).FirstOrDefault();
            if (cat11 == null)
            {
                IList<Catg> catgL = new List<Catg>();
                catgL.Add(new Catg { Catg_Name = "cat1" });
                catgL.Add(new Catg { Catg_Name = "cat2" });
                catgL.Add(new Catg { Catg_Name = "cat3" });
                catgL.Add(new Catg { Catg_Name = "cat4" });
                catgL.Add(new Catg { Catg_Name = "cat5" });
                con1.Catgs.AddRange(catgL);
                con1.SaveChanges();
            }
            Item item1 = con1.Items.Select(s => s).FirstOrDefault();
            if (item1 == null)
            {
                IList<Item> itemL = new List<Item>();
                itemL.Add(new Item { Item_Name = "item1", Item_Catg_ID = 1, Item_Image = "img1.png" });
                itemL.Add(new Item { Item_Name = "item2", Item_Catg_ID = 1, Item_Image = "img2.png" });
                itemL.Add(new Item { Item_Name = "item3", Item_Catg_ID = 1, Item_Image = "img3.png" });
                itemL.Add(new Item { Item_Name = "item4", Item_Catg_ID = 2, Item_Image = "img4.png" });
                itemL.Add(new Item { Item_Name = "item5", Item_Catg_ID = 3, Item_Image = "img5.png" });
                con1.Items.AddRange(itemL);
                con1.SaveChanges();
            } 
        }
        public void add_new_obj(object obj) 
        {  
            if (obj.GetType().Name.ToString() == "Stock")
            {
                Stock st = (Stock)obj;
                con.Stocks.Add(new Stock { Stock_Name = st.Stock_Name });
            }
            else if (obj.GetType().Name.ToString() == "Catg")
            {
                Catg st = (Catg)obj;
                con.Catgs.Add(new Catg { Catg_Name = st.Catg_Name });
            }
            else if ( obj.GetType().Name.ToString() == "Item")
            {
                Item st = (Item)obj;
                con.Items.Add(new Item {
                    Item_Name = st.Item_Name, Item_Catg_ID = st.Item_Catg_ID,
                    Item_Image =""//null// st.Item_Image
                });
                con.SaveChanges();
                save_image(st);
            }
            else if (obj.GetType().Name.ToString() == "StockContainsItems")
            {
                StockContainsItems st = (StockContainsItems)obj;
                var old=con.StockContainsItems.Where(o =>o.Item_ID==st.Item_ID&&o.Stock_ID==st.Stock_ID).FirstOrDefault();  
                  if (old != null) //   old!=default(StockContainsItems)
                {//   if found make update
                    old.Item_Amount += st.Item_Amount;
                }else if (old==null) //old==default(StockContainsItems)
                {// if new make insert 
                    con.StockContainsItems.Add(new StockContainsItems
                    {
                        Stock_ID = st.Stock_ID,
                        Item_ID = st.Item_ID,
                        Item_Amount = st.Item_Amount
                    });
                } 
            }
            else if (obj.GetType().Name.ToString() == "StockHistory")
            {
                StockHistory st = (StockHistory)obj; 
                    con.GetStockHistories.Add(new StockHistory
                    {
                        Stock_ID = st.Stock_ID,
                        Item_ID=st.Item_ID,
                         Amount =st.Amount,
                         ProcessType=st.ProcessType,
                         ProcessDate=st.ProcessDate 
                    }); 
            }
            con.SaveChanges();
        }
        public void SetQeuntityItem(object obj)
        { 
            StockContainsItems st = (StockContainsItems)obj;
            StockContainsItems old = con.StockContainsItems.Where(e => e.Item_ID == st.Item_ID).First(); 
            if (old.Item_Amount - st.Item_Amount > 0)
                old.Item_Amount -= st.Item_Amount; 
            else if (old.Item_Amount < st.Item_Amount )
            {
                int amount = old.Item_Amount;
                MessageBox.Show($"There is Only left {amount} item out of Stock");
            } 
            else if ( old.Item_Amount - st.Item_Amount <= 0 )
            {
                make_delete(old); 
                MessageBox.Show("The item out of Stock");
            } 
            con.SaveChanges(); 
        }
        public IList fill_data_withStock (int num)
        { 
            var qeury =( from st in con.StockContainsItems
                        where st.Stock_ID == num
                        select  new { st.Item_ID, st.ItemR.Item_Name, st.Item_Amount } 
                        ).ToList(); 
                return qeury;
        }
        public IList fill_data_grid_view(string type)
        { 
            if(type== "Stock")// from  Stock page
            {
                return con.Stocks.Select(s => new { s.Stock_ID, s.Stock_Name }).ToList();
            }
            else if (type == "Catg")// from  Catg page
            {
                return con.Catgs.Select(c => new { c.Catg_ID, c.Catg_Name }).ToList();
            }
            else if (type == "Item")// from  Item page
            { 
                var query = con.Items.Select(i => new { i.Item_ID, i.Item_Name,i.belongonecatg.Catg_Name, i.Item_Catg_ID, i.Item_Image }).ToList();//.AsEnumerable();//,Picture= @"imgs/" + i.Item_Image, myimg 
                 
                return query;
            }
            else if (type == "StockContainsItems")// from  StockContainsItems page
            { 
                return con.StockContainsItems.Select(i => new {
                    i.Item_ID,
                    i.ItemR.Item_Name,
                    i.Item_Amount
                }).ToList(); 
            } 
            return null;
        }
        public void  make_update(object obj) 
        { 
            if ( obj.GetType().Name.ToString()== "Stock") {
                Stock st = (Stock)obj;
                Stock old = con.Stocks.Where(e => e.Stock_ID == st.Stock_ID).First();
                old.Stock_Name = st.Stock_Name;
            }
            else if (obj.GetType().Name.ToString() == "Catg")
            {
                Catg st = (Catg)obj;
                Catg old = con.Catgs.Where(e => e.Catg_ID == st.Catg_ID).First();
                old.Catg_Name = st.Catg_Name;
            }
            else if (obj.GetType().Name.ToString() == "Item")
            {
                Item st = (Item)obj;
                Item old = con.Items.Where(e => e.Item_ID == st.Item_ID).First();
                old.Item_Name = st.Item_Name;
                old.Item_Catg_ID = st.Item_Catg_ID;
               // MessageBox.Show("before update image "+st.Item_Image);
                //MessageBox.Show(st.Item_Image.Substring(5));
                if (old.Item_Image!= st.Item_Image.Substring(5))
                {
                   // old.Item_Image = "img" + st.Item_ID + "png";// st.Item_Image;
                     save_image(st);
                } 
                 con.SaveChanges(); 
            } 
            else if (obj.GetType().Name.ToString() == "StockContainsItems")
            {
                StockContainsItems st = (StockContainsItems)obj;
                StockContainsItems old = con.StockContainsItems.Where(e => e.Item_ID == st.Item_ID).First();
                old.Item_Amount = st.Item_Amount;
            }
             con.SaveChanges(); 
        }
        public void make_delete(object obj)
        { 
            if ( obj.GetType().Name.ToString() == "Stock")// check if come from Stock page
            {
                Stock st = (Stock)obj;
                Stock old = con.Stocks.Where(e => e.Stock_ID == st.Stock_ID).FirstOrDefault();
                con.Stocks.Remove(old); 
            }
            else if ( obj.GetType().Name.ToString() == "Catg")// check if come from Catg page
            {
                Catg st = (Catg)obj;
                Catg old = con.Catgs.Where(e => e.Catg_ID == st.Catg_ID).FirstOrDefault();
                con.Catgs.Remove(old);
            }
            else if (obj.GetType().Name.ToString() == "Item")// check if come from Item page
            {
                Item st = (Item)obj;
                Item old = con.Items.Where(e => e.Item_ID == st.Item_ID).FirstOrDefault();
                deletedimgs.Add(old.Item_Image);
                con.Items.Remove(old);
            }
            else if (obj.GetType().Name.ToString() == "StockContainsItems")// check if come from Item page
            {
                StockContainsItems st = (StockContainsItems)obj;
                StockContainsItems old = con.StockContainsItems.Where(e => e.Item_ID == st.Item_ID).FirstOrDefault();
                con.StockContainsItems.Remove(old);
            } 
            con.SaveChanges();
        }
        private void save_image(Item st)
        {
            int id = con.Items.Where(ii => ii.Item_Name == st.Item_Name && ii.Item_Catg_ID == st.Item_Catg_ID ).Select(ii => ii.Item_ID).FirstOrDefault();//&& i.Item_Image == st.Item_Image
             if (!Directory.Exists("imgs"))
            {
                Directory.CreateDirectory("imgs"); 
            } 
                Bitmap picture1; 
             string newpath = "";
            if (File.Exists("imgs/img" + id + ".png")) {
                //MessageBox.Show("file imgs/img" + id + ".png will deleted"); 
                deletedimgs.Add("imgs/img" + id + ".png");
                newpath = "img" + id +a +".png"; 
                picture1 = new Bitmap(Image.FromFile( st.Item_Image));//"imgs/" +
                a += "e";
            }  
            else
            {
                 //picture1 = (Bitmap) Image.FromFile(st.Item_Image, true); 
                   picture1 = new Bitmap( Image.FromFile(st.Item_Image ));
                newpath = "img"+id +".png";
                //picture.Image = Image.FromFile(st.Item_Image);
            } 
             picture1.Save("imgs/" + newpath);//+".png"   , System.Drawing.Imaging.ImageFormat.Png
           // MessageBox.Show(picture1.ToString());
            Item e1 = con.Items.Where(ii => ii.Item_ID == id).FirstOrDefault();
            e1.Item_Image = newpath; 
            con.SaveChanges(); 
              picture1.Dispose(); 
            // picture.Dispose();
        }
        public DataView make_datatable()//IList list) 
        {
            var list = con.Items.Select(i => new { i.Item_ID, i.Item_Name, Catg_Name= i.belongonecatg.Catg_Name, i.Item_Catg_ID, i.Item_Image }).ToList();//.AsEnumerable();//,Picture= @"imgs/" + i.Item_Image, myimg 
             
             DataTable dt = new DataTable();
            dt.Columns.Add("Item_ID", typeof(int));
            dt.Columns.Add("Item_Name", typeof(string));
            dt.Columns.Add("Catg_Name", typeof(string));
            dt.Columns.Add("Item_Catg_ID", typeof(int));
            dt.Columns.Add("Item_Image", typeof(string)); 
            dt.Columns.Add("Picture", Type.GetType("System.Byte[]"));
            foreach (var item in list)
            {
                DataRow onerow = dt.NewRow();
                onerow["Item_ID"] = item.Item_ID;
                onerow["Item_Name"] = item.Item_Name;
                onerow["Catg_Name"] = item.Catg_Name;
                onerow["Item_Catg_ID"] = item.Item_Catg_ID;
                onerow["Item_Image"] = item.Item_Image;
                 ImageConverter converter = new ImageConverter(); 
                var imageConverter = new ImageConverter();
                onerow["Picture"] = imageConverter.ConvertTo(Image.FromFile(@"imgs/" + onerow["Item_Image"].ToString().Trim()),  Type.GetType("System.Byte[]"));
                dt.Rows.Add(onerow);
            }
            DataView dv = dt.DefaultView; 
            return dv;
        }
        // private void renameimgs(string path)
        //{
        //    //Item item1 = con.Items.Where(e => e.Item_Image.Length >= 15&& (e.Item_Image.Substring) ==path).FirstOrDefault();
        //}
        ~Linqconnection()
        {
            while (deletedimgs.Count>0)
            {
                 string path = deletedimgs[0];
                //MessageBox.Show(path);
                File.Delete(path);
                //renameimgs(path);
            }
        }
        
    }

}
