using System;

namespace GenericSample
{
    // where T : IComparable
    // where T : 自定類別名稱
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        /// <summary>
        /// 透過 where 後面的 new() 以便方法裡面可以new T
        /// </summary>
        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}