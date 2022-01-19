namespace ConsoleApp
{
    public interface IConsoleApp
    {
        // no constructor
        //function's is only declared but not defined
        //properties is declared
        //no access modifier are present

        //public int I = 10; //this is not possible
        //public void SomeFunction()
        //{
        //}
        void SomeFunction();

        void Function2();

        void Function3();

        string Name { get; set; }
    }

    public class ConsoleApp : IConsoleApp
    {
        public string Name { get; set; }

        public void SomeFunction()
        {
            //do some work here
            MyFunction();
        }

        private void MyFunction()
        {
        }

        public void Function3()
        {
            //do some work here
        }

        public void Function2()
        {
            //do some work here
        }
    }

    public class TestClass : IConsoleApp
    {
        public string Name { get; set; }

        public void Function2()
        {
            // throw new System.NotImplementedException();
        }

        public void Function3()
        {
            //throw new System.NotImplementedException();
        }

        public void SomeFunction()
        {
            //throw new System.NotImplementedException();
        }
    }

    public class NewClass : IConsoleApp
    {
        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Function2()
        {
            throw new System.NotImplementedException();
        }

        public void Function3()
        {
            throw new System.NotImplementedException();
        }

        public void SomeFunction()
        {
            throw new System.NotImplementedException();
        }
    }
}
