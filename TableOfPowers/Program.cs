using System;

namespace TableOfPowers
{
    internal class Program
    {
        //This is never called
        static void Title()
        {
            Console.WriteLine("Table of Powers\n");
        }
        static void Main(string[] args)
        {
            string startNumber;
            string stopNumber;
            //Your approach to finding checking if stopNumber is less than startNumber is fine but an alternative would be to use a do while loop with an if statement to check stopNumber < startNumber. Example below
            /*
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
            */

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
        //Would rename this to ConvertIntToDouble(int i) to better represent what the function is doing
        static double numberIncrementCalculation(int i)
        {
            double increment;
            increment = Convert.ToDouble(i);
            return increment;
        }
        //Capitialize first letter of method
        static double powerCalculationSquare(int i)
        {
            double square;
            square = Math.Pow(Convert.ToInt32(i), 2);
            return square;

        }
        //Capitialize first letter of method
        static double powerCalculationCube(int i)
        {
            double cube;
            cube = Math.Pow(Convert.ToInt32(i), 3);
            return cube;
        }
    }
}
