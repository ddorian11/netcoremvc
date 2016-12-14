using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcoremvc.Models
{
    public class ReviewTable
    {
        [Key]
        public string Id { get; set; }

        public DateTime DateTime { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(1000)]
        public string Comment { get; set; }
    }
}
