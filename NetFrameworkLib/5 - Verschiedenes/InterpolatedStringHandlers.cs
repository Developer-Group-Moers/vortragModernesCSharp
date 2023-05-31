using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NetFrameworkLib._5___Verschiedenes
{
    public static class InterpolatedStringHandlers
    {
        public static void Run()
        {
            FormattedString myText = $"hallo {13}";
        }
    }
    
    [InterpolatedStringHandler]
    public readonly ref struct FormattedString
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

namespace System.Runtime.CompilerServices
{
    /// <summary>Indicates the attributed type is to be used as an interpolated string handler.</summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
    public sealed class InterpolatedStringHandlerAttribute : Attribute
    {
    }
}
