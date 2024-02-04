namespace StringInterpolation;

class Program
{
    static void Main(string[] args)
    {
        int[] values = [1, 2, 3, 4, 5, 6];
        foreach (string s in values.Select(i => $"The value is {i,10:N2}."))
        {
            Console.WriteLine(s);
        }

        Console.WriteLine($"Minimum is {values.Min(i => i):N2}.");
    }
}