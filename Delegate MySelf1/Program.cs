using System;
using ClassLibrary1;

namespace Delegate_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                MyDel MaxOfTwo = Class1.TestMethod;
                string[] pairNum = Console.ReadLine().Split();
                if (pairNum.Length == 2)
                {
                    int a = int.Parse(pairNum[0]);
                    int b = int.Parse(pairNum[1]);
                    Console.WriteLine(MaxOfTwo?.Invoke(a, b));
                }
                else
                {
                    throw new Exception("Введите пару чисел!");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
