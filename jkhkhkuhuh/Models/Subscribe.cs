using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}
