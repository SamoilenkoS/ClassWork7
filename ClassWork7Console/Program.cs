using ClassWork7Library;
using System;

namespace ClassWork7Console
{
    class Program
    {
        static int[] GenerateArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] array = GenerateArray(6);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            ArrayHelper.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            //Console.WriteLine(ArrayHelper.OddElementsCount(array));
        }
    }
}
