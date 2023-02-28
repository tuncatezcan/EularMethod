using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EularMethod
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Define initial conditions and constants
            double y0 = 1; // initial value of y
            double t0 = 0; // initial value of t
            double h = 0.1; // step size
            double k = 1; // constant

            // Loop to calculate values of y and t
            for (double t = t0; t <= 1; t += h)
            {
                double y = y0 + h * (k * y0); // Euler's method
                y0 = y; // update y0 for the next iteration
                Console.WriteLine("t = {0:F1}, y = {1:F5}", t + h, y);
            }

            Console.ReadLine();
        }
    }

}

