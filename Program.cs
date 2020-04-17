using System;

namespace dz13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool working = true;
            // arr с int:
            //int[] arr = {1,2,3,4,5,6,7,8};
            // arr c double 
            //double[] arr = {1.3,2,3,4.5,5,6.7,7,8.0006};
            // arr c float
            //float[] arr = {1f,2f,3f,4.007f,5f,6f,7.009f,8f};
            // arr c decimal
            //decimal[] arr = {1m,2.01m,3.03m,4.4m,5m,6m,7.7m,8.08m};
            // arr c string
            string[] arr = {"Кошка","Собака","Зебра","Крокодил","Лев"};
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your array: "); for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}  ");
            int Command;
            Console.ForegroundColor = ConsoleColor.White;
            while (working == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please choose function: \n1. Pop(array) \n2. Push(array, element)\n3. Shift(array)\n4. UnShift(array, element)\n5. Slice(array, beginIndex, end Index) \n6. Exit");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Command = ");Command = Convert.ToInt32(Console.ReadLine());
                switch(Command)
                {
                    case 1: 
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Popped {ArrayHelper.Pop(ref arr)}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your array: "); for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}  ");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Element: ");
                        // int element = Convert.ToInt32(Console.ReadLine());
                        // double element = Convert.ToDouble(Console.ReadLine());
                        // decimal element = Convert.ToDecimal(Console.ReadLine());
                        // float element = Convert.ToFloat(Console.ReadLine());
                        string element = Console.ReadLine();
                        Console.WriteLine($"Size of Array: {ArrayHelper.Push(ref arr, element)}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your array: "); for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}  ");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Shifted element: {ArrayHelper.Shift(ref arr)}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your array: "); for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}  ");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Element: ");
                        // element1 = Convert.ToInt32(Console.ReadLine());
                        // double element1 = Convert.ToDouble(Console.ReadLine());
                        // decimal element1 = Convert.ToDecimal(Console.ReadLine());
                        // float element1 = Convert.ToFloat(Console.ReadLine());
                        string element1 = Console.ReadLine(); 
                        Console.WriteLine("Size of Array: " + ArrayHelper.UnShift(ref arr, element1));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your array: "); for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}  ");
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Begin Index: ");
                        int begin_index = Convert.ToInt32(Console.ReadLine());
                        Console.Write("End Index: ");
                        int end_index = Convert.ToInt32(Console.ReadLine());
                        //int[] Array = ArrayHelper.Slice(arr, begin_index, end_index);
                        //double[] Array = ArrayHelper.Slice(arr, begin_index, end_index);
                        //decimal[] Array = ArrayHelper.Slice(arr, begin_index, end_index);
                        //float[] Array = ArrayHelper.Slice(arr, begin_index, end_index);
                        string[] Array = ArrayHelper.Slice(arr, begin_index, end_index);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Sliced array: ");
                        foreach( var item in Array )
                        {
                            Console.Write(item + " ");
                        }
                        break;
                    case 6:
                        working = false;
                        break;
                    default: 
                        Console.WriteLine("You entered the wrong command!");
                        working = false;
                        break;
                }
                
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Ссылка на Array Helper static class ----> https://github.com/nelly-sherova/dz9-static-class-ArrayHelper");
            Console.ForegroundColor = ConsoleColor.White;
        }            
           
    }
}
