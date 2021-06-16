using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n / 100;
            int c = n % 10;
            int b = n % 100 / 10;
            if (a == b || b == c)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();


            }
        }
    }

