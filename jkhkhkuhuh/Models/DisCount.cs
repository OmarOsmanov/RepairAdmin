using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class DisCount
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Tittle { get; set; }
        [MaxLength(150)]
        public string Content { get; set; }
        [MaxLength(150)]
        public string image { get; set; }
    }
}
