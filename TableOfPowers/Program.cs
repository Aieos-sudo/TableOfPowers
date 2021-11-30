using System;

namespace TableOfPowers
{
    internal class Program
    {
        static void Title()
        {
            Console.WriteLine("Table of Powers\n");
        }
        static void Main(string[] args)
        {
            string startNumber;
            string stopNumber;
            Title();
            do
            {
                Console.Write("Start number: ");
                startNumber = Console.ReadLine();
                Console.Write("Stop number: ");
                stopNumber = Console.ReadLine();
                Console.WriteLine();
                if (Convert.ToInt32(stopNumber) < Convert.ToInt32(startNumber))
                {
                    Console.WriteLine("Error: Stop number must be greater than Start number");
                }
            }
            while (Convert.ToInt32(stopNumber) < Convert.ToInt32(startNumber));
            Console.WriteLine("Number        Squared        Cubed");
            Console.WriteLine("======        =======        =====");
            for (int i = Convert.ToInt32(startNumber); i <= Convert.ToInt32(stopNumber); i++)
            {
                double increment = ConvertIntToDouble(i);
                double square = PowerCalculationSquare(i);
                double cube = PowerCalculationCube(i);
                Console.Write(increment);
                Console.Write("            " + square);
                Console.Write("           " + cube);
                Console.WriteLine(  );
            }
        }
        static double ConvertIntToDouble(int i)
        {
            double increment;
            increment = Convert.ToDouble(i);
            return increment;
        }
        static double PowerCalculationSquare(int i)
        {
            double square;
            square = Math.Pow(Convert.ToInt32(i), 2);
            return square;

        }
        static double PowerCalculationCube(int i)
        {
            double cube;
            cube = Math.Pow(Convert.ToInt32(i), 3);
            return cube;
        }
    }
}
