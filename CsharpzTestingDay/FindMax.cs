namespace CsharpzTestingDay
{
    public class FindMax
    {
        public float MaxNumber(float a, float b, float c)
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