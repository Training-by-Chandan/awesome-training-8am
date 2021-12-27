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
            //Console.Write("Enter the name : ");
            //string str = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Hi " + str + "! Good morning");
            Add();
            Console.ReadLine();
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
