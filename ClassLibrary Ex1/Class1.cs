using System;

namespace ClassLibrary_Ex1
{
    public delegate string ConvertRule(string line);
    public class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            var x = cr.GetInvocationList();
            Delegate[] listDel = cr.GetInvocationList();
            string finStr = str;
            foreach (ConvertRule del in listDel)
            {
                finStr = del.Invoke(finStr);
            }
            return finStr;
        }

        public static string RemoveDigits(string str)
        {
            string finStr = "";
            int n;
            foreach (var el in str)
            {
                if (!int.TryParse(el.ToString(), out n))
                {
                    finStr += el;
                }
            }
            return finStr;
        }
        public static string RemoveSpaces(string str)
        {
            string finStr = "";
            foreach (var el in str)
            {
                if (el.ToString() != " ")
                {
                    finStr += el;
                }
            }
            return finStr;
        }
    }
}
