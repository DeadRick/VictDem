using System;

namespace Delegate_MySelf2_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int[] arrA = new int[10];

            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = rnd.Next(1, 21);
            }

            double[] arrB;
            arrB = Array.ConvertAll<int, double>(arrA, item => 1.0/item);

            Console.WriteLine("Array A: ");
            foreach (var it in arrA)
            {
                Console.Write(it + " ");
            }

            Console.WriteLine("\nArray B (1/x): ");
            foreach (var it in arrB)
            {
                Console.Write(it.ToString("f2") + " ");
            }
        }
    }
}
