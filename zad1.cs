using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Sprawdz, czy liczba jest podzielna przez 2, 3, 4, 5, 6, 7, 8 i 9");
            Console.Write("Podaj liczbe ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Liczba {0} jest podzielna przez 2", a);
            else
                Console.WriteLine("Liczba {0} nie jest podzielna przez 2", a);
            if (a % 3 == 0)
                Console.WriteLine("Liczba {0} jest podzielna przez 3", a);
            else
                Console.WriteLine("Liczba {0} nie jest podzielna przez 3", a);
            if (a % 4 == 0)
                Console.WriteLine("Liczba {0} jest podzielna przez 4", a);
            else
                Console.WriteLine("Liczba {0} nie jest podzielna przez 4", a);
            if (a % 5 == 0)
                Console.WriteLine("Liczba {0} jest podzielna przez 5", a);
            else
                Console.WriteLine("Liczba {0} nie jest podzielna przez 5", a);
            if (a % 6 == 0)
                Console.WriteLine("Liczba {0} jest podzielna przez 6", a);
            else
                Console.WriteLine("Liczba {0} nie jest podzielna przez 6", a);
            if (a % 7 == 0)
                Console.WriteLine("Liczba {0} jest podzielna przez 7", a);
            else
                Console.WriteLine("Liczba {0} nie jest podzielna przez ", a);
            if (a % 8 == 0)
                Console.WriteLine("Liczba {0} jest podzielna przez 8", a);
            else
                Console.WriteLine("Liczba {0} nie jest podzielna przez 8", a);
            if (a % 9 == 0)
                Console.WriteLine("Liczba {0} jest podzielna przez 9", a);
            else
                Console.WriteLine("Liczba {0} nie jest podzielna przez 9", a);

            Console.ReadKey(true);
        }
    }
}
