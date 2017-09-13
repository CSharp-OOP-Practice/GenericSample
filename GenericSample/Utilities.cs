using System;

namespace GenericSample
{
    // where T : IComparable
    // where T : 自定類別名稱
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}