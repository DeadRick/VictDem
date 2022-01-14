using System;

namespace Delegate_MySelf3
{
    delegate double Sum(int n);
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum;
            Sum SumOne = delegate (int n)
            {
                double sum = 0;
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        sum += 1 / j;
                    }
                }
                return sum;
            };
            Sum SumTwo = delegate (int n)
            {
                double sum = 0;
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        sum += 1 / Math.Pow(2, j);
                    }
                }
                return sum;
            };
            do
            {
                Console.WriteLine("Введите корректное значение для первого суммирования!");
            } while (!int.TryParse(Console.ReadLine(), out firstNum));
            do
            {
                Console.WriteLine("Введите корректное значение для второго суммирования!");
            } while (!int.TryParse(Console.ReadLine(), out secondNum));
            Console.WriteLine(SumOne?.Invoke(firstNum));
            Console.WriteLine(SumTwo?.Invoke(secondNum));
        }
    }
}
