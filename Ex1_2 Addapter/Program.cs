// Проект 2. Чтение целых из двоичного потока. 
// ЧИТАТЬ И ЗАПИСЫВАТЬ СТРОГО ПО ОДНОМУ ЧИСЛУ!!! 
using System;
using System.IO;
class Program
{
    static void Main()
    {
        FileStream f = new FileStream("../../../../t.dat", FileMode.Open);
        BinaryReader fIn = new BinaryReader(f);
        long n = f.Length / 4; int a;
        for (int i = 0; i < n; i++)
        {
            a = fIn.ReadInt32();
            Console.Write(a + " ");
        }
        Console.WriteLine("\n1) Числа в обратном порядке:");
        
        for (long i = 1; i < f.Length; i++)
        {
            f.Seek(-i, SeekOrigin.End);
            Int32 ab = (Int32)f.ReadByte();
            if (ab != 0) {
                Console.Write(ab + " ");
            }
        }
        f.Close();
        fIn.Close();
        Console.WriteLine("\n2) Увеличить  все числа в файле в 5 раз");
        BinaryWriter fOut = new BinaryWriter(
            new FileStream("../../../../t.dat", FileMode.Create));
        for (int i = 0; i <= 10; i += 2)
            fOut.Write(i*5);
        fOut.Close();

        f = new FileStream("../../../../t.dat", FileMode.Open);
        fIn = new BinaryReader(f);

        f.Seek(0, SeekOrigin.Begin);
        for (int i = 0; i < n; i++)
        {
            a = fIn.ReadInt32();
            Console.Write(a + " ");
        }

        Console.WriteLine("\n3) Прочитать и напечатать все числа из файла в прямом порядке");

        f.Seek(0, SeekOrigin.Begin);
        for (long i = 0; i < n; i++)
        {
            a = fIn.ReadInt32();
            Console.Write(a + " ");
        }
        // 1) TODO: Прочитать и напечатать все числа из файла в обратном порядке
        // 2) TODO: увеличить  все числа в файле в 5 раз
        // 3) TODO: Прочитать и напечатать все числа из файла в прямом порядке
        fIn.Close();
        f.Close();
    }
}

