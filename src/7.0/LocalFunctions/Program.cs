namespace LocalFunctions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{nameof(Fibonacci)}: {Fibonacci(10)}");
    }

    static int Fibonacci(int x)
    {
        if (x < 0) throw new ArgumentException("Less negativity please!", nameof(x));
        return Fib(x).current;

        static (int current, int previous) Fib(int i)
        {
            if (i == 0) return (1, 0);
            var (p, pp) = Fib(i - 1);
            return (p + pp, p);
        }
    }
}