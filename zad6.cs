
using System;


namespace lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz wysokosc choinki");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i >= 1; i--)
            {
                for (int j = a; j > i; j--)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k < 2 * i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}