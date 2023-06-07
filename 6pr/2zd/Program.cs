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
            int y = 0;
            int b = 0;
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array[{0}]", i);
                array[i] = int.Parse(Console.ReadLine());

            }
            foreach (int i in array)
            {
                foreach (int j in array)
                    if (i == j)
                        y++;
                if (b < y)
                    b = y;
                y = 0;
            }
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
