using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesX
{
    public static class Behavioral
    {
        public static T Branch<T>(
            this T obj,
            Func<T, bool> condition,
            Func<T, T> onTrue = null,
            Func<T, T> onFalse = null
        )
        {
            if (condition(obj))
                return onTrue != null ? onTrue(obj) : obj;
            else
                return onFalse != null ? onFalse(obj) : obj;
        }

        public static R? Branch<T, R>(
            this T obj,
            Func<T, bool> condition,
            Func<T, R> onTrue = null,
            Func<T, R> onFalse = null
        )
        {
            if (condition(obj))
                return onTrue != null ? onTrue(obj) : default;
            else
                return onFalse != null ? onFalse(obj) : default;
        }
    }
}
