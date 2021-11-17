using ClassWork7Library;
using System;
using System.IO;

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

        static void SortArray()
        {
            string path = @"C:\Users\Sviatoslav_Samoilenk\Desktop\testForInput.txt";
            int count = 0;
            using (StreamReader streamReader = new StreamReader(path))
            {
                while (!streamReader.EndOfStream)
                {
                    streamReader.ReadLine();
                    ++count;
                }
            }
            int[] array = new int[count];
            using (StreamReader streamReader = new StreamReader(path))
            {
                int i = 0;
                while (!streamReader.EndOfStream)
                {
                    array[i++] = Convert.ToInt32(streamReader.ReadLine());
                }
            }

            ArrayHelper.Sort(array);

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    streamWriter.WriteLine(array[i]);
                }
            }
        }

        static void WriteWordsWithoutDigits()
        {
            string path = @"C:\Users\Sviatoslav_Samoilenk\Desktop\testForInput.txt";
            using (StreamReader streamReader = new StreamReader(path))
            {
                while (!streamReader.EndOfStream)
                {
                    string input = streamReader.ReadLine();
                    string[] splitted = input.Split(' ');
                    using (StreamWriter streamWriter =
                                 new StreamWriter("result.txt", true))
                    {
                        bool shouldWriteLine = false;
                        for (int i = 0; i < splitted.Length; i++)
                        {
                            if (!ArrayHelper.ContainsDigits(splitted[i]))
                            {
                                streamWriter.Write($"{splitted[i]} ");
                                shouldWriteLine = true;
                            }
                        }

                        if (shouldWriteLine)
                        {
                            streamWriter.WriteLine();
                        }
                    }
                }
            }
        }

        static void SumNumbersInFile()
        {
            string path = @"C:\Users\Sviatoslav_Samoilenk\Desktop\testForInput.txt";
            int count = 0;
            using (StreamReader streamReader = new StreamReader(path))
            {
                while (!streamReader.EndOfStream)
                {
                    streamReader.ReadLine();
                    ++count;
                }
            }

            int sum = 0;
            using (StreamReader streamReader = new StreamReader(path))
            {
                for (int i = 0; i < count; i++)
                {
                    sum += Convert.ToInt32(streamReader.ReadLine());
                }
            }

            Console.WriteLine(sum);
        }

        static void ReverseTwoDimensionalArray()
        {
            int[,] array = new int[3, 4];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 20);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int count = array.Length / 2;
            for (int i = 0; i < array.GetLength(0) && count != 0; i++)
            {
                for (int j = 0; j < array.GetLength(1) && count != 0; j++)
                {
                    int iSwap = array.GetLength(0) - 1 - i;
                    int jSwap = array.GetLength(1) - 1 - j;
                    ArrayHelper.Swap(
                        ref array[i, j],
                        ref array[iSwap, jSwap]);
                    --count;
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
