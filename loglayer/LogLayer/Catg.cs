using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLayer
{
    public class Catg
    {
        [Key]
        public int Catg_ID { get; set; }

        [Required, MaxLength(100)]
        public string Catg_Name { get; set; }

        [InverseProperty("belongonecatg")]
        public virtual List<Item> havemanyitems { get; set; }

    }
}
