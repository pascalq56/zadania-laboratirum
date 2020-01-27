
using System;



class MainClass
{





    public static void Menu()

    {
        Console.WriteLine(" ");

        Console.WriteLine("Choose your function");

        Console.WriteLine("1 - Exponentation");

        Console.WriteLine("2 - N expression in arithmetic string");

        Console.WriteLine("3 - Field of trapeze");

        Console.WriteLine("4 - Volume of the straight prism");

        Console.WriteLine("5 - Changing angle to sinus value");

        Console.WriteLine("0 - Exit");
    }
    public static bool IsInt(string text)

    {

        int num = 0;

        bool isInt = false;

        if (string.IsNullOrEmpty(text))

        {

            return false;

        }

        isInt = Int32.TryParse(text, out num);

        return isInt;

    }
    public bool IsDouble(string text)

    {

        Double num = 0;

        bool isDouble = false;

        if (string.IsNullOrEmpty(text))

        {

            return false;

        }

        isDouble = Double.TryParse(text, out num);

        return isDouble;

    }
    public static void Main(string[] args)
    {

        Console.WriteLine("Mathematical formulas by Michał Ufnal nr. indeksu 54160");

        int s = 0;

        int w = 1;

        while (w != 0)

        {

            Menu();

            string sw = Console.ReadLine();

            if (IsInt(sw) == true)

            {

                s = Convert.ToInt32(sw);

                switch (s)

                {
                    case 1:
                        try
                        {
                            double BaseNumber, PowerNumber;

                            Console.WriteLine("Raising the number to a given power");//potęgowanie
                            Console.WriteLine("Enter base number: ");
                            BaseNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter power number: ");
                            PowerNumber = Convert.ToDouble(Console.ReadLine());

                            Console.Write("{0} to the power of {1} = {2}", BaseNumber, PowerNumber, Math.Pow(BaseNumber, PowerNumber));
                        }
                        catch 
                        {
                            Console.WriteLine("You have to enter numbers.");
                            continue;
                        }

                            // Math.Pow przyjemniejsze niż pętla

                            break;


                    case 2:
                        try
                        {
                            double FirstWord, Subtraction; int nWord;//nWord bez kontekstu

                            Console.WriteLine("n expression of arithmetic sequence with a first word in a string a1 and subtraction r");//n-ty wyraz ciągu

                            Console.WriteLine("Enter first word of a string: ");
                            FirstWord = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Which word you want to get: ");
                            nWord = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Subtraction: ");
                            Subtraction = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("{0}", FirstWord + (nWord - 1) * Subtraction);
                        }
                        catch 
                         {
                            Console.WriteLine("You have to enter numbers.");
                            continue;
                        }

                        break;


                    case 3:
                        try
                        {
                            double FirstLength, SecondLength, Height;

                            Console.WriteLine("This program can calculate field of trapeze, if you know lenghts of sides and height");//pole trapezu
                            Console.WriteLine("Type length of first side: ");
                            FirstLength = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Type length of second side: ");
                            SecondLength = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Type height of your trapeze: ");
                            Height = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Field of your trapeze is {0}", (FirstLength + SecondLength) / 2 * Height);
                        }
                        catch 
                        {
                            Console.WriteLine("You have to enter numbers.");
                            continue;
                        }

                        break;


                    case 4:
                        try
                        {
                            double BaseArea, HeightOfPyramid;

                            Console.WriteLine("This program can calulate volume of the straight prism, if you know base area and height");//objętość graniastosłupa prostego
                            Console.WriteLine("Enter base area of straight prism: ");
                            BaseArea = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter height of straight prism: ");
                            HeightOfPyramid = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Volume of the straight prism = {0}", BaseArea * HeightOfPyramid);
                        }
                        catch
                        {
                            Console.WriteLine("You have to enter numbers.");
                            continue;
                        }
                        break;


                    case 5:
                        try
                        {
                            double Angle;

                            Console.WriteLine("This program can change angle to sinus value ");
                            Console.WriteLine("Enter an angle: ");
                            Angle = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0}", Math.Sin(Angle));
                        }
                        catch
                        {
                            Console.WriteLine("You have to enter numbers.");
                            continue;
                        }

                        break;


                    case 0:

                        Console.WriteLine("Bye");

                        w = 0;

                        break;

                    //wyjscie

                    default:

                        Console.WriteLine("Enter number between 1 and 5 or exit by entering 0");

                        break;

                }

            }

            else

            {

                Console.WriteLine("Enter the number!");

            }
        }
    }
}
