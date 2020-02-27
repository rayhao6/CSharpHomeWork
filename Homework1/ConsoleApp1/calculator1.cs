using System;

namespace ConsoleApp1
{
    class calculator1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*int a = 42;
            int b = 119;
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();*/

            double num1 = 0, num2 = 0;
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Type a number, and then press Enter");
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
                
            }
            catch (Exception x)
            {
                Console.WriteLine("invalid input");
                return;
            }
            Console.WriteLine("Type another number, and then press Enter");
            try
            {
                num2 = Convert.ToDouble(Console.ReadLine());

            }
            catch (Exception x)
            {
                Console.WriteLine("invalid input");
                return;
            }
          

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"your result :{num1}+{num2} = " + (num1+num2) );
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            };
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
