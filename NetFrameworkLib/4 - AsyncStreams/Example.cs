using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFrameworkLib._4___AsyncStreams
{
    public static class Example
    {
        public static void Run()
        {
            ConsumeNumbersAsync();
            Console.ReadKey();
        }
        
        public static async Task ConsumeNumbersAsync()
        {
            IAsyncEnumerable<int> asyncEnumerable = GetNumbersAsync();

            await foreach (int nextNumber in asyncEnumerable)
            {
                if (nextNumber == 100)
                {
                    break;
                }
                
                Console.WriteLine(nextNumber);
            }
        }

        public static async IAsyncEnumerable<int> GetNumbersAsync()
        {
            int i = 0;
            while (true)
            {
                await Task.Delay(1000);
                yield return i++;
            }
        }
    }
}