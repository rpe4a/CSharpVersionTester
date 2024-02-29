namespace RecordTypes;

record MySimpleRecord1(string Name, int Age);

record MySimpleRecord2()
{
    private string Name { get; init; }
    private int Age { get; init; }
}

class Program
{
    static void Main(string[] args)
    {
        MySimpleRecord1 record1 = new MySimpleRecord1("petr", 11);
        MySimpleRecord1 record2 = new MySimpleRecord1("petr", 11);

        Console.WriteLine(record1 == record2);
        Console.WriteLine(record1);

        (string name, int age) = record1;
        Console.WriteLine("{0}:{1}", name, age);

        record1 = record1 with {Name = "vasya"};
        Console.WriteLine(record1);
    }
}