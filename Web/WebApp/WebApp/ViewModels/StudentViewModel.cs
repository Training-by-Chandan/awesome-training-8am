using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

       
        public int Age { get; set; }

        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string Fullname
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}