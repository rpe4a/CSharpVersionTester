namespace RecordStructs;

record struct MyPoint(int X, int Y);

readonly record struct MyPoint2(int X, int Y);

class Program
{
    static void Main(string[] args)
    {
        var myPoint1 = new MyPoint(1, 1);
        var myPoint2 = new MyPoint(1, 1);
        Console.WriteLine(myPoint1 == myPoint2);
        var myPoint3 = new MyPoint2(2, 1);
        var myPoint4 = new MyPoint2(2, 2);
        Console.WriteLine(myPoint4 == myPoint3);
        Console.WriteLine(myPoint1);
        Console.WriteLine(myPoint2);
    }
}