using System;

namespace Ex1_Interface
{
    public interface ISeries
    { // интерфейс числовых рядов

        void SetBegin();            // задать начальное состояние
        int GetNext { get; }        // вернуть очередной член ряда
        int this[int k] { get; }    // вернуть к-й член ряда
    }
    public class Pell : ISeries
    { // Ряд Пелла: 1, 2, 5, 12,...      
        int old, last;              // два предыдущих члена ряда
        public Pell() { SetBegin(); }   // конструктор
        public void SetBegin()
        {// задать начальное состояние
            old = 0; last = 1;
        }
        public int GetNext
        {    // вернуть следующий после last         
            get
            {
                int now = old + 2 * last;
                old = last; last = now;
                return now;
            }
        }
        public int this[int k]
        { // вернуть к-й член ряда        
            get
            {
                int now = 0;
                SetBegin();
                if (k <= 0) return -1;
                for (int j = 0; j < k; j++) now = GetNext;
                return now;
            }
        }
    } // end of Pell

    public class Fibok : ISeries
    { // Ряд Пелла: 1, 2, 5, 12,...      
        int old, last;              // два предыдущих члена ряда
        public Fibok() { SetBegin(); }   // конструктор
        public void SetBegin()
        {// задать начальное состояние
            old = 0; last = 2;
        }
        public int GetNext
        {    // вернуть следующий после last         
            get
            {
                int now = old + last;
                old = last; last = now;
                return now;
            }
        }
        public int this[int k]
        { // вернуть к-й член ряда        
            get
            {
                int now = 0;
                SetBegin();
                if (k <= 0) return -1;
                for (int j = 0; j < k; j++) now = GetNext;
                return now;
            }
        }
    } // end of Pell

    public class Luke : ISeries
    { // Ряд Пелла: 1, 2, 5, 12,...      
        int old, last;              // два предыдущих члена ряда
        public Luke() { SetBegin(); }   // конструктор
        public void SetBegin()
        {// задать начальное состояние
            old = 3; last = =1;
        }
        public int GetNext
        {    // вернуть следующий после last         
            get
            {
                int now = old + last;
                old = last; last = now;
                return now;
            }
        }
        public int this[int k]
        { // вернуть к-й член ряда        
            get
            {
                int now = 0;
                SetBegin();
                if (k <= 0) return -1;
                for (int j = 0; j < k; j++) now = GetNext;
                return now;
            }
        }
    } // end of Pell

    class Program
    {
        // вывести n членов ряда
        public static void SeriesPrint(int n, ISeries s)
        {
            for (int i = 0; i < n; i++)
                Console.Write(s.GetNext + "\t");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Pell pell = new Pell();
            SeriesPrint(9, pell);
            Console.WriteLine("pell[3] = " + pell[3]);
            SeriesPrint(4, pell);
            SeriesPrint(3, pell);

        }
    }

}
