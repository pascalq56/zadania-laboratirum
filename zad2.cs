using System;
namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz walute ");
            Console.WriteLine("0 => Kuna Chorwacka");
            Console.WriteLine("1 => Forint Wegierski");
            Console.WriteLine("2 => Bat Tajski");
            Console.WriteLine("3 => Jen Japonski");

            int waluta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ilosc do przewalutowania ");
            double ilosc = Convert.ToDouble(Console.ReadLine());

            double[] kursy = {
                0.5788, 
                0.012599,
                0.1262, 
                0.03484
            };

            double wynik = ilosc / kursy[waluta];

            Console.WriteLine("W przeliczeniu na zl wyjdzie {0}", wynik);
        }
    }
}