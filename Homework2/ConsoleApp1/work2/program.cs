using System;

namespace calculator
{
    class Program
    {
        private static int Maxnum(int[] arrary)
        {
            int length = arrary.Length;
            int maxnum = arrary[0];
            for (int i = 0; i < length; ++i)
            {
                if (arrary[i] > maxnum)
                {
                    maxnum = arrary[i];
                }
            }
            return maxnum;
        }
        private static int Minnum(int[] arrary)
        {
            int length = arrary.Length;
            int minnum = arrary[0];
            for (int i = 0; i < length; ++i)
            {
                if (arrary[i] < minnum)
                {
                    minnum = arrary[i];
                }
            }
            return minnum;
        }
        private static int Sum(int[] arrary)
        {
            int sum = 0;
            int length = arrary.Length;
            for (int i = 0; i < length; ++i)
            {
                sum += arrary[i];
            }
            return sum;
        }
        private static double Mean(int[] arrary)
        {
            double mean = 0;
            int length = arrary.Length;
            for (int i = 0; i < length; ++i)
            {
                mean += arrary[i];
            }
            mean /= length;
            return mean;
        }

        static void Main(string[] args)
        {
            try
            {

                int[] num = new int[] { 1, 5, 16, 1, 5, 68, 4, 6, 55, 46, 86, 79, 64 };
                double mean1 = Mean(num);
                int max = Maxnum(num);
                int min = Minnum(num);
                int sum = Sum(num);

                Console.WriteLine(max);
                Console.WriteLine(min);
                Console.WriteLine(mean1);
                Console.WriteLine(sum);
            }
            catch (Exception x)
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
