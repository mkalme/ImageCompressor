using System;
using System.Collections.Generic;
using System.Linq;

namespace ImageCompressor {
    public static class ForEachUtilities {
        public static void SplitForEach<TSource>(IEnumerable<TSource> source, int buffer, Action<IEnumerable<TSource>> body) {
            int count = source.Count(), at = 0;

            while (at < count) {
                int thisBuffer = Math.Min(count - at, buffer);

                body(source.Skip(at).Take(thisBuffer));

                at += thisBuffer;
            }
        }
    }
}
