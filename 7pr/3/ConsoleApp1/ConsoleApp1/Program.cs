using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    mas[i, j] = int.Parse(Console.ReadLine());
           
            Console.WriteLine();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("" + mas[i, j]);
                }
                Console.WriteLine();
            }
        for(int i=0; i < n; i++)
        {
                int[] m = new int[n];
                for(int j=0; j < n; j++)
                {
                    m[j] = mas[i, j];
                }
                var m1 = m.OrderBy(n => n);
                int k = 0;
                foreach(int o in m1)
                {
                    mas[i, k] = o;
                    k++;
                }
        }
            Console.WriteLine("Результат сортировки:");
            for(int i=0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("" + mas[i,j]));
                }
            }
        }
    }
}


