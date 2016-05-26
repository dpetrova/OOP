using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQ_ExtensionMethods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var matches = new List<T>();
            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    matches.Add(element);
                }
            }
            return matches;
        }



        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> func)
                where TSelector : IComparable<TSelector> 
        {
            var max = default(TSelector);

            foreach (var element in collection)
            {
                var selector = func(element);
                if (selector.CompareTo(max) > 0)
                {
                    max = selector;
                }
            }
            return max;
        }


    }
}
