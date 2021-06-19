using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {//5.	Дано натуральное трехзначное число. Выяснить является ли оно полиндромом.
            Console.WriteLine("Введите чсло");
            int x = Convert.ToInt32(Console.ReadLine());
            int a = x / 100;
            int c = x % 10;
            if (a == c)
            {
                Console.WriteLine("явл");
            }
            else
            {
                Console.WriteLine("Не явл");
            }
            Console.ReadKey();
        }
    }
}
