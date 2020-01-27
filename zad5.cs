using System;
using System.Collections.Generic;

namespace Zad5
{
    class Program
    {


        static void Main(string[] args)
        {
            int a = 0;
            double max = Int32.MinValue, min = Int32.MaxValue;
            Console.WriteLine("Ilosc liczb ");
            a = Convert.ToInt32(Console.ReadLine());
            double[] tab1 = new double[a];

            for (int i = 0; i < a; i++)
            {
                tab1[i] = Convert.ToDouble(Console.ReadLine());
            }

            Array.Sort(tab1);

            foreach (double b in tab1)
            {
                if (b < min && b % 2 != 0) {
                    min = b;
                }; 
            }
            

            foreach (double c in tab1)
            { 
                if (c > max && c % 2 == 0) 
                     max = c;

                 
            }




            Console.WriteLine("Najmniejsza nieparzysta liczba jest {0}, a najwieksza parzysta {1}", min, max );
            Console.ReadKey(true);
        }
    }
}