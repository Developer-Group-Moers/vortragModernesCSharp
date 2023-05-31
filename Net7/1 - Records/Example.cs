namespace Net7._1___Records
{
    public static class Example
    {
        public static void Run()
        {
            Person timo = new Person("timo", 32)
            {
                Address = "karlsruhe"
            };

            Console.WriteLine(timo);

            Person nichtTimo = timo with { Name = "Nicht Timo"};
            
            
        }
    }

    readonly record struct Point2d(int X, int Y);
    
    record Person(string Name, int Age)
    {
        public required string Address { get; init; }
    }
}