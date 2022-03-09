using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstIntegration.Models
{
    public class Student
    {
        public int id { get; set; }

        //attributes
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Class Classes { get; set; } //navigation property
    }
}