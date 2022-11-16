namespace CsharpzTestingDay
{
    public class FindMax
    {
        public T MaxNumber<T>(T a, T b, T c) where T : IComparable
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0) 
                return a;
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0) 
                return b;
            else 
                return c;
        }

    }
}