namespace Ecom.Web
{
    public class MathOps
    {
        public int Add(int a, int b)
        {
            if (a == 0)
            {
                throw new System.NotSupportedException("Not Valid");
            }
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}