using System.Runtime.CompilerServices;

namespace Net7._5___Verschiedenes
{
    public static class CallerArgumentExpressions
    {
        public static void Run()
        {
            Method2(1 + 2 + 3);
        }

        public static void Method(string text)
        {
            if (text is null)
            {
                throw new ArgumentNullException(nameof(text));
            }
        }

        public static void Method2(int result, [CallerArgumentExpression(nameof(result))] string paramExpression = null)
        {
            Console.WriteLine($"{paramExpression} = {result}");
        }
    }
}