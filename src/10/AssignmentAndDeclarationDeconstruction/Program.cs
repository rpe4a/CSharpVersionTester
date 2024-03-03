namespace AssignmentAndDeclarationDeconstruction;

readonly record struct MyPoint(int x, int y);

class Program
{
    static void Main(string[] args)
    {
        var point = new MyPoint(5, 5);
        // Initialization:
        (int x, int y) = point;

        // assignment:
        int x1 = 0;
        int y1 = 0;
        (x1, y1) = point;
        
        // NOW
        int x2 = 0;
        (x2, int y2) = point;

        Console.WriteLine($"Point2: x:'{x2}', y:'{y2}'.");
    }
}