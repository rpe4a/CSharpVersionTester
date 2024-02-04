namespace ExceptionFilters;

class Program
{
    static void Main(string[] args)
    {
        ExceptionFilters("5", "date", "1");
    }

    public static void ExceptionFilters(string aDouble, string date, string anInt)
    {
        try
        {
            var d = Double.Parse(aDouble);
            var dateTime = DateTime.Parse(date);
            var n = Int32.Parse(anInt);
        }
        catch (FormatException e) when (e.Message.IndexOf("DateTime", StringComparison.Ordinal) > -1)
        {
            Console.WriteLine($"Problem parsing \"{nameof(date)}\" argument");
        }
        catch (FormatException x)
        {
            Console.WriteLine("Problem parsing some other argument");
        }
    }

}