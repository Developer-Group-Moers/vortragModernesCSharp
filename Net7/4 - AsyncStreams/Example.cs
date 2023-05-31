namespace Net7._4___AsyncStreams
{
    public static class Example
    {
        public static void Run()
        {
            _ = ConsumeNumbersAsync();
            Console.ReadKey();
        }

        public static async Task<T>  FirstOrDefaultAsync<T>(this IAsyncEnumerable<T> ts)
        {
            var asyncEnumerator = ts.GetAsyncEnumerator();
            if (await asyncEnumerator.MoveNextAsync())
            {
                return asyncEnumerator.Current;
            }

            return default;
        }

        public static async Task ConsumeNumbersAsync()
        {
            IAsyncEnumerable<int> asyncEnumerable = GetNumbersAsync();

            asyncEnumerable.FirstOrDefaultAsync();
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
                yield return i;
            }
        }
    }
}