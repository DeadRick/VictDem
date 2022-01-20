using System;

namespace Events_Ex2
{
    //public delegate void Action(); // событийный делегат

    public class Publisher
    { // класс-издатель
        public event Action SomethingHappened; // событие

        public void FireEvent()
        {
            Console.WriteLine("Fire SomethingHappened!!!");
            SomethingHappened?.Invoke(); // запуск события!!!
        }
    }

    // класс-подписчик на SomethingHappened
    public class SomethingHappenedSubscriber
    {
        public void SomethingHappenedHandler()
        {
            // код обработки события
            Console.WriteLine("Subscriber has handled an event!");
        }
    }

    public class SecondClass
    {
        public static void SomethingHappened()
        {
            Console.WriteLine("Wow! Smth happened!");
        }
    }

    class Program
    {
        static void Main()
        {
            // объект класса-источника
            Publisher pub = new Publisher();
            // объект класса-подписчика
            SomethingHappenedSubscriber shs =
                new SomethingHappenedSubscriber();
            SomethingHappenedSubscriber shs2 = new();
            pub.SomethingHappened += SecondClass.SomethingHappened;
            // добавляем подписчика к событию
            pub.SomethingHappened += shs.SomethingHappenedHandler;
            // вызвали метод, запускающий событие
            pub.FireEvent();
        }
    }

}
