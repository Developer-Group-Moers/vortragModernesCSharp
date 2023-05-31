using System.Collections.Immutable;

namespace Net7._2___Pattern_Matching
{
    static class ImmutableArrayExtensions
    {
        public static ImmutableArray<T> Where<T>(this ImmutableArray<T> arr, Func<T, bool> predicate) =>
            Enumerable.Where(arr, predicate).ToImmutableArray();
    }
}