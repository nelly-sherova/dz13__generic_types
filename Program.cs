using System;

namespace dz13
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr1 = {"Кошка","Собака","Зебра","Крокодил","Лев"};
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nВаш массив: ");
            for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
            Console.WriteLine("\nВаш массив после использования метода Pop: ");
            Console.WriteLine($"Удалили: {ArrayHelper.Pop(ref arr1)}");
            Console.Write("Осталось: ");
            for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");

        }
    }
}
