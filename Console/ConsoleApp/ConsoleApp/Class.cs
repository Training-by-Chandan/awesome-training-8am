using System;

namespace ConsoleApp
{
    public class Test
    {
        private int X;

        public Test(int x)
        {
            X = x;
        }

        public Test()
        {
            X = 10;
        }

        public Test(int x, int y)
        {
            X = x + y;
        }

        //Functions
        //access modifier (public / private)
        //return type (void (does not return) / other return types )
        //function name
        //parameters

        public void Add()
        {
            //statements
            Console.WriteLine("I am from add function");
            Console.WriteLine("I am from add function");
            Console.WriteLine("I am from add function");
            Sum(5f, 10);
            Sum(5, 10f);
            //var t = 10m;
            //return;
        }

        //function overloading
        public int Sum(int x, float y) //1
        {
            return x + (int)y;
        }

        public int Sum(float y, int x) //2
        {
            return (int)y + x;
        }

        public int Sum(int x, int y, int z) => x + y + z;

        public int Sum(int x, int y) => x + y;
    }

    public class Human
    {
        //variables
        //properties

        //constructor
        //special function with
        //1. No return type
        //2. Function name is same as that of class name
        //3. Can be overloaded (parameterless (default), parameterized)
        //4. Runs only once in a object's lifetime

        //functions / methods
        //destructor : not used / IDispoable or Garbage Collector

        //new Hand() is a new object and LeftHand is variable to store that object
        public Hand LeftHand = new Hand();

        public Hand RightHand = new Hand();
        private string name = "Babu";

        public string GetName()
        {
            return name;
        }

        public string Name1 { get; } //readonly property
        public string Name2 { get; set; } //read and write property
        public string Name3 { get; private set; } //read publicly but write privately

        //access modifier : public and private
        public void Test()
        {
            Name3 = "abc";
            Name2 = "abc";
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    public class Hand
    {
        public int NumberOfFingers = 5;
    }

    public class StudentMarks
    {
        public string Name { get; set; }

        //validations
        private double _math;

        public double Math
        {
            get
            {
                return _math;
            }
            set
            {
                if (value < 0)
                {
                    _math = 0;
                }
                else if (value > 100)
                {
                    _math = 100;
                }
                else
                {
                    _math = value;
                }
            }
        }

        private double _science;

        public double Science
        {
            get { return _science; }
            set
            {
                _science = value < 0 ? 0 : value > 100 ? 100 : value;
            }
        }

        private double _computer;

        public double Computer
        {
            get { return _computer; }
            set
            {
                if (value < 0) _computer = 0;
                else if (value > 100) _computer = 100;
                else _computer = value;
            }
        }

        public double Total
        {
            get
            {
                return Math + Science + Computer;
            }
        }

        public double Percentage
        {
            get
            {
                return Total / 3;
            }
        }

        public string Division
        {
            get
            {
                if (Percentage >= 80)
                {
                    return "Distinction";
                }
                else if (Percentage >= 60)
                {
                    return "First Division";
                }
                else if (Percentage >= 45)
                {
                    return "Second Division";
                }
                else if (Percentage >= 32)
                {
                    return "Third Division";
                }
                else
                {
                    return "Fail";
                }
            }
        }
    }
}
