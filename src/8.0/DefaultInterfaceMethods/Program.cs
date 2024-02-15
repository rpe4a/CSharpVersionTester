namespace DefaultInterfaceMethods;

interface IDefaultMethods
{
    void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    void WriteLine2(string message);
}

class MyClass: IDefaultMethods
{

    public void WriteLine2(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IDefaultMethods myClass = new MyClass();
        myClass.WriteLine("default method");
        myClass.WriteLine2("own method");
    }
}