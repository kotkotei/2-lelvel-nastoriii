using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {//4.	Определить, является ли треугольник со сторонами a, b, c равнобедренным.
            Console.WriteLine("Введите соторну а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите соторну б");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите соторну с");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b || b == c || c==a)
            {
                Console.WriteLine("Является");
            }
            else
            {
                Console.WriteLine("Не явл");
            }
            Console.ReadKey();
        }
    }
}
