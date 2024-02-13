namespace RefReturnsAndLocals;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {1, 15, -39, 0, 7, 14, -12};
        Console.WriteLine(string.Join(',', array));

        ref int place = ref Find(7, array); // aliases 7's place in the array
        place = 10;
        
        Console.WriteLine(string.Join(',', array));

        ref int place10 = ref array[4];

        Console.WriteLine(place == place10);
    }

    private static ref int Find(int number, int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == number)
            {
                return ref numbers[i]; // return the storage location, not the value
            }
        }

        throw new IndexOutOfRangeException($"{nameof(number)} not found");
    }
}