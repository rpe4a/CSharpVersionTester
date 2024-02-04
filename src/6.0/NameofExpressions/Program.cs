namespace NameofExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Size of {nameof(args)}: {args.Length}");
        Console.WriteLine($"Hello, {nameof(Program.Main)}!");

        List<int> numbers = [1, 2, 3];
        Console.WriteLine(nameof(numbers)); // output: numbers
        Console.WriteLine(nameof(numbers.Count)); // output: Count
        Console.WriteLine(nameof(numbers.Add));
    }
}