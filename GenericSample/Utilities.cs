namespace GenericSample
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // TODO: 目前傳入的參數無法比較
        public T Max<T>(T a, T b)
        {
            return a > b ? a : b;
        }
    }
}