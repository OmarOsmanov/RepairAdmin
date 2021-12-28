using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Logo { get; set; }
        [MaxLength(150)]
        public string Adress { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(30)]
        public string MAil { get; set; }
        [MaxLength(30)]
        public string Oppening { get; set; }
        [MaxLength(60)]
        public string HomeTiitle { get; set; }
        [MaxLength(500)]
        public string HomeContext { get; set; }
        [MaxLength(50)]
        public string HomeImage { get; set; }

    }
}
