namespace OutVariables;

class Program
{
    static void Main(string[] args)
    {
        PrintStars("10");
        PrintStars("Not a star.");
    }

    private static void PrintStars(string s)
    {
        if (int.TryParse(s, out int i))
        {
            Console.WriteLine(new string('*', i));
        }
        else
        {
            Console.WriteLine("Cloudy - no stars tonight!");
        }
    }
}