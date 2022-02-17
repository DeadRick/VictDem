using System;
using System.Collections.Generic;
using System.IO;

namespace Ex1_2_Stream
{
    class ColorPoint
    {
        public static string[] colors = { "Red", "Green", "DarkRed", "Magenta", "DarkSeaGreen", "Lime", "Purple", "DarkGreen", "DarkOrange", "Black", "BlueViolet", "Crimson", "Gray", "Brown", "CadetBlue" };
        public double x, y;
        public string color;
        public override string ToString()
        {
            string format = "{0:F3}    {1:F3}    {2}";
            return string.Format(format, x, y, color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] arrPoint = File.ReadAllLines(@"..\..\..\..\MyTest.txt");
            List < ColorPoint > listOfPoints = new();

            for (int i = 0; i < arrPoint.Length; i++)
            {
                string[] temp = arrPoint[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                ColorPoint point = new();

                point.color = temp[2];
                point.x = double.Parse(temp[0]);
                point.y = double.Parse(temp[1]);

                listOfPoints.Add(point);
            }

            foreach (var item in listOfPoints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
