using System;
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
            int S=0;
            Console.WriteLine("Введите число");
            N = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <=N; i++)
            {
                S = S + (2 * i - 1);

                Console.WriteLine("Квадрат числа {0} равен {1}", i, S );
            }
            Console.ReadKey();
        }
    }
}

