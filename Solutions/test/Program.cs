// Import the System namespace to use the Math class
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the range of x-values for which to calculate the sine function
            double xMin = 0;
            double xMax = 1 * Math.PI;
            double xStep = 0.1;

            // Loop through the x-values and draw the sine of each value
            for (double x = xMin; x <= xMax; x += xStep)
            {
                // Calculate the y-value of the sine function at the current x-value
                double y = Math.Sin(x);

                // Scale the y-value to fit within the console window
                int yScaled = (int)(y * 10 + 20);

                // Draw the y-value as a vertical line in the console
                for (int i = 0; i < yScaled; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*\n");
            }
        }
    }
}