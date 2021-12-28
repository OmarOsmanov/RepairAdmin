using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class Future
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
        [MaxLength(50)]
        public string Tittle { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }

    }
}
