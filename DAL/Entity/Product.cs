using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Product
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public double Price { get; set; }
        [ForeignKey("CatigoryId")]
        public int CatigoryId { get; set; }
        public Catigory Catigory { get; set; }

        public virtual List<OrderItem> OrderItem { get; set; }

    }
}
