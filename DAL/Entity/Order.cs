using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Order
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }
        public string? OrderDate { get; set; }

        public virtual List<OrderItem> OrderItem { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; } 
        //navigation
        public User User { get; set; }


    }
}
