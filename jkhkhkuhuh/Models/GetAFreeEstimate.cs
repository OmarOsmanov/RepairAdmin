using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class GetAFreeEstimate
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string FullName { get; set; }
        [MaxLength(150)]
        public string Phone { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
