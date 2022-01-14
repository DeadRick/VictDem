using System;

namespace Delegates_Ex2
{
    class NewClass
    {
        public static int[] First(int splitting)
        {
            int temp = 0;
            string spl = splitting.ToString();
            int[] numbers = new int[spl.Length];
            foreach (var el in spl)
            {
                int fNum = int.Parse(el.ToString());
                numbers[temp++] = fNum;
            }
            Console.WriteLine();
            return numbers;
        }

        public static void SecondPrint(int[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
        }
    }
    delegate int[] Row(int num);
    delegate void Print(int[] arr);
    class Program
    {
        static void Main(string[] args)
        {
            int one = 12345;
            int[] arr = { 12, 23, 33, 34, 43, 56, 78, 98, 66, 65 };
            Row ThrowNums = new Row(NewClass.First);
            Print PrInfo = NewClass.SecondPrint;
            int[] wow = ThrowNums(one);
            PrInfo(wow);
            Console.WriteLine();
            Console.WriteLine("-------------");
            PrInfo(arr);
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine(ThrowNums.Method);
            Console.WriteLine(ThrowNums.Target);
            Console.WriteLine("-------------");
            Console.WriteLine(PrInfo.Method);
            Console.WriteLine(PrInfo.Target);


        }
    }
}
