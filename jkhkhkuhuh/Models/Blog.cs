using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150),Required(ErrorMessage ="Blogun Basligi qeyd olunmalidir!!!")]
        public string Tittle { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [Column(TypeName="ntext"),Required(ErrorMessage ="Blogun Kontenti bos qoyula bilmez!!!")]
        public string Content { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public BlogCategory Category { get; set; }

        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
        public DateTime CreatTime { get; set; }
        public int Weius { get; set; }
        public List<Blogimage> Blogimages { get; set; }
        public List<Comment> Comments { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }
        public List<Tag> Tags { get; set; }

    }
}
