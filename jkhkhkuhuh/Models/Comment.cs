using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(150)]
        public string Subject { get; set; }
        [MaxLength(2000)]
        public string Content { get; set; }
        
        public DateTime CreateTime { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }



    }
}
