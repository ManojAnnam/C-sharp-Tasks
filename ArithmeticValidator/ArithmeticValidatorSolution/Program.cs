using System;

namespace ArithmeticValidatorSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = ArithmeticExpression(2, 3, 4);
        }

        public static bool ArithmeticExpression(int a, int b, int c)
        {
            if (a + b == c || a - b == c || a * b == c)
            {
                return true;
            }
            else
            {
                double temp = (a / (double)b);
                if (Math.Ceiling(temp) == Math.Floor(temp))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
