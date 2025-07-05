using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        [Required,MaxLength(50)]
        public string UserName { get; set; }
        public string? Password { get; set; } 

        public string? Role { get; set; } 

        // Navigation
        public ICollection<Order> Orders { get; set; }
    }
}
