using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Adish
    {
        public static void Main()
        {
            //Add();
            //CastingExamples();
            CalculateAge();
            Console.ReadLine();
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

        private static void ControlStatementExample()
        {
            Console.WriteLine("Enter the number");
            //string input = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Sunday");
            }
            else if (num == 2)
            {
                Console.WriteLine("Monday");
            }
            else if (num == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (num == 4)
            {
                Console.WriteLine("Wednesday");
            }
            else if (num == 5)
            {
                Console.WriteLine("Thursday");
            }
            else if (num == 6)
            {
                Console.WriteLine("Friday");
            }
            else if (num == 7)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Holiday");
            }
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
            char c1 =(char)i1;

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
