using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите размерность ");
            n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0,4}", matrix[i, j]);
                Console.WriteLine();
            }
            int min = int.MaxValue;
            for (int k = 1; k != n; k++)
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int i = n - 1, j = 0; i >= k; i--, j++)
                {
                    sum1 += Math.Abs(matrix[i - k, j]);
                    sum2 += Math.Abs(matrix[i, k + j]);

                }
                min = Math.Min(min, Math.Min(sum1, sum2));

            }
            Console.WriteLine("Минимальное" + min);
            Console.ReadKey();
        }
    }
}
