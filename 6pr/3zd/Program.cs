using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3zd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int temp = 0, N = 0, i = 0;
            Console.WriteLine("Введите N");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Значение массива а");

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < N / 2; i++)
            {
                temp = a[i * 2 + 1];
                a[i * 2 + 1] = a[i * 2];
                a[i * 2] = temp;
            }
            Console.WriteLine();
            Console.WriteLine("A[]");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(a[i] + "");
            }
            Console.ReadKey();
        }
    }
}
