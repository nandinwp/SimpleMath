using System;

namespace TheMath
{
    internal class Program
    {
        static double a, b;
        static int x;
        static void Main(string[] args)
        {
            printMenu(true);
            Console.ReadKey();
        }

        static void printMenu(bool geter) 
        {
            if (geter)
            {
                Console.WriteLine("****************************");
                Console.WriteLine("**********Simple Math*******");
                Console.WriteLine("****************************");
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("****************************");
                Console.WriteLine("**********Simple Math*******");
                Console.WriteLine("****************************");
                Console.WriteLine("****choose an operation:****");
                Console.WriteLine("\t1 -addition.\n\t2 -multiplication.\n\t3 -division.\n\t4 -subtraction.");
            }
            bool s = geter ? getTwoNumber() : false;
        }
        static bool getTwoNumber() 
        {
            try 
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"\t{i + 1} number: ");
                    double s = i == 0 ? a = double.Parse(Console.ReadLine()) : b = double.Parse(Console.ReadLine());
                }
                GetMathOperation();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error. Try again!\n");
                printMenu(true);
            }
            return true;
        }

        static void GetMathOperation()
        {
            printMenu(false);
            try
            {
                x = int.Parse(Console.ReadLine());

                if (x <= 4)
                {
                    double r = Math(a, b, x);

                    if (r >= 0)
                    {
                        Console.WriteLine($"\nreported numbers: {a} and {b} :\n\tResult:{r}");
                    }
                    else
                    {
                        printMenu(true);
                    }
                }
                else 
                {
                    GetMathOperation();

                }
            }
            catch 
            {
                printMenu(false);
            }
        }

        static double Math(double a, double b, int op) 
        {
            switch (op)
            {
                case 1: return a + b; break;
                case 2: return a * b; break;
                case 3: return a / b; break;
                case 4: return a - b; break;
                default: return -1; break;
            }
        }
    }
}
