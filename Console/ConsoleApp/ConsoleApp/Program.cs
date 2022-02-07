using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var res = "n";
            int x = 100;
            do
            {
                Console.Clear(); //clear the console screen
                //Add();
                //CastingExamples();
                //CalculateAge();
                //ControlStatementExample();
                //SwitchStatementExample();
                //MultiplicationTable();
                //ForEachStatement();
                //ClassExample2();
                //ConstructorExample();
                //OperatorOverloadingExample();
                //IndexersExample();
                //StaticAndNonStaticExample();
                //InheritanceExample();
                //InheritanceExampleV2();
                //InterfaceExample();
                //InterfaceExampleV2();
                //AbstractExample();
                //CustomStackImplementation();
                //CustomQueueImplementation();
                //TemplatedCustomStack();
                //NonGenericColelctionExample();
                //GenericCollectionExamples();
                PassbyExamples();

                Console.WriteLine("Do you want to contiue more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToLower() == "y");
            //ToLower() converts all the characters in the text to lower string

            Console.ReadLine();
        }

        private static void PassbyExamples()
        {
            int i = 10;
            int j = 20;
            Console.WriteLine($"i => {i}, j => {j}");
            Console.WriteLine("Using Pass by value");
            Passby.PassbyValue(i, j);
            //Passby.PassbyValue(10, 20);
            Console.WriteLine($"i => {i}, j => {j}");

            Console.WriteLine("\n\nUsing Pass by reference");
            Passby.PassbyReference(ref i, ref j);
            //Passby.PassbyReference(address of i, address of j);
            Console.WriteLine($"i => {i}, j => {j}");

            Console.WriteLine("\n\nUsing Out");
            int res = 0;
            Passby.PassOut(i, j, out res);
            //Passby.PassbyReference(address of i, address of j);
            Console.WriteLine($"i => {i}, j => {j}, res = {res}");

            Passby.DefaultParameters(s: "abc", i: 20);
        }

        private static void GenericCollectionExamples()
        {
            GenericCollections.HashSetExample();
            GenericCollections.DictionaryExample();
            GenericCollections.ListExample();
        }

        private static void NonGenericColelctionExample()
        {
            NonGenericCollection.ArrayListExample();
            NonGenericCollection.SortedListExample();
        }

        private static void TemplatedCustomStack()
        {
            //CustomStackV2Templated<int> stackInt=new CustomStackV2Templated<int>();
            //CustomStackV2Templated<string> stackString=new CustomStackV2Templated<string>();
            //stackInt.Push(1);
            //stackString.Push("ABC");

            //CustomStackV2Templated<IShape> stackShape = new CustomStackV2Templated<IShape>();
            //stackShape.Push(new Rectangle());
            //stackShape.Push(new Square());
            //stackShape.Push(new Circle());

            CustomStackV2Templated<Rectangle> stackRectangle = new CustomStackV2Templated<Rectangle>();
            stackRectangle.Push(new Rectangle());
            stackRectangle.Push(new Rectangle());
            stackRectangle.Push(new Rectangle());

            CustomStackV2Templated<RectangleAbs> stackRectangleAbs = new CustomStackV2Templated<RectangleAbs>();

            Templated<Rectangle, SquareAbs, int, string> templatedObj = new Templated<Rectangle, SquareAbs, int, string>();
        }

        private static void CustomQueueImplementation()
        {
            NewClass c = new NewClass();
            c.Name = "Chandan";

            CustomQueueV2<int> cq = new CustomQueueV2<int>();
            cq.Enqueue(10);
            cq.Enqueue(20);
            cq.Enqueue(15);
            cq.DisplayAll();
            cq.Dequeue();
            cq.DisplayAll();

            cq.Enqueue(30);
            cq.Enqueue(20);
            cq.Enqueue(32);
            cq.Enqueue(31); //this shouldn't go
            cq.Enqueue(31); //this shouldn't go
            cq.Enqueue(34); //this shouldn't go
            cq.Enqueue(32); //this shouldn't go
            cq.Enqueue(315234); //this shouldn't go
            cq.Enqueue(23541); //this shouldn't go
            cq.Enqueue(32345); //this shouldn't go
            cq.DisplayAll();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.DisplayAll();
        }

        private static void CustomStackImplementation()
        {
            CustomStackV2 cs = new CustomStackV2();
            cs.Push(20);
            cs.Push(25);
            Console.WriteLine("After pushing 2 items");
            cs.DisplayAll();
            Console.WriteLine();

            cs.Pop();
            Console.WriteLine("After poping");
            cs.DisplayAll();
            Console.WriteLine();

            cs.Push(30);
            cs.Push(35);
            cs.Push(40);
            cs.Push(45);
            cs.Push(50);
            Console.WriteLine("After pushing 5 items");
            cs.DisplayAll();
            Console.WriteLine();

            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            Console.WriteLine("After poping");
            cs.DisplayAll();
            Console.WriteLine();
        }

        private static void AbstractExample()
        {
            //ShapeAbs s = new ShapeAbs();// we cannot create the object of abstract class
            Console.WriteLine("Enter the choice");
            var shape = GetShapeAbs(Console.ReadLine());

            if (shape != null)
            {
                shape.GetInput();
                shape.Area();
                shape.Perimeter();
            }
        }

        private static ShapeAbs GetShapeAbs(string choice)
        {
            if (choice == "1")
            {
                return new SquareAbs();
            }
            else if (choice == "2")
            {
                return new RectangleAbs();
            }
            else
            {
                return null;
            }
        }

        private static void InterfaceExampleV2()
        {
            Console.WriteLine("Enter the choice");
            var choice = Console.ReadLine();

            var shape = GetShape(choice);
            shape.GetInput();
            shape.Area();
            shape.Perimeter();
        }

        private static IShape GetShape(string choice)
        {
            if (choice == "1")
            {
                return new Rectangle();
            }
            else if (choice == "2")
            {
                return new Circle();
            }
            else if (choice == "3")
                return new Triangle();
            else
            {
                return new Square();
            }
        }

        private static void InterfaceExample()
        {
            ConsoleApp[] consoles = new ConsoleApp[10];
            consoles[0] = new ConsoleApp();
            consoles[1] = new ConsoleApp();

            TestClass[] testClasses = new TestClass[10];
            testClasses[0] = new TestClass();
            testClasses[1] = new TestClass();

            //IConsoleApp c=new IConsoleApp(); // this is not valid

            IConsoleApp[] consoleApps = new IConsoleApp[10];
            consoleApps[0] = new ConsoleApp();
            consoleApps[1] = new TestClass();
            consoleApps[2] = new NewClass();

            IConsoleApp consoleApps2 = new TestClass();
        }

        private static void InheritanceExampleV2()
        {
            //Test t1=new Test();
            //Test t2=new Test(100);
            //Test t3=new Test(20,20);

            //LivingThing thing = new LivingThing();
            LivingThing thing1 = new LivingThing("SomeId");

            Animal a1 = new Animal();
            Animal a2 = new Animal("someid");

            HumanBeing h1 = new HumanBeing();

            Plant plant1 = new Plant();
        }

        private static void InheritanceExample()
        {
            LivingThing l1 = new LivingThing();
            LivingThing a1 = new Animal();
            LivingThing p1 = new Plant();

            Console.WriteLine("Living thing");
            l1.Move();
            Console.WriteLine();

            Console.WriteLine("Animal");
            a1.Move();
            Console.WriteLine();

            Console.WriteLine("Plant");
            p1.Move();
            Console.WriteLine();
        }

        private static void StaticAndNonStaticExample()
        {
            IndexersExample();
            //StaticClass s = new StaticClass();//we cannot do this
            NonStaticClass nonStatic = new NonStaticClass();
            NonStaticClass nonStatic1 = new NonStaticClass();
            NonStaticClass nonStatic2 = new NonStaticClass();
            //nonStatic.i = 10;
            //nonStatic.Name = "";
            nonStatic.SomeMethod();
            nonStatic1.SomeMethod();
            nonStatic2.SomeMethod();

            NonStaticClass.staticI = 10;
            NonStaticClass.StaticName = "";
            NonStaticClass.SomeStaticMethod();

            StaticClass.i = 10;
            StaticClass.Name = "Some string";
        }

        private static void IndexersExample()
        {
            Days d = new Days();
            var day = d[0];
            var index = d["OtherDay"];
            StudentMarks[] marks = new StudentMarks[4];

            marks[0] = new StudentMarks() { Name = "Satyam", Math = 78, Science = 50, Computer = 67 };
            marks[1] = new StudentMarks() { Name = "Satyam", Math = 78, Science = 50, Computer = 67 };
            marks[2] = new StudentMarks() { Name = "Prabi", Math = 75, Science = 70, Computer = 56 };
            marks[3] = new StudentMarks() { Name = "Prabi", Math = 75, Science = 70, Computer = 56 };

            Marks m = new Marks(marks);

            var result = m["Satyam"];
            var result1 = m["Prabi"];
        }

        private static void OperatorOverloadingExample()
        {
            //int i = 10;
            //int j = 20;
            //int k = i + j;
            StudentMarks studentMarks1 = new StudentMarks() { Math = 78, Science = 50, Computer = 67 };
            StudentMarks studentMarks2 = new StudentMarks() { Math = 78, Science = 50, Computer = 67 };
            StudentMarks studentMarks3 = new StudentMarks() { Math = 75, Science = 70, Computer = 56 };
            StudentMarks studentMarks4 = new StudentMarks() { Math = 75, Science = 70, Computer = 56 };

            StudentMarks studentMarks = studentMarks1 + studentMarks2 + studentMarks3 + studentMarks4;
            int i = 10;
            i++;

            Console.WriteLine(studentMarks1 == studentMarks2);
        }

        private static void ConstructorExample()
        {
            Test t1 = new Test();
            Test t2 = new Test(5);
            Test t3 = new Test(6, 3);
            t1 = new Test();
            var sum = t1.Sum(5, 10, 10);
        }

        private static void ClassExample2()
        {
            StudentMarks s1 = new StudentMarks();
            s1.Name = "Mamta";
            s1.Math = 1000;
            s1.Science = 700;
            s1.Computer = 60;
            Console.WriteLine($"Total : {s1.Total}\nPercentage : {s1.Percentage}\nDivision : {s1.Division}\n\n");
            s1.Computer = 70;
            Console.WriteLine($"Total : {s1.Total}\nPercentage : {s1.Percentage}\nDivision : {s1.Division}\n\n");
        }

        private static void ClassExample()
        {
            //class is the blueprint / designs that holds the properties and methods together
            //objects are the instance of the class
            Human h1 = new Human();
            // h1.SetName( "Adish");
            var name1 = h1.Name1;

            var name2 = h1.Name2;
            h1.Name2 = "abc";

            var name3 = h1.Name3;
            // h1.Name3 = "abc";

            h1.LeftHand = new Hand();
            h1.RightHand = new Hand();

            Human h2 = new Human();
            //h2.name = "Mamta";
            h2.LeftHand = new Hand();
            h2.RightHand = new Hand();

            Human h3 = new Human();
        }

        private static void ForEachStatement()
        {
            Console.WriteLine("Enter any text");
            string str = Console.ReadLine();
            var strArr = str.Split(' ');

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Using foreach statement");
            foreach (string item in strArr)
            {
                var characters = item.ToLower().ToArray();
                var uppercharacter = characters[0].ToString().ToUpper();
                characters[0] = Convert.ToChar(uppercharacter);
                var converted = string.Join("", characters);
                Console.Write(converted);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Using for statement");

            for (int i = 0; i < strArr.Length; i++)
            {
                var characters = strArr[i].ToLower().ToArray();
                var uppercharacter = characters[0].ToString().ToUpper();
                characters[0] = Convert.ToChar(uppercharacter);
                var converted = string.Join("", characters);
                Console.Write(converted);
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        private static void MultiplicationTable()
        {
            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                //break : breaks the loop
                //continue : skips the next sequence of statements and continue the loop by increasing the value

                //if (i % 3 == 0)
                //{
                //    continue;
                //}
                //Console.WriteLine(i);
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        private static void CalculateAge()
        {
            var today = DateTime.Now;
            Console.WriteLine($"Today => {today.ToString("MMMM dd, yyyy dddd hh:mm:ss tt")}");

            Console.WriteLine("Enter the Date of Birth (dd/MM/YYYY)");
            var dateStr = Console.ReadLine();
            var dateArr = dateStr.Split('/');
            var date = new DateTime(Convert.ToInt32(dateArr[2]), Convert.ToInt32(dateArr[1]), Convert.ToInt32(dateArr[0]));

            var timeDiff = today - date;
            var years = timeDiff.Days / 365;
            Console.WriteLine($"{years} years old");
        }

        private static void SwitchStatementExample()
        {
            Console.WriteLine("Enter the number");
            //string input = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            string day = "";
            string type = "";

            switch (num)
            {
                case 1:
                    day = "Sunday";
                    break;

                case 2:
                    day = "Monday";
                    break;

                case 3:
                    day = "Tuesday";
                    break;

                case 4:
                    day = "Wednesday";
                    break;

                case 5:
                    day = "Thursday";
                    break;

                case 6:
                    day = "Friday";
                    break;

                case 7:
                    day = "Saturday";
                    break;

                default:
                    day = "Holiday";
                    break;
            }
            switch (num)
            {
                case 1:
                case 7:
                    type = "Weekends";
                    break;

                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    type = "Weekdays";
                    break;

                default:
                    type = "N/A";
                    break;
            }

            Console.WriteLine($"Days = {day} and Type = {type}");
        }

        private static void ControlStatementExample()
        {
            Console.WriteLine("Enter the number");
            //string input = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            string day = "";
            if (num == 1)
                day = "Sunday";
            else if (num == 2)
                day = "Monday";
            else if (num == 3)
                day = "Tuesday";
            else if (num == 4)
                day = "Wednesday";
            else if (num == 5)
                day = "Thursday";
            else if (num == 6)
                day = "Friday";
            else if (num == 7)
                day = "Saturday";
            else
                day = "Holiday";
            // (condition)?<True statement>:<false statement>
            //tenary operator
            //day = (num == 1) ? "Sunday" : (num == 2) ? "Monday" : (num == 3) ? "Tuesday" : (num == 4) ? "Wednesday" : (num == 5) ? "Thursday" : (num == 6) ? "Friday" : (num == 7) ? "Saturday" : "Holiday";

            string type = "";
            if (num == 1 || num == 7)
                type = "Weekends";
            else if (num == 2 || num == 3 || num == 4 || num == 5 || num == 6)
                type = "Weekdays";
            else
                type = "N/A";

            Console.WriteLine($"Days = {day} and Type = {type}");
        }

        private static void CastingExamples()
        {
            {
                char X = 'A';
                X.ToString();

                //Define block variable will be defines as in same block only not the othe block//
            }
            //for just example X.Tostring(); is not possible//

            //implcit casting//

            //char -- int- long -- floar -- double

            char c = 'A'; //65 ASCII CODE(American Standard Code for Information Interchange)
            //FOR EXAMPLE Dec = 65 , OCT = 101 , HEX = 41 , BIN = 01000000, SYMBOL =@ , HTML number = &#64; Description - At symbol//
            int i = c; //c is char so , so we can convert char in int but cannot put int value in char//
            long l = i;
            float f = l;
            double d = f; //so i can do double d = c//
            //we can directly assign value//

            //explicting casting//
            double d1 = 1234.567d; //f = floating point, m =decimal//
            //float f1 = d1; we cannot do this , we can put float into double but cannot put double inn float//
            //because double 64 is double information and f  is single 32, but we can do by//
            float f1 = (float)d1; // it can be go in decimal value as well as double too//
            //from backward like double -- float -- long -- int --char//
            long l1 = (long)f1; // or //
            //long l1 = (long)(float)d1;//
            int i1 = (int)l1; // or Convert.Toint32(f1); or it goes only whole number//
            char c1 = (char)i1;

            //everything can be converted to string using 'Tostring();, for the case below string we need this//

            string str = c.ToString();
            string str1 = i.ToString();

            //type conversion class//
            string str3 = "1"; //64 bit floaring point//
            string str4 = "A";
            string str5 = "Tam"; // we cannot convert this error will come//
            double d3 = 1241.1212;
            //now converting string into double then//
            double d4 = Convert.ToDouble(str3); // it means we can easily convert string by /tostring but converting 1 into double then
                                                //int i2 = Convert.Toint32(str3);=
                                                //or//
            int i2 = Convert.ToInt32(d3); //18+ overloads we can pass // u long means no neagative value//
            //for the decimal//
            decimal dec1 = Convert.ToDecimal(str3);
        }

        public static void Add()
        {
            Console.Write("Enter first number : ");
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            Console.Write("Enter second number : ");
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            int result = num1 + num2;
            Console.WriteLine("Sum = " + result);
        }
    }
}