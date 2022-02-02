namespace ConsoleApp
{
    public class Templated<T1, T2, T3, T4>
        where T1 : IShape
        where T2 : ShapeAbs
        where T3 : struct
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
        public T4 Item4 { get; set; }

        public void FunctionOne(T1 item1, T1 item2, T3 item3, T4 item4)
        {
        }
    }

    public class NonTemplatedClass
    {
        public void FunctionOne<T1, T2>(T1 item1, T2 item2)
        {
        }
    }
}