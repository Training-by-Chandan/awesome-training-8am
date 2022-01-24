using System;
namespace ConsoleApp
{
    public class CustomStack
    {
        public CustomStack()
        {

        }
        public CustomStack(int maxSize)
        {
            _maxSize = maxSize;
            _container=new int[maxSize];
        }
        private int _maxSize = 5;
        //Array -> container
        private int[] _container = new int[5];
        //int -> counter
        private int _counter = -1;
        //Push() -> function Push(1), Push(10), Push(5)
        public void Push(int item)
        {
            if(_counter < _maxSize-1)
            {
                _counter++;
                _container[_counter] = item;
            }
        }
        //Pop() -> function exit the top most item
        public void Pop()
        {
            if(_counter>=0)
            {
                _container[_counter] = 0;
                _counter--;
            }
        }
        //DisplayAll() -> function
        public void DisplayAll()
        {
            for (int i = _counter; i >=0 ; i--)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }

    public class CustomStackV2
    {
        //Array -> container
        private int[] _container = new int[0];
      
        //Push() -> function Push(1), Push(10), Push(5)
        public void Push(int item)
        {
            Array.Resize(ref _container, _container.Length + 1);
            _container[_container.Length-1] = item;
        }
        //Pop() -> function exit the top most item
        public void Pop()
        {
           Array.Resize(ref _container, _container.Length-1);
        }
        //DisplayAll() -> function
        public void DisplayAll()
        {
            for (int i = _container.Length-1; i >= 0; i--)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }
}
