namespace WebApp.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string Fullname
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}