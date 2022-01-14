using System;

namespace Cars
{
    public delegate void CarEngineHandler(string msgForCaller);
    
    public class Car
    {
        // Информация о внутреннем состоянии
        private CarEngineHandler listOfHandlers;
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        // Машина работоспособна?
        private bool carIsDead;
        // Конструкторы
        public Car() { MaxSpeed = 100; }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }
        public void RegisterWithCarEngine(CarEngineHandler methodToCall) { listOfHandlers = methodToCall; }
        public void Accelerate(int delta)
        {
            // Если машина сломана, отправляем оповещение.
            if (carIsDead)
            {
                listOfHandlers?.Invoke("К сожалению, машина сломана :( ...");
                return;
            }

            CurrentSpeed += delta;

            // Машина почти сломана?
            if (MaxSpeed > CurrentSpeed && (MaxSpeed - CurrentSpeed) <= 10)
                listOfHandlers?.Invoke("Предупреждение! Будь осторожнее");

            // Машина сломана?
            if (CurrentSpeed >= MaxSpeed)
                carIsDead = true;
            else
                Console.WriteLine("Скорость = {0}", CurrentSpeed);
        }

    }

}
