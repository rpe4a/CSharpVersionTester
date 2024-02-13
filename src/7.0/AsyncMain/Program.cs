namespace AsyncMain;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Waiting 3 sec.");
        await Task.Delay(3000);
        Console.WriteLine("Exit!");
    }
}