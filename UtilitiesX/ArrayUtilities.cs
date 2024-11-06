using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesX
{
    public static class ArrayUtilities
    {
        public static T[] GenerateArray<T>(Func<int, T> generator, int count)
        {
            T[] arr = new T[count];
            for (int i = 0; i < count; i++)
                arr[i] = generator(i);
            return arr;
        }
    }
}
