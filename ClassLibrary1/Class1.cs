using System;

namespace ClassLibrary1
{
    public delegate int MyDel(int first, int second);
    public static class Class1
    {
        public static int TestMethod(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            return second;
        }
    }
}
