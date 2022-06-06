using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LinqExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generator = new WordGenerator("Contains interfaces and classes that define generic collections which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections");

            foreach (var item in generator)
            {
                Console.WriteLine($"{item.Value} {item.Position}");
            }

            var query = from item in generator
                        group item by item.Value
                        into g
                        select new { Key = g.Key, Position = g.Min(x => x.Position) }
                        into p
                        group p by p.Key.ToUpper()[0]
                        into q
                        select new { StartChar = q.Key, Items = q }
                        into r
                        orderby r.StartChar ascending
                        select r;

            //var query1 = generator
            //    .GroupBy(x => x.Value)
            //    .Select(g => new { Key = g.Key, Position = g.Min(x => x.Position) })
            //    .GroupBy(p => p.Key.ToUpper()[0])
            //    .Select(q => new { StartChar = q.Key, Items = q })
            //    .OrderBy(r => r.StartChar);



            Console.WriteLine("--------------------------------");

            foreach (var charGroup in generator.Index())
            {
                Console.WriteLine($"{charGroup.StartChar}");
                foreach(var item in charGroup.Items)
                {
                    Console.Write($"{item.Value} {item.Position},");
                }
                Console.WriteLine();
            }


            //----------------------------------------------------------
            Expression<Func<int, int, bool>> expression1 = (a, b) => a > b;

            var d = expression1.Compile();
            var result = d?.Invoke(1, 3);

        }
    }
}
