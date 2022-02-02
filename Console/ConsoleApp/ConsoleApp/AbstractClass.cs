using System;

namespace ConsoleApp
{
    //we cannot create the object of abstract class
    //the class needs to be abstract if we want to make the function abstract
    //abstract methods needs to be public / protected
    //abstract method is only declared but not defined within itself
    //derived class needs to use override in order to define the function
    public abstract class ShapeAbs
    {
        protected double area;
        protected double perimeter;

        public void Area()
        {
            Console.WriteLine($"Area : {area}");
        }

        private void _somePrivatFunction()
        {
        }

        protected void someProtectedFunction()
        {
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter : {perimeter}");
        }

        public abstract void GetInput();
    }

    public class RectangleAbs : ShapeAbs, IRectangle
    {
        private double _length;
        private double _breadth;

        public override void GetInput()
        {
            Console.WriteLine("Enter the Length");
            _length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth");
            _breadth = Convert.ToDouble(Console.ReadLine());

            area = _length * _breadth;
            perimeter = 2 * (_length + _breadth);
        }
    }

    public class SquareAbs : ShapeAbs
    {
        private double _length;

        public override void GetInput()
        {
            Console.WriteLine("Enter the Length");
            _length = Convert.ToDouble(Console.ReadLine());

            area = Math.Pow(_length, 2);
            perimeter = 4 * _length;
        }
    }
}