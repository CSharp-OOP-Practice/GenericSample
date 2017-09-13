namespace GenericSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
        }
    }
}
