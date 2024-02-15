using System.Text;

namespace UsingDeclarations;

class Program
{
    static void Main(string[] args)
    {
        using FileStream stream = File.OpenRead(@"./resource/test.txt");
        using StreamReader sr = new StreamReader(stream);
        Span<char> buffer = stackalloc char[1024];
        while (sr.ReadBlock(buffer) > 0)
        {
            Console.WriteLine(buffer.ToArray());
        }

        Console.WriteLine(File.ReadAllText(@"./resource/test.txt"));
    }
}