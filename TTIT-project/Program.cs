using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TTIT_project
{
    class Program
    {
        internal static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Minus(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            WriteLine("Введите два числа");
            Write("Число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Write("Число Б: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Plus(a, b);
            WriteLine($"{a} + {b} = {c}");
            c = Minus(a, b);
            WriteLine($"{a} - {b} = {c}");
            Console.ReadKey();
        }
    }
}
