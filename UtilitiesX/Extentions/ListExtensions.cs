﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesX.Extentions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<U> Transform<T, U>(this IEnumerable<T> source, Func<T, U> transformer)
        {
            foreach (var item in source)
            {
                yield return transformer(item);
            }
        }

        public static T Collect<T, V>(this IEnumerable<V> l, T collection, Func<V, T,T> Collector)
        {
            for (int i = 0; i < l.Count(); i++)
                collection = Collector(l.ElementAt(i), collection);
            return collection;
        }
    }
    public static class ICollectionExtensions
    {
        public static ICollection<T> Collect<T>(this ICollection<ICollection<T>> l)
        {
            ICollection<T> result = default;
            foreach (var c in l)
            {
                foreach(var i in c)
                    result.Add(i);
            }
            return result;
        }
        public static ICollection<T> Expand<T>(this List<T> l,T item)
        {
            l.Add(item);
            return l;
        }
        public static ICollection<T> Expand<T>(this ICollection<T> l, IEnumerable<T> items)
        {
            foreach(var i in items)
                l.Add(i);
            return l;
        }
    }
}
