using System;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string k;
                Console.WriteLine("please enter the num");
                k = Console.ReadLine();
                int num = Int32.Parse(k);
                for (int i = 2; i <= num;)
                {
                    if (num % i == 0)
                    {
                        Console.Write(i);
                        Console.Write('\n');
                        num /= i;
                    }
                    else ++i;
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("invalid");
            }


        }
    }
}
