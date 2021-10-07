using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLayer
{
    public class StockContainsItems
    {
        [Key, Column(Order = 1)]
        public int Stock_ID { get; set; }

        [Key,Column(Order =2)]
        public int Item_ID { get; set; }

        public int Item_Amount { get; set; }

        public Stock StockR { get; set; }
        public Item ItemR { get; set; }

        public override string ToString()
        { 
            return  $"Stock_ID ={Stock_ID} and Item_ID={Item_ID} and Item_Amount={Item_Amount}";
        }
    }
}
