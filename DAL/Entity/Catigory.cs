using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public class Catigory
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CatigoryId { get; set; }
        [Required,MaxLength(50)]
        public string CatigoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
