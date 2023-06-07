using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A=");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("B=");
            int B = int.Parse(Console.ReadLine());

            int i = B;
            while (i >= A)
            {
                if ((i < 0) && (i % 2 == 0))
                    Console.WriteLine(i);
                i--;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
