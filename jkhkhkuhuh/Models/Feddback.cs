using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class Feddback
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Content { get; set; }
        [ForeignKey("UserCostumer")]
        public int UserCustemerId { get; set; }
        public UserCostumer UserCostumer { get; set; }

    }
}
