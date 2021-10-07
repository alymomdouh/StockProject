using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLayer
{
    public class Context:DbContext
    {
        public Context() : base(@"Data Source=.\;Initial Catalog=StockDB;Integrated Security=True")
        {
             
        }   
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Catg> Catgs { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<StockContainsItems> StockContainsItems { get; set; }
        public virtual DbSet<StockHistory> GetStockHistories { get; set; }


        // Enable-Migrations 
        // add-migration insertint
        // update-database
         

    }
}
