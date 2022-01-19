using System;

namespace Delegate_MySelf1_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-15, 16);
            }

            Console.WriteLine("Unsorted array: ");

            foreach (var it in arr)
            {
                Console.Write(it + " ");
            }

            Array.Sort(arr, (x, y) => x.CompareTo(y));

            Console.WriteLine("\nSotred array with lambda expression: ");

            foreach (var it in arr)
            {
                Console.Write(it + " ");
            }
        }
    }
}
