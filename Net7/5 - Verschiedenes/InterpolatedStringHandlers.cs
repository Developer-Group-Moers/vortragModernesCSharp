using System.Runtime.CompilerServices;

namespace Net7._5___Verschiedenes
{
    public static class InterpolatedStringHandlers
    {
        public static void Run()
        {
            FormattedString s = $"hallo {13}";
        }
    }

    [InterpolatedStringHandler]
    public class FormattedString
    {
        private readonly int _literalLength;
        private readonly int _formattedCount;
        private readonly List<object> objects = new();
        public FormattedString(int literalLength, int formattedCount)
        {
            _literalLength = literalLength;
            _formattedCount = formattedCount;
        }

        public void AppendLiteral(string literal)
        {
            objects.Add(literal);
        }

        public void AppendFormatted<T>(T t)
        {  
            objects.Add(t);
        }
    }
}