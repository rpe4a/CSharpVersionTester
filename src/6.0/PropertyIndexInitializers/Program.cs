namespace StringInterpolation;

class Program
{
    static void Main(string[] args)
    {
        ToDo toDo = new ToDo("Work");
        Console.WriteLine(toDo);

        Dictionary<string, string> map = new Dictionary<string, string>()
        {
            ["map1"] = "one",
            ["map2"] = "two",
        };

        foreach (var element in map)
        {
            Console.WriteLine($"{element.Key}: {element.Value}");
        }
    }

    class ToDo
    {
        public DateTime Due { get; set; } = DateTime.Now.AddDays(1);
        public DateTime Created { get; } = DateTime.Now;
        public string Description { get; }

        public ToDo(string description)
        {
            this.Description = description; //Can assign (only in constructor!)
        }

        public override string ToString()
        {
            return $"{nameof(Due)}: {Due}, {nameof(Created)}: {Created}, {nameof(Description)}: {Description}";
        }
    }
}