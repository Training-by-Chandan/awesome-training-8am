using System;

namespace ConsoleApp
{
    public class CustomQueue
    {
        public CustomQueue(int maxSize)
        {
            _maxSize = maxSize;
            _container = new int[maxSize];
        }

        public CustomQueue()
        {
            _maxSize = 5;
            _container = new int[_maxSize]; // o to 4 => 0 to maxSize-1
        }

        private int _maxSize;
        private int[] _container;
        private int _counter = -1;

        public void Enqueue(int item)
        {
            //first call => _counter=-1
            //second call => _counter=0
            //third call => _counter=1
            //forth call => _counter=2
            //fifth call => _counter=3
            if (_counter < _maxSize - 1)
            {
                _counter++;
                _container[_counter] = item;
                Console.WriteLine($"Enqueued item {item}");
            }
            else
            {
                Console.WriteLine("Queue is full! Cannot add items");
            }
            //first call => _counter=0
            //second call => _counter=1
            //third call => _counter=2
            //forth call => _counter=3
            //fifth call => _counter=4
        }

        public void Dequeue()
        {
            if (_counter >= 0)
            {
                var popped = _container[0];

                for (int i = 1; i <= _counter; i++)
                {
                    _container[i - 1] = _container[i];
                }
                _counter--;

                Console.WriteLine($"Dqueued item is {popped}");
            }
            else
            {
                Console.WriteLine("Queue is empty, cannot remove items from blank queue");
            }
        }

        public void DisplayAll()
        {
            for (int i = _counter; i >= 0; i--)
            {
                Console.Write($" {_container[i]}");
            }
            Console.WriteLine();
        }
    }

    public class CustomQueueV2<T>
    {
        private T[] _container = new T[0];

        public void Enqueue(T item)
        {
            Array.Resize(ref _container, _container.Length + 1);

            _container[_container.Length - 1] = item;
        }

        public void Dequeue()
        {
            if (_container.Length > 0)
            {
                var popped = _container[0];

                for (int i = 1; i <= _container.Length - 1; i++)
                {
                    _container[i - 1] = _container[i];
                }
                Array.Resize(ref _container, _container.Length - 1);

                Console.WriteLine($"Dqueued item is {popped}");
            }
            else
            {
                Console.WriteLine("Queue is empty, cannot remove items from blank queue");
            }
        }

        public void DisplayAll()
        {
            for (int i = _container.Length - 1; i >= 0; i--)
            {
                Console.Write($" {_container[i]}");
            }
            Console.WriteLine();
        }
    }
}