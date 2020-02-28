using System;

namespace calculator
{
    class Program
    {
        private static int Maxnum(int[] arrary)
        {
            int length = arrary.Length;
            int maxnum = arrary[0];
            for(int i = 0; i < length; ++i)
            {
                if (arrary[i] > maxnum)
                {
                    maxnum = arrary[i];
                }
            }
            return maxnum;
        }

            static void Main(string[] args)
        {
            int[] num = new int[] {1,2,3,4,5,6 };
            int a = Maxnum(num);
            Console.WriteLine(a);

        }
    }
}
