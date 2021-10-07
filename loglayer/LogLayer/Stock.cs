using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLayer
{
    public class Stock
    {
        [Key]
        public int Stock_ID { get; set; }

        [Required, MaxLength(100)]
        public string Stock_Name { get; set; }

        public IList<StockContainsItems> StockContainsItems_StockR { get; set; }
        public IList<StockHistory> StockHistory_StockRH { get; set; }
    }
}
