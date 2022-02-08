using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Delegates
    {
        //pointer for a function
        //it also defines the signature of a function
        public delegate void MathDelegate(int i, int j);
        public MathDelegate m;

        public event MathDelegate MathEvent;

        public void ReactToEvent(int x, int y)
        {
            //if (MathEvent!=null)
            //{
            //    MathEvent.Invoke(x, y);
            //}
            //or 
            MathEvent?.Invoke(x, y);
        }

        public void Implementation()
        {
            //add the function in the delegate
            MathDelegate m = new MathDelegate(Add);
            m(10, 20);
            m += Subtract;
            m(10, 20);
            m += Multiply;
            m(10, 20);
            m += Divide;
            m(10, 20);
            //anonymous function
            m += (int x, int y) => { 
                Console.WriteLine($"Remainder = {x%y}"); 
            };
            m(10, 20);
            m -= Subtract;
            m(10, 20);
        }

        public void Add(int i, int j)
        {
            Console.WriteLine($"Sum = {i + j}");
        }

        public void Subtract(int i, int j)
        {
            Console.WriteLine($"Difference = {i - j}");
        }

        public void Multiply(int i, int j)
        {
            Console.WriteLine($"Product = {i * j}");
        }

        public void Divide(int i, int j)
        {
            Console.WriteLine($"Dividend = {i / j}");
        }
    }
}