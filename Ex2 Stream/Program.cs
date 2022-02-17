using System;
using System.IO;
class Program
{
    static void Main()
    {
        FileInfo fi = new FileInfo(@"Alphabet.txt");
        Console.WriteLine("Choose a letter which will be replace with * sym");
        string deletedSym = Console.ReadLine();
        using (FileStream fs = fi.Open(FileMode.OpenOrCreate))
        {
            long len = fs.Length;   // Размер файла
            if (len == 26) Console.WriteLine("Aлфавит собран!");
            else
            {
                if (len == 0) Console.WriteLine("Файл пуст!");
                fs.Seek(len, SeekOrigin.Begin);
                byte bt = (byte)('A' + len);
                fs.WriteByte(bt);
                Console.WriteLine("Добавляем в файл букву " + (char)bt);
            }
            Console.WriteLine("Буквы в файле:");
            fs.Seek(0, SeekOrigin.Begin);
            int u;
            while ((u = fs.ReadByte()) != -1) {
                if ((char)u == deletedSym[0])
                {
                    Console.Write("*" + "  ");
                }
                else
                {
                    Console.Write((char)u + "  ");
                }
            }
            Console.WriteLine();
        }
    }
}
