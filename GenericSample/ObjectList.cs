using System;

namespace GenericSample
{
    /// <summary>
    /// .NET 1.0 沒有 generic 時的做法
    /// </summary>
    /// TODO: 將此class加入泛型改寫
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
