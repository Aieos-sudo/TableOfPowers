using System;
using System.IO;

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
            try
            {
                string startNumber = String.Empty;
                string stopNumber = String.Empty;
                int intStartNumber = 0;
                int intStopNumber = 0;
                bool check = false;
                Title();
                do
                {
                    try
                    {
                        Console.Write("Start number: ");
                        startNumber = Console.ReadLine();
                        Console.Write("Stop number: ");
                        stopNumber = Console.ReadLine();
                        Console.WriteLine();
                        intStartNumber = Convert.ToInt32(startNumber);
                        intStopNumber = Convert.ToInt32(stopNumber);
                        if (intStartNumber < 10 || intStartNumber > 100)
                        {
                            Console.WriteLine("Start Number has to be between 10 and 100");
                            check = false;
                        }
                        else if (intStopNumber < intStartNumber || (intStopNumber < 10 || intStopNumber > 100))
                        {
                            Console.WriteLine("Stop number has to be between 10 and 100 and greater than start number");
                            check = false;
                        }
                        else
                        {
                            check = true;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("You entered the wrong value. Please enter an integer.");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("Error writing to file.");
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("You entered a number that was too large. Please enter a number less than 2.4 billion");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Something went wrong. Error: " + ex.Message);
                    }
                }
                while (check == false);
                Console.WriteLine("Number        Squared        Cubed");
                Console.WriteLine("======        =======        =====");
                for (int i = intStartNumber; i <= intStopNumber; i++)
                {
                    double increment = ConvertIntToDouble(i);
                    double square = PowerCalculationSquare(i);
                    double cube = PowerCalculationCube(i);
                    Console.Write(increment);
                    Console.Write("            " + square);
                    Console.Write("           " + cube);
                    Console.WriteLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went wrong. Error: " + ex.Message);
            }

        }
        static double ConvertIntToDouble(int i)
        {
            double increment = 0.0;
            try
            {
                increment = Convert.ToDouble(i);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in ConvertIntToDouble(). Error: " + ex.Message);
            }
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
