using System;

namespace ConsoleApp
{
    //we cannot create the objects
    //we cannot have normal constructors
    //all the members of this class are static variables, properties an methods
    public static class StaticClass
    {
        public static int i = 10;
        public static string Name { get; set; }

        static StaticClass()
        {
        }

        public static void SomeMethods()
        {
        }
    }

    public class NonStaticClass
    {
        public int i = 10;
        public static int staticI = 10;
        public string Name { get; set; }
        public static string StaticName { get; set; }

        public NonStaticClass()
        {
        }

        static NonStaticClass()
        {
        }

        //Non static members can access static and non static members
        public void SomeMethod()
        {
            i++; //nonstatic member
            staticI++; //static member
            Console.WriteLine($"i={i} and staticI={staticI}");
        }

        //static members can access static members only
        public static void SomeStaticMethod()
        {
            // SomeMethod();
            //i++;//cannot access non static member
            staticI++;//can access static members
        }
    }
}
