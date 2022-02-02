using System;

namespace ConsoleApp
{
    public interface IShape
    {
        void GetInput();

        void Area();

        void Perimeter();
    }

    public class Square : IShape
    {
        private double _length;

        public void Area()
        {
            var area = Math.Pow(_length, 2);
            Console.WriteLine(area);
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the Length");
            _length = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            var perimeter = 4 * _length;
            Console.WriteLine(perimeter);
        }
    }

    public class Rectangle : IShape, IRectangle
    {
        private double _length;
        private double _breadth;

        public void Area()
        {
            var area = _length * _breadth;
            Console.WriteLine(area);
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the Length");
            _length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth");
            _breadth = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            var perimeter = 2 * (_length + _breadth);
            Console.WriteLine(perimeter);
        }
    }

    public class Circle : IShape
    {
        private double _radius;

        public void Area()
        {
            var area = Math.PI * Math.Pow(_radius, 2);
            Console.WriteLine(area);
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the radius");
            _radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            var perimeter = 2 * Math.PI * _radius;
            Console.WriteLine(perimeter);
        }
    }

    public class Triangle : IShape
    {
        public void Area()
        {
            // throw new NotImplementedException();
        }

        public void GetInput()
        {
            // throw new NotImplementedException();
        }

        public void Perimeter()
        {
            //throw new NotImplementedException();
        }
    }
}