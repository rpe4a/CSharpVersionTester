using System.Threading.Channels;

namespace TuplesNew;

class Program
{
    static void Main(string[] args)
    {
        (string first, string middle, string last) fio = LookupName("Ivanov-Ivan-Ivanuch");
        Console.WriteLine($"first: {fio.first}, middle: {fio.middle}, last: {fio.last}");
    }

    static (string first, string middle, string last) LookupName(string fio) // tuple return type
    {
        string[] parts = fio.Split('-', StringSplitOptions.RemoveEmptyEntries);

        return (parts[0], parts[1], parts[2]); // tuple literal
    }
}