using System;

namespace dz13
{
    static class ArrayHelper
    {
        public static T Pop<T>(ref T[] arr)
        {
            T lastArr = arr[arr.Length-1];
            Array.Resize(ref arr, arr.Length-1);
            return lastArr;
        }
        public static int Push<T>(ref T[] arr, T var)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1] = var;
            return arr.Length;
        }
    }
}