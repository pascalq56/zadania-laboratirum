using System;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczenie pola wycinku kola");
            Console.WriteLine("Podaj promien kola");

            double promien = -1;
            double kat = -1;
            bool lg = false;

            do
            {
          
                try
                {
                    promien = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Promien powinien miec poprawna wartosc");
                    lg = true;
                    continue;
                }

                if (promien < 0)
                {
                    lg = true;
                    Console.WriteLine("Promien powinien posiadac wartosc dodatnia, postaraj sie wprowadzic dane jeszcze raz");
                    continue;
                }

                lg = false;
            } while (lg);

            Console.WriteLine("Promien: {0}", promien);
            Console.WriteLine("Wprowadz wartosc kata w stopniach ", kat);
            do
            {
                try
                {
                    kat = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Kat powinien posiadac poprawna wartosc");
                    lg = true;
                    continue;
                }

                if (kat < 0)
                {
                    lg = true;
                    Console.WriteLine("Promien powinien posiadac wartosc dodatnia, wprowadz dane ponownie");
                    continue;
                }
                if (kat > 360)
                {
                    lg = true;
                    Console.WriteLine("promien powinien miec mniej niz 360*");
                    continue;
                }
                lg = false;
            } while (lg);
            Console.WriteLine("Kat: {0}", kat);

            double result = (kat / 360) * Math.PI * (promien * promien);
            Console.WriteLine(": {0}", result);
        }
    }
}