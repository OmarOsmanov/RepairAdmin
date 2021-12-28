using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class Blogimage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }


    }
}
