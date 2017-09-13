namespace GenericSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(5);

            var books = new GenericList<Book>();
            books.Add(new Book());
        }
    }
}
