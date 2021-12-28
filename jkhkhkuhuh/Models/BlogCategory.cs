using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class BlogCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50),Required(ErrorMessage ="Blog Categoriyasini bos saxlaya bilmezsiniz!!!")]
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }

    }
}
