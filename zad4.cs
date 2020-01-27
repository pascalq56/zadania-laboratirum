using System;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            double ostatnia = -1;
            Console.WriteLine("Obliczanie sumy ");
            while (ostatnia != 0)
            {
                Console.WriteLine("Podaj liczbe ");
                ostatnia = Convert.ToDouble(Console.ReadLine());
                suma += ostatnia;
                Console.WriteLine("Suma wynosi {0}", suma);
            }

        }
    }
}