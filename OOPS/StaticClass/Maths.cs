using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Maths
    {
        private static readonly double Pi;


        // static class can have only static non parameterized constructor
        static Maths()
        {
            Pi = 3.141592653589793;
        }

        // menthods in static class need to be static. Static class cannot create instance members
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (double)a / b;
        }

        public static double CalculateCircleArea(double radius)
        {
            return Pi * radius * radius;
        }
    }
}
