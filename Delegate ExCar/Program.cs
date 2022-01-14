using System;
using Cars;

namespace Delegate_ExCar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Использование делегатов для управления событиями *****\n");

            Car c1 = new Car("SlugBug", 100, 10);

            // Передаём в машину метод, который будет вызван при отправке оповещения.
            c1.RegisterWithCarEngine(new Cars.CarEngineHandler(OnCarEngineEvent));
            // Разгоняем машину
            Console.WriteLine("***** Увеличиваем скорость *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }
        // Это метод-обработчик оповещений от машины.
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Сообщение от объекта типа Car *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }

    }
}
