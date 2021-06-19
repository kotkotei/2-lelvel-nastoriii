using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {// 2 level 2 3ada4a
            //2.	Дано трехзначное число. Определить, есть ли среди его цифр одинаковые.
            Console.WriteLine("Введитче число");
            int n = Convert.ToInt32(Console.ReadLine());
            Convert.ToInt32(Console.ReadLine());
            int a = n / 100;
            int c = n % 10;
            int b = n % 100 / 10;
            if (a == b || a == c || b == c)
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
