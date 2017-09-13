using System;

namespace GenericSample
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // 利用 where 加入 T 的限制
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}