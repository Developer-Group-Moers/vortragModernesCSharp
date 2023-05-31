using System;

namespace NetFrameworkLib._3___NullableReferenceTypes
{
#nullable enable
    public static class Example
    {
        public static void Run()
        {
            var person = new Person
            {
                Name = "name"
            };

            Console.WriteLine(person.Name.Length);
            
            Method(new object[1]);

            string? maybeNull = new Random().Next(0, 1) > 0 ? "hallo" : null;
        }

        public static void Method(object?[] objs)
        {
            string? s = objs[0]?.ToString();
        }
        public static void Method(string name)
        {
            Console.WriteLine(name.Length);
        }
    }

    class Person
    {
        public required string Name { get; set; }
        public Address? Address { get; set; }
    }

    internal class Address
    {
        public string Street { get; set; }
    }
}