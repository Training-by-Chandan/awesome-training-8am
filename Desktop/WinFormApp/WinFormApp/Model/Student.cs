using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    [Table("StudentInfo")]
    public class Student
    {
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column("FName", Order = 2)]
        public string FirstName { get; set; }

        [Column("LName", Order = 1)]
        public string LastName { get; set; }

        public string Email { get; set; }
    }
}