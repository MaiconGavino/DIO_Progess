using System;
using System.Linq;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1, 5, 6, 7, 3, 5, 4, 7, 9, 2};
            for (int i = 0; i < Sort(arr).Length; i++)
            {
                Console.Write(Sort(arr)[i]);
            }
        }

        public static int[] Sort(int[] array)
        {
            int tam = array.Length;
            int first = array[0];
            for (int i = 0; i < tam; i++)
            {
                for (int j = i + 1; j < tam; j++)
                {
                    if (array[i] > array[j])
                    {
                        first = array[i];
                        array[i] = array[j];
                        array[j] = first;
                    }
                }
            }

            return array;
        }

    }
}