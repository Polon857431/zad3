using System;
using System.Collections.Generic;
using System.Linq;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static IEnumerable<IEnumerable<string>> OnlyBigCollections(List<IEnumerable<string>> toFilter)
        {
            Func<IEnumerable<string>, bool> predicate = 
                list => list.ElementAtOrDefault(5) != null;
            //  predicate = list => list.Count() >5 ;

            return toFilter.Where(predicate);
        }
    }
}
