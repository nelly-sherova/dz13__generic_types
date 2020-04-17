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
        public static T Shift<T>(ref T[] arr)
        {
            T first = arr[0];
            for (int i = 0;i <arr.Length-1; i++)
            {
                arr[i] = arr[i+1];
            }
            Array.Resize(ref arr, arr.Length-1);
            return first;
        }
        public static int UnShift<T>(ref T[] arr, T var)
        {
            T a, b, c=arr[arr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i==0)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    a = arr[i];
                    arr[i] = var;
                    for (int j=i+1; j<arr.Length-1; j=j+2)
                    {
                        b = arr[j];
                        arr[j]=a;
                        a=arr[j+1];
                        arr[j+1] = b;                  
                    }
                    arr[arr.Length-1]=c;
                }
            }
            return arr.Length;
        }
    }
}