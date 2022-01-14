using System;

namespace VictDem
{
    delegate int Cast(double x);
    class Program
    {
        static void Main(string[] args)
        {
            Cast first = delegate (double num)
            {
                int time = (int)num;
                int a = time % 2 == 0 ? time : time + 1;
                return a;
            };
            Cast second = delegate (double num)
            {
                return (int)num * 2;
            };

            Cast merge = first + second;
            Console.WriteLine(merge?.Invoke(5));
            merge -= second;
            Console.WriteLine(merge?.Invoke(5));

        }
    }
}
