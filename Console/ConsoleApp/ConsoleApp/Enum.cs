namespace ConsoleApp
{
    public enum DaysOfWeek
    {
        Sunday = 5,
        Monday,
        Tuesday, //31
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum AddressType
    {
        Permanent,
        Temporary
    }

    public enum AccountTypes
    {
        Savings,
        Current
    }

    public enum Roles
    {
        User = 10,
        Admin,
        Teacher,
        Parent,
        Student
    }

    public class TestingClass
    {
        private DaysOfWeek day;

        public TestingClass(DaysOfWeek d)
        {
            day = d;
        }
    }
}