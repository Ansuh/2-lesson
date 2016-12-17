using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class MyProgram
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }

            F1(1,2);
            F2(1,2,d:5);
            F3(1, 2, 3, 4, 5, 6); // this gnum e vorpes array
            F3(1, 2, new int[] { 3, 4, 5, 6 }); // the same bayc sinatxis aveli harmar e
            int x; // chi pahanjum x-in arjec tal
            F4(out x);

            int y = 0; // pahanjum e arjeq tal
            F4(ref y, 0);

            int f = GetInt("b");

            for (ulong i = 0; i < 100; i++)
            {
                try
                {
                    Console.WriteLine($"{i}:\t{ Factorial(i)}");
                }

                catch// aysinqn henc brnec vor overfolwa kangnuma bayc voch te trnuma tsragirt ayl et texic shprtvat exception brnum cuyca talis, sa kochvum e exception heandling

                {
                    break;
                }
                
            }

            for (ulong i = 0; i < ulong.MaxValue; i++)
            {
                Console.WriteLine(Fibonacci(i));

            }
            Console.ReadKey();


        }

      

        static void F1(int a, int b, int c = 10)// function overloading 
        {
        }

        static void F2(int a, int b, int c = 3, int d = 4)
        {
        }

        static void F3(int a, int b, params int[] c)
        {
        }

        static void F3(int a, int [] b)
        {
        }

        static void F4(ref int a, int b)
        {
        }

        static void F4(out int a)
        {
            a = 1;
        }

        static int GetInt(string c)
        {
            int a;
            Console.WriteLine(c);
            do
            {
                Console.Write("Enter number ");

            } while (!int.TryParse(Console.ReadLine(), out a));

            return a;
        }

        static ulong Factorial(ulong n)
        {
            checked // sa stugum e types overflow-n ev henc texi e unenum overflow tsragir@ trnuma aysinqn shprtuma exception
            {
                return n == 0 ? 1 : n * Factorial(n - 1);
            }
        }

        static ulong Fibonacci(ulong n)
        {
            return (n == 0 || n == 1) ? 1 : Fibonacci(n - 1) + Fibonacci(n - 2);
        }





    }
}
