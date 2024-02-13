namespace PatternMatching;

class Program
{
    static void Main(string[] args)
    {
        PrintStars(5);
        Console.WriteLine(WaterState(100));
    }

    private static void PrintStars(object o)
    {
        if (o is null) return; // constant pattern "null"
        if (!(o is int i)) return; // type pattern "int i"
        Console.WriteLine(new string('*', i));
    }

    private static string WaterState(int tempInFahrenheit) =>
        tempInFahrenheit switch
        {
            > 32 and < 212 => "liquid",
            < 32           => "solid",
            > 212          => "gas",
            32             => "solid/liquid transition",
            212            => "liquid / gas transition",
        };
}