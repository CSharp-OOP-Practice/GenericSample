namespace GenericSample
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            this._value = value;
        }

        public bool HasValue
        {
            get { return this._value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)this._value;

            return default(T);
        }
    }
}