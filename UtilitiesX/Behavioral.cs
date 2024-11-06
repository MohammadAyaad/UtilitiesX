using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesX
{
    public static class Behavioral
    {
        public static T Branch<T>(this T obj,Func<T,bool> condition,Func<T,T> statements)
        {
            if (condition(obj))
                return statements(obj);
            else
                return obj;
        }
    }
}
