using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesX.Extensions;

public static class ObjectExtensions
{
    public static V Transform<T, V>(this T obj, Func<T, V> transformer)
    {
        return transformer(obj);
    }
    public static ICollection<T> Flatten<T>(this T obj, Func<T,ICollection<T>> childrenOf)
    {
        return new List<T>()
            .Expand(childrenOf(obj).ForEachCollect(o => o.Flatten(childrenOf)).Collect())
            .Expand(obj);
    }
    public static ICollection<V> FlattenTransform<T,V>(this T obj, Func<T, ICollection<T>> childrenOf, Func<T, V> transformer)
    {
        return new List<V>()
            .Expand(childrenOf(obj).ForEachCollect(o => o.FlattenTransform(childrenOf, transformer)).Collect())
            .Expand(transformer(obj));
    }
}
