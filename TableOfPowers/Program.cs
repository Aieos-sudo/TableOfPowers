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

            Console.Write("Start number: ");
            startNumber = Console.ReadLine();
            Console.Write("Stop number: ");
            stopNumber = Console.ReadLine();
            Console.WriteLine();
            while (Convert.ToInt32(stopNumber) < Convert.ToInt32(startNumber))
            {
                Console.WriteLine("Error: Stop number must be greater than Start number");
                Console.Write("Start number: ");
                startNumber = Console.ReadLine();
                Console.Write("Stop number: ");
                stopNumber = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("Number        Squared        Cubed");
            Console.WriteLine("======        =======        =====");
            for (int i = Convert.ToInt32(startNumber); i <= Convert.ToInt32(stopNumber); i++)
            {
                double increment = numberIncrementCalculation(i);
                double square = powerCalculationSquare(i);
                double cube = powerCalculationCube(i);
                Console.Write(increment);
                Console.Write("            " + square);
                Console.Write("           " + cube);
                Console.WriteLine(  );
            }


        }
        static double numberIncrementCalculation(int i)
        {
            double increment;
            increment = Convert.ToDouble(i);
            return increment;
        }
        static double powerCalculationSquare(int i)
        {
            double square;
            square = Math.Pow(Convert.ToInt32(i), 2);
            return square;

        }
        static double powerCalculationCube(int i)
        {
            double cube;
            cube = Math.Pow(Convert.ToInt32(i), 3);
            return cube;
        }
    }
}
