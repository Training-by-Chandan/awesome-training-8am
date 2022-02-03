using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    public static class GenericCollections
    {
        public static void ListExample()
        {
            List<string> listString = new List<string>();
            listString.Add("Chandan");
            listString.Add("Adish");
            listString.Add("Jeewsan");
            listString.Add("Satyam");
            List<int> listInt = new List<int>();

            List<string> list = new List<string>();
            list.Add("ABC");
            list.AddRange(listString);
            list.Insert(3, "Broadway");
            var res = list.Find(p => p == "Chandan");
            list.Sort();
            list.Reverse();
            var arr = list.ToArray();
            //var newList = arr.ToList(); // actually in System.Linq
        }

        public static void DictionaryExample()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Sunday");
            dict.Add(2, "Monday");
            dict.Add(3, "Tuesday");
            dict.Add(4, "Wednesday");
            dict.Add(5, "Thursday");
            dict.Add(6, "Friday");
            dict.Add(7, "Saturday");
            //dict.Add(7, "Saturday");// not possible as 7 is already adde
            var day = dict[6];
            Dictionary<string, string> dictNew = new Dictionary<string, string>();
            dictNew.Add("day1", "Sunday");
            dictNew.Add("day2", "Monday");
            dictNew.Add("day3", "Tuesday");
            dictNew.Add("day4", "Wednesday");
            dictNew.Add("day5", "Thursday");
            dictNew.Add("day6", "Friday");
            dictNew.Add("day7", "Saturday");
            var dayNew = dictNew["day5"];
            dictNew.Remove("day6");

            Stack s = new Stack();
            s.Push(1);
            s.Push("abc");
            s.Push(new Rectangle());

            Stack<int> sInt = new Stack<int>();
            foreach (var item in s)
            {
                if (item.GetType() == typeof(int))
                {
                    sInt.Push((int)item);
                }
                //try
                //{
                //    var t = (int)item;
                //    sInt.Push(t);
                //}
                //catch (Exception)
                //{
                //}
            }
        }

        //SortedList<TKey,TValue>, Queue<T>, Stack<T> see it yourself
        public static void HashSetExample()
        {
            HashSet<int> list = new HashSet<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(1);
        }
    }

    public static class NonGenericCollection
    {
        public static void ArrayListExample()
        {
            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add("abc");
            a1.Add("abc");
            a1.Add("abc");
            a1.Add("abc");
        }

        public static void SortedListExample()
        {
            SortedList a2 = new SortedList();
            a2.Add(10, "abc");
            a2.Add(1, "xyz");
            a2.Add(-2, 100);
            a2.Add(3, 100);
            //a2.Add("ABC", 100); // already the key is of t ype int32
            //a2.Add(10, 100); // this is not possible because the key 10 is already added
            SortedList a3 = new SortedList();
            a3.Add("A", "abc");
            a3.Add("z", "abc");
            a3.Add("Ab", "abc");
            a3.Add("xy", "abc");
            a3.Add("aa", "abc");
        }
    }
}