﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {//6.	Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, ..., 7) выводит на экран его название 
            Console.WriteLine("месяц");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("Зима ");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("зима");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Зима");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("весна");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("весна ");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("весна");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("лето");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("лето");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("лето");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("осень");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("осень");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("осень");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("error");
                        break;
                    }
            }
                    
                    Console.ReadKey();
                
            }
        }
    }
}