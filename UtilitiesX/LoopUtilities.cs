namespace UtilitiesX
{
    public static class LoopUtilities
    {
        public static List<T> ForCollect<T>(int start, Func<int, bool> condition, Func<int, int> step, Func<int, T> loopBody)
        {
            List<T> l = new List<T>();
            for (int i = start; condition(i); i = step(i))
                l.Add(loopBody(i));
            return l;
        }
        public static List<T> ForEachProcess<T>(this List<T> l,Func<int,T,T> process)
        {
            for (int i = 0; i < l.Count(); i++)
                l[i] = process(i,l.ElementAt(i));
            return l;
        }
        public static List<V> ForEachCollect<T,V>(this IEnumerable<T> l,Func<T,V> getResult)
        {
            List<V> result = new List<V>();
            foreach(T item in l)
                result.Add(getResult(item));
            return result;
        }
    }
}
