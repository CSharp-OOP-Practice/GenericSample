using System;

namespace GenericSample
{
    /// <summary>
    /// 用泛型改寫 ObjectList
    /// </summary>
    /// 透過泛型，不再有boxing、unboxing效能問題
    public class GenericList<T>
    {
        private T _value;

        public void Add(T value)
        {
            this._value = value;
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }


    public class ObjectList
    {
        private object _value;
        public void Add(object value)
        {
            // TODO: 有個問題，如果value是value type，那會 boxing；之後進行處理可能又要 unboxing
            this._value = value;
        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
