using System;

namespace Standard_Deviation
{
    class Program
    {
        static double MeanCalculator(double[] array, int x)
        {
            //Initialize mean value, add each value, then divide by x (totalElements)
            double mean = 0;
            for (int i = 0; i < x; i++)
            {
                mean += array[i];
            }
            mean /= x;

            return mean;
        }
        static double StandardDeviation(double[] array, int x)
        {
            //Initialize variables holding the mean and Standard Deviation
            double mean = MeanCalculator(array, x);
            double standardDeviation = 0;

            //Calculate the difference between the ith number and the mean
            //Square and add this to the runningTotal value
            for (int i = 0; i < x; i++)
            {
                standardDeviation = standardDeviation + Math.Pow((array[i] - mean), 2);
            }

            //Divide runningTotal by x (totalElements) then find square root of this
            standardDeviation = Math.Sqrt(standardDeviation / x);

            return standardDeviation;
        }

        static void Main(string[] args)
        {
            //Get initial totalElements value and fill with user defined values
            Console.Write("How many numbers? ");
            int totalElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} numbers: ", totalElements);

            double[] array = new double[totalElements];
            for (int i = 0; i < totalElements; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("");

            //Call StandardDeviation function
            double result = StandardDeviation(array, totalElements);

            //Print result
            Console.WriteLine("Standard Deviation: {0:F3}", result);
        }
    }
}
