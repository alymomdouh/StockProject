using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLayer
{
    public class Item
    {
        [Key]
        public int Item_ID { get; set; }

        [Required, MaxLength(100)]
        public string Item_Name { get; set; }
        public string Item_Image { get; set; }
        public int Item_Catg_ID { get; set; } 

        [ForeignKey("Item_Catg_ID")]
        [InverseProperty("havemanyitems")]
        public virtual Catg belongonecatg { get; set; }//  many to one catg relation

        public IList<StockContainsItems> StockContainsItems_ItemR { get; set; }
         public IList<StockHistory> StockHistory_ItemRH { get; set; }
    }
}
