namespace NullOperator;

class Program
{
    static void Main(string[] args)
    {
        string?[] strings = ["Foo", null];
        int? length0 = strings[0]?.Length; // 3
        int? length1 = strings[1]?.Length; // null
        IEnumerable<int> lengths = strings.Select(s => s?.Length ?? 0); //[3, 0]
        Console.WriteLine($"{nameof(length0)}: {length0}");
        Console.WriteLine($"{nameof(length1)}: {(length1.HasValue ? length1.Value : "NULL")}");
        Console.WriteLine($"{nameof(lengths)}: {lengths.Count()}");
    }
}