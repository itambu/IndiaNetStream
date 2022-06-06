using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExample2
{
    public class IndexItem
    {
        public Char StartChar { get; set; }
        public IEnumerable<NumberedWord> Items { get; set; }
    }
}
