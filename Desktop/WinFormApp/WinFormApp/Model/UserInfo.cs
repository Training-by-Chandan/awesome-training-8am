namespace WinFormApp.Model
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserTypes { get; set; }
    }
}