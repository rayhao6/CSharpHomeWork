using System;

namespace work3
{
    class Program
    {
        private static void Sieve(int n)
        {
            bool[] arrary = new bool[n+1];
            for (int i = 2; i <= n; ++i)
            {
                 arrary[i] = true;
            }
            for (int i = 2; i < n; ++i)
            {
                if (arrary[i])
                {
                    for (int j = i*2; j <=n; j += i)
                    {
                        arrary[j] = false;
                    }
                }

            }
            for (int i = 2; i <= n; ++i)
            {
                if (arrary[i]) Console.Write(i + " ");
            }

        }

        static void Main(string[] args)
        {
            try
            {
                string k;
                Console.WriteLine("please enter the num");
                k = Console.ReadLine();
                int num = Int32.Parse(k);
                Sieve(num);
            }

            catch (Exception x)
            {
                Console.WriteLine("输入非法");
            }
        }
    }
}

