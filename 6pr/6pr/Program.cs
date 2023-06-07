using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6pr
{
    class Program
    {
        static void Main(string[] args)
        {
            bool g = new bool();
            int gtt = 0;
            int N;
            Console.WriteLine("N:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("A[{0}]:", i);
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Sign(array[i]) != Math.Sign(array[i - 1]))
                {
                    g = true;
                }
                else
                {
                    g = false;
                    gtt = i;
                    Console.WriteLine(gtt);
                    break;
                }


            }
            Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}
