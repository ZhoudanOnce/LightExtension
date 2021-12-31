using System;
using System.Collections.Generic;
using System.Linq;

namespace LightExtension
{
    public static class LightLinq
    {
        public static bool AllAnd(this IEnumerable<bool> source)
        {
            return !source.Contains(false);
        }

        public static bool AllOr(this IEnumerable<bool> source)
        {
            return source.Contains(true);
        }

        public static IEnumerable<int> Touch(int from, int to)
        {
            var contrast = from < to;
            var result = Enumerable.Range(contrast ? from : to, Math.Abs(to - from) + 1);
            return contrast ? result : result.Reverse();
        }
    }
}