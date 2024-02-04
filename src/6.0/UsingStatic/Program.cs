namespace UsingStatic;

using static Math;

public static class Program
{
    static void Main(string[] args)
    {
        Tuple<double, double> angle = SolarAngleNew(90d, 90d, 90d);
        Console.WriteLine($"angle: {angle.Item1}, {angle.Item2}");
    }

    private static Tuple<double, double> SolarAngleNew(double latitude, double declination, double hourAngle)
    {
        var tmp = Asin(latitude) * Sin(declination) + Cos(latitude) * Cos(declination) * Cos(hourAngle);
        return Tuple.Create(Asin(tmp), Acos(tmp));
    }
}