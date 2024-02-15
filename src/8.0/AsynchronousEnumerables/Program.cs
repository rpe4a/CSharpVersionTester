namespace AsynchronousEnumerables;

class Program
{
    static async Task Main(string[] args)
    {
        await foreach (int value in GenerateSequence())
        {
            Console.WriteLine(value);
        }
    }
    
    private static async IAsyncEnumerable<int> GenerateSequence()
    {
        for (int i = 0; i < 20; i++)
        {
            await Task.Delay(100);
            yield return i;
        }
    }
}