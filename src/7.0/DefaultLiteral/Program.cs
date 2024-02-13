namespace DefaultLiteral;

class Program
{
    static void Main(string[] args)
    {
        bool[] booleanArray = InitializeArray<bool>(10);
        int[] integerArray = InitializeArray<int>(10, 5);

        Console.WriteLine(string.Join(", ", booleanArray));
        Console.WriteLine(string.Join(", ", integerArray));
    }

    static T?[] InitializeArray<T>(int length, T? initialValue = default)
    {
        if (length < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(length), "Array length must be nonnegative.");
        }

        var array = new T?[length];
        for (var i = 0; i < length; i++)
        {
            array[i] = initialValue;
        }

        return array;
    }
}