namespace NullableReferenceTypes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetLength("Hello, World!"));
    }

    private static int GetLength(string? str)
    {
        if (str == null) throw new ArgumentNullException(nameof(str));
        return str.Length;
    }
}