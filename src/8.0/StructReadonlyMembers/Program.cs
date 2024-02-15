namespace StructReadonlyMembers;

readonly struct MyPoint
{
    public int X { get; }
    public int Y { get; }

    public MyPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public readonly double Area => X * Y;

    public readonly override string ToString()
    {
        return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}, {nameof(Area)}: {Area}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyPoint point = new MyPoint(5, 5);
        Console.WriteLine(point); 
    }
}