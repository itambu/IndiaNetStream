using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample2
{
    public static class Extensions
    {
        public static IEnumerable<IndexItem> Index(this IEnumerable<NumberedWord> source)
        {
            return source
                .GroupBy(x => x.Value)
                .Select(g => g.First(x=>x.Position == g.Min(y=>y.Position)))
                .GroupBy(p => p.Value.ToUpper()[0])
                .Select(q => new IndexItem { StartChar = q.Key, Items = q  })
                .OrderBy(r => r.StartChar);
        }
    }
}
