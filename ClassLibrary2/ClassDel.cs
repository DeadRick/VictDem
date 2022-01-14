using System;

namespace ClassLibrary2
{
    public delegate int MyDel(double first, double second);
    public class ClassDel
    {
        public int TestMethod(double first, double second)
        {
            return (int)first + (int)second;
        }
    }
}
