using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesX
{
    public static class DebugExtensions
    {
        public static void Println(this string str)
        {
            Console.WriteLine(str);
        }
        public static void Println<T>(this T o,Func<T,string> str)
        {
            Console.WriteLine(str(o));
        }
        public static T PrintlnRt<T>(this T o, Func<T, string> str)
        {
            Console.WriteLine(str(o));
            return o;
        }

    }
}
