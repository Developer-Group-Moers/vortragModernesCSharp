using System.Collections.Immutable;
using Net7._1___Records;

namespace Net7._2___Pattern_Matching
{
    public static class Example
    {
        public static void Run()
        {
            Range range = 1..2;
            
            string name = Random.Shared.NextInt64(0, 3) switch
            {
                0 => "null",
                1 => "eins",
                >= 2 => "groß",
                _ => "default"
            };
        }

        public static ImmutableArray<int> QuickSort(ImmutableArray<int> numbers) => numbers switch
        {
            [] => numbers,
            [_] => numbers,
            [var head, ..var tail] => QuickSort(tail.Where(x => x < head)).Add(head).AddRange(QuickSort(tail.Where(x => x >= head)))
        };

        public static void Method3(IReadOnlyCollection<int> numbers)
        {
            if (numbers is not { Count: > 0 })
            {
                return;
            }

            // eigentliche Berechnung
        }

        static void Method2(int i)
        {
            if (i is > 3 and < 5 or < 0 or 42)
            {
            }
        }

        static void Method(object obj)
        {
            if (obj is Point2d { X: 0, Y: 0 } nullPoint)
            {
            }

            if (obj is Person { Age: > 30, Address: "Karlsruhe" } erwachsenerAusKarslsruhe)
            {
            }
        }
    }
}