using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7pr
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int M;
            Console.Write("N=");
            N = int.Parse(Console.ReadLine());
            Console.Write("M=");
            M = int.Parse(Console.ReadLine());
            int[,] Arr = new int[M, N];
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < M; i++)
                {
                    Arr[i, j] = 5 * j;
                }

            }
            for (int j = 0; j < M; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    Console.Write(string.Format("{0,5:d}", Arr[j, i]));
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
