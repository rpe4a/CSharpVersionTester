namespace InitOnlySetters;

class MyClass
{
    private readonly string name;

    public string Name
    {
        get => name;
        init => name = value;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
    }

    public int Age { get; init; }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass
        {
            Name = "name",
            Age = 12
        };
        
        Console.WriteLine(obj);
    }
}