namespace MorePatterns;

public enum Rainbow
{
    Red,
    Orange,
    Yellow
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FromRainbow(Rainbow.Orange));
        Console.WriteLine(FromRainbow(Rainbow.Yellow));
        Console.WriteLine(IsConferenceDay(DateTime.Now));
        Console.WriteLine(RockPaperScissors("rock", "paper"));
    }

    private static bool IsConferenceDay(DateTime date)
        => date is {Year: 2020, Month: 5, Day: 19 or 20 or 21 or 22 or 23};

    private static string RockPaperScissors(string first, string second)
        => (first, second) switch
        {
            ("rock", "paper")    => "rock is covered by paper. Paper wins.",
            ("rock", "scissors") => "rock breaks scissors. Rock wins.",
            (_, _)               => "tie"
        };

    private static string FromRainbow(Rainbow colorBand)
        => colorBand switch
        {
            Rainbow.Red    => "red",
            Rainbow.Orange => "orange",
            Rainbow.Yellow => "yellow",
            _              => throw new ArgumentOutOfRangeException(nameof(colorBand), colorBand, null)
        };
}