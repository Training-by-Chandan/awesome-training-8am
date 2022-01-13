using System;
using System.Linq;

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
        public StudentMarks()
        {
        }

        public StudentMarks(double fullmarks)
        {
            _fullmarks = fullmarks;
        }

        public string Name { get; set; }
        private double _fullmarks = 100;
        public double Fullmarks => _fullmarks;

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
                else if (value > _fullmarks)
                {
                    _math = _fullmarks;
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
                _science = value < 0 ? 0 : value > _fullmarks ? _fullmarks : value;
            }
        }

        private double _computer;

        public double Computer
        {
            get { return _computer; }
            set
            {
                if (value < 0) _computer = 0;
                else if (value > _fullmarks) _computer = _fullmarks;
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

        #region Operator Overloading

        //operator overloading (+, -, * , /)
        public static StudentMarks operator +(StudentMarks studentMarks1, StudentMarks studentMarks2)
        {
            StudentMarks result = new StudentMarks(studentMarks1.Fullmarks + studentMarks2.Fullmarks);
            result.Math = studentMarks1.Math + studentMarks2.Math;
            result.Science = studentMarks1.Science + studentMarks2.Science;
            result.Computer = studentMarks1.Computer + studentMarks2.Computer;

            return result;
        }

        //increase the marks by 1 for each subject (++,--)
        public static StudentMarks operator ++(StudentMarks studentMarks)
        {
            studentMarks.Math++;
            studentMarks.Science++;
            studentMarks.Computer++;

            return studentMarks;
        }

        public static bool operator >(StudentMarks studentMarks1, StudentMarks studentMarks2)
        {
            return studentMarks1.Total > studentMarks2.Total;
        }

        public static bool operator <(StudentMarks studentMarks1, StudentMarks studentMarks2)
        {
            return studentMarks1.Total < studentMarks2.Total;
        }

        public static bool operator ==(StudentMarks studentMarks1, StudentMarks studentMarks2)
        {
            return studentMarks1.Math == studentMarks2.Math && studentMarks1.Science == studentMarks2.Science && studentMarks1.Computer == studentMarks2.Computer;
        }

        public static bool operator !=(StudentMarks studentMarks1, StudentMarks studentMarks2)
        {
            return !(studentMarks1.Math == studentMarks2.Math && studentMarks1.Science == studentMarks2.Science && studentMarks1.Computer == studentMarks2.Computer);
        }

        #endregion Operator Overloading
    }

    public class Days
    {
        private string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public string this[int i]
        {
            get { return days[i]; }
            set { days[i] = value; }
        }

        public int this[string day]
        {
            get { return days.ToList().IndexOf(day); }
        }
    }

    public class Marks
    {
        private StudentMarks[] _marks;

        public Marks(StudentMarks[] marks)
        {
            this._marks = marks;
        }

        public StudentMarks this[int i]
        {
            get { return _marks[i]; }
            set { _marks[i] = value; }
        }

        public StudentMarks[] this[string name]
        {
            get { return this._marks.Where(p => p.Name == name).ToArray(); }
        }
    }
}
