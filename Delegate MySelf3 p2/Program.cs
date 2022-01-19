using System;

namespace Delegate_MySelf3_p2
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<double, int> mySort = delegate (double x)
            {
                if (x > 0)
                {
                    return (int)x;
                }
                return 0;
            };
            Random rnd = new();
            double[] arrA = new double[10];
            int[] arrB = new int[10];
            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = rnd.NextDouble() * 6 - 3;
            }

            foreach (var item in arrA)
            {
                Console.Write(item.ToString("f2") + "\t");
            }

            Console.WriteLine();

            arrB = Array.ConvertAll<double, int>(arrA, x => mySort(x));

            foreach (var item in arrB)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
