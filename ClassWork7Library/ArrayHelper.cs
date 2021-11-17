using System;

namespace ClassWork7Library
{
    public class ArrayHelper
    {
        public static int Min(int[] array)
        {
            return array[MinI(array)];
        }

        public static int Max(int[] array)
        {
            return array[MaxI(array)];
        }

        public static int MinI(int[] array)
        {
            int minI = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minI])
                {
                    minI = i;
                }
            }

            return minI;
        }

        public static int MaxI(int[] array)
        {
            int maxI = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxI])
                {
                    maxI = i;
                }
            }

            return maxI;
        }

        public static int SumElementsWithOddIndexes(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static void Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - 1 - i]);
            }
        }

        public static int OddElementsCount(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 1)
                {
                    ++count;
                }
            }

            return count;
        }

        public static void HalfReverse(int[] array)
        {
            int startPosition = array.Length / 2 + array.Length % 2;
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[startPosition + i]);
            }
        }

        public static void Sort(int[] array, bool ascending = true)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if((array[i] > array[j]) == ascending)
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        public static bool ContainsDigits(string str)
        {
            bool result = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
