﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
            {
            int N;
            int sum;
            Console.WriteLine("Введите число");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=N; i++)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}", i, i * i);
            }
            Console.ReadKey();
        }
    }
}

