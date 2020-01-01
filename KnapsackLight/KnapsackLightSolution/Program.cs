using System;

namespace KnapsackLightSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = CalculateKnapsackLight(0, 0, 0, 0, 0);
            Console.WriteLine("Hello World!");
        }

        private static int CalculateKnapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (weight1 + weight2 <= maxW)
            {
                return value1 + value2;
            }
            else if (weight1 > maxW && weight2 > maxW)
            {
                return 0;
            }
            else if ((value1 >= value2 && weight1 <= maxW) || weight2 > maxW)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

    }
}
