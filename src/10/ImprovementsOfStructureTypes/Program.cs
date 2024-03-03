namespace ImprovementsOfStructureTypes;

readonly struct MyPoint
{
    public int X { get; init; }
    public int Y { get; init; }

    public MyPoint()
    {
        X = 999;
        Y = 999;
    }

    public MyPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var point = new MyPoint();
        Console.WriteLine(point);

        var defaultPoint = default(MyPoint);
        Console.WriteLine(defaultPoint);

        defaultPoint = defaultPoint with {X = 1, Y = 1};
        Console.WriteLine(defaultPoint);
    }
}