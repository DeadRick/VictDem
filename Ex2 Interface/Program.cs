using System;

namespace Ex2_Interface
{
    interface ITransformable
    {   // интерфейс преобразование
        void Transform(double coef);    // преобразовать 
    }
    class Circle : ITransformable
    {   // круг
        double rad = 1;     // радиус круга
        public void Transform(double coef) { rad *= coef; }
        public override string ToString()
        {
            return String.Format("Площадь круга: {0:G4}",
                              Math.PI * rad * rad);
        }
    }
    class Piramida : ITransformable
    {
        // Треугольник
        public double B { get; set; } = 10;
        public double H { get; set; } = 10;


        public void Transform(double coef)
        {
            B *= coef;
            H *= coef;
        }

        public override string ToString()
        {
            return $"Объём пирамиды: {B * B * 1.0/3.0 * H}" + Environment.NewLine + $"Площадь боковой поверхности - S";
        }
    }

    class Cube : ITransformable
    {   // куб
        double rib = 1;     // ребро куба
        public void Transform(double coef) { rib *= coef; }
        public override string ToString()
        {
            return String.Format("Объем куба: {0:G4}",
                             rib * rib * rib);
        }
    }

    class Cylinder : ITransformable
    {
        public double R { get; set; } = 10;
        public double H { get; set; } = 10;
        public void Transform(double coef)
        {
            R *= coef;
            H *= coef;
        }
        public override string ToString()
        {
            return $"{Math.PI * R * R * H}";
        }
    }

    class Function : ITransformable
    {
        public double K { get; set; } = 1;

        public void Transform(double coef)
        {
            K *= coef;
        }

        public override string ToString()
        {
            return $"{K}";
        }
    }

    class Program
    {
        public static void Report(ITransformable g)
        {
            Console.WriteLine("Данные объекта класса {0}:", g.GetType());
            Console.WriteLine(g);
        }
        public static ITransformable Mapping(ITransformable g, double d)
        {
            g.Transform(d);
            return g;
        }
        public static void Main()
        {
            ITransformable[] arr = { new Cube(), new Cylinder(), new Piramida(), new Circle(), new Function() };
            int k = int.Parse(Console.ReadLine());

            Array.ForEach(arr, x => {
                x.Transform(k);
                Report(x);
                });


        }


    }

}

