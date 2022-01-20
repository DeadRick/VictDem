using System;

delegate void Action(); // событийный делегат

class Program
{
    static event Action Ev; // событие

    // набор обработчиков
    static Action F1 = delegate { Console.WriteLine("F1"); };

    static void F2() { Console.WriteLine("F2"); }
    static void F3() { Console.WriteLine("F3"); }

    static void Main()
    {
        Ev += F1; // добавление обработчика
        Ev += delegate { Console.WriteLine("F1"); }; // добавление обработчика
        Ev += F3; // добавление обработчика
        Ev -= F1;
        Ev -= F3;
        Ev();     // запуск события!
    }
}
