using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static T FirstOrDefault<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            var firstOrDefault = default(T);
            foreach (var element in collection)
            {
                if (condition(element))
                {
                    firstOrDefault = element;
                    break;
                }
            }
            return firstOrDefault;
        }



        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            var matches = new List<T>();
            foreach (var element in collection)
            {
                if (condition(element))
                {
                    matches.Add(element);
                }
                else
                {
                    break;
                }
            }
            return matches;
        }



        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var element in collection)
            {
                action(element);
            }
        }

    }
}
