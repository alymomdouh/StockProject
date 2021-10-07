using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLayer
{
    public class StockHistory
    {
         [Key]
        public int StockHistory_ID { get; set; }
        //[Key, Column(Order = 1)]
        public int Stock_ID { get; set; }

        //[Key, Column(Order = 2)]
        public int Item_ID { get; set; }

        public int  Amount { get; set; }
        public string ProcessType { get; set; }// emport        export
        public DateTime ProcessDate { get; set; } 

        [ForeignKey("Stock_ID")]
        public Stock StockRH { get; set; }

        [ForeignKey("Item_ID")]
        public Item ItemRH { get; set; }
    }
}
