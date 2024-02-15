namespace StaticLocalFunctions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(AddMethod());
    }
    
    static int AddMethod()
    {
        int y = 5;
        int x = 7;
        return Add(x, y);

        static int Add(int left, int right) => left + right;
    }
}