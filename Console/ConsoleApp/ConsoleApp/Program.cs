using System;
using System.Collections.Generic;
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
            CastingExamples();

            Console.ReadLine();
        }

        private static void CastingExamples()
        {
            {
                char X = 'A';
                X.ToString();
            }
            //X.ToString();// this is not possible because of scope

            //implicit casting
            //char => int => long => float => double
            char c = 'A';//65 ASCII American Standard Code for Information Interchange
            int i = c;
            long l = i;
            float f = l;
            double d = f;

            //explicit casting
            double d1 = 1234.5677d;
            float f1 = (float)d1;
            long l1 = (long)f1;
            int i1 = (int)f1; //Convert.ToInt32(f1);
            char c1 = (char)i1;

            //everything can be converted to string using '.ToString()'
            string str = c.ToString();
            string str1 = i.ToString();

            //type conversion class (Convert.......)
            string str3 = "1234.245245"; //64 bit floating point number
            double d3 = Convert.ToDouble(str3);
            int i2 = (int)Convert.ToDouble(str3);
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
