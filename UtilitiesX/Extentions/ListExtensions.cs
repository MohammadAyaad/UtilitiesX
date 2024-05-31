using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesX.Extentions
{
    public static class ListExtensions
    {
        public static List<T> Collect<T>(this List<List<T>> l)
        {
            List<T> result = new List<T>();
            foreach (var t in l)
            {
                result.AddRange(t);
            }
            return result;
        }
    }
}
