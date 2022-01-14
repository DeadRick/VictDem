using System;
using ClassLibrary_Ex1;

namespace Delegate_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            Converter lib = new();
            ConvertRule ruleOne = Converter.RemoveDigits;
            ConvertRule ruleTwo = Converter.RemoveSpaces;
            ConvertRule ruleMain = ruleOne + ruleTwo;
            string test1 = "w1h2a3t?";
            string test2 = "w h a a a t";
            string test3 = "w1 h2 3 a a 3t4!";
            Console.WriteLine(lib.Convert(test1, ruleOne));
            Console.WriteLine(lib.Convert(test1, ruleTwo));
            Console.WriteLine(lib.Convert(test1, ruleMain));
            Console.WriteLine("--------------------");
            Console.WriteLine(lib.Convert(test2, ruleOne));
            Console.WriteLine(lib.Convert(test2, ruleTwo));
            Console.WriteLine(lib.Convert(test1, ruleMain));
            Console.WriteLine("--------------------");
            Console.WriteLine(lib.Convert(test3, ruleOne));
            Console.WriteLine(lib.Convert(test3, ruleTwo));
            Console.WriteLine(lib.Convert(test1, ruleMain));
            Console.WriteLine("--------------------");
            Console.WriteLine(lib.Convert("1 2 3 4 5 ab c", ruleMain));

        }
    }
}
