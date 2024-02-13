namespace Deconstruction;

class Point
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; }
    public int Y { get; }

    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        (string first, string middle, string last) = LookupName("Ivanov-Ivan-Ivanuch");
        Console.WriteLine($"first: {first}, middle: {middle}, last: {last}");

        Point point = new Point(1, 1);
        (int x, int y) = point;
        Console.WriteLine($"Point(x: {x}, y: {y})");
    }

    static (string first, string middle, string last) LookupName(string fio) // tuple return type
    {
        string[] parts = fio.Split('-', StringSplitOptions.RemoveEmptyEntries);

        return (parts[0], parts[1], parts[2]); // tuple literal
    }
}