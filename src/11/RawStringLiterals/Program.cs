namespace RawStringLiterals;

class Program
{
    static void Main(string[] args)
    {
        var phrase = """
                     Some
                        text
                            strings.
                     """;
        Console.WriteLine(phrase);
        phrase = $$"""
                    Some last string: {
                        {{phrase}}
                    }
                   """;
        Console.WriteLine(phrase);
    }
}