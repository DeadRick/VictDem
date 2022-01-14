using System;
using ClassLibrary2;

namespace Delegate_MySelf2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ClassDel testDel = new();
                MyDel SumDouble = testDel.TestMethod;
                string[] pairNum = Console.ReadLine().Split();
                if (pairNum.Length == 2)
                {
                    double a = double.Parse(pairNum[0]);
                    double b = double.Parse(pairNum[1]);
                    Console.WriteLine(SumDouble?.Invoke(a, b));
                    MyDel del = SumDouble.GetInvocationList()[0] as MyDel;
                    Console.WriteLine(del?.Invoke(a, b));
                }
                else
                {
                    throw new IndexOutOfRangeException("Введите пару чисел!");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
