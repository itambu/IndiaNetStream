using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinqExample2
{
    public class WordGenerator : IEnumerable<NumberedWord>
    {
        private string _source;
        public WordGenerator(string source)
        {
            _source = source;
        }

        public IEnumerator<NumberedWord> GetEnumerator()
        {
            int current = 0;
            foreach(var str in _source.Split(' '))
            {
                yield return new NumberedWord() { Value = str, Position = current++ };
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
