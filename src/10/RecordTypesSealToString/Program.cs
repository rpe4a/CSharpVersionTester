namespace RecordTypesSealToString;

record MyFirstRecord(string FirstValue, int SecondValue)
{
    public sealed override string ToString()
    {
        return $"{nameof(FirstValue)}: {FirstValue}, {nameof(SecondValue)}: {SecondValue}";
    }

}

record MySecondRecord(string FirstValue, int SecondValue, bool ThirdValue) : MyFirstRecord(FirstValue, SecondValue);

class Program
{
    static void Main(string[] args)
    {
        var first = new MyFirstRecord("value", 1);
        var second = new MySecondRecord("value", 1, true);
        MyFirstRecord third = second with {};
        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(first == second);
        Console.WriteLine(first == third);
    }
}