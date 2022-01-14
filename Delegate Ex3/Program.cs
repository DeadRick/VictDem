using System;

namespace Delegate_Ex3
{
    class TemperatureConberter
    {
        public double FromCelToFar(double cel)
        {
            double far = 9 / 5 * cel + 32;
            return far;
        }
        public double FromFarToCel(double far)
        {
            Console.WriteLine(far);
            double cel = 5.0 / 9.0 * (far - 32);
            return cel;
        }
    }
    delegate double DelegateConvertTemperature(double x);
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConberter Temp = new();
            DelegateConvertTemperature CelToFar = Temp.FromCelToFar;
            DelegateConvertTemperature FarToCel = Temp.FromFarToCel;
            DelegateConvertTemperature MainTemp = CelToFar + FarToCel;
            DelegateConvertTemperature[] arr = (DelegateConvertTemperature[])MainTemp.GetInvocationList();
            Console.WriteLine(CelToFar(100));
            Console.WriteLine(FarToCel(50));
        }
    }
}
