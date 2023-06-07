using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4zd
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            while (true)
            {
                Console.Write("Введите N ");
                if (int.TryParse(Console.ReadLine(), out k) && k >= 2) break;
            }
            int[] mai = new int[k];
            mai[0] = 1;
            mai[1] = 1;
            for (int i = 2; i < k; i++) mai[i] = mai[i - 1] + mai[i - 2];
            foreach (int i in mai) Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
