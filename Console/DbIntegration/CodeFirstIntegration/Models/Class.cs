using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstIntegration.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}