using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            double sum = 1;
            double k = 1;

            for (int i = 2; i <= N; i++)
            {
                k = sum / i + k;
                Console.WriteLine(k);
            }
            Console.WriteLine("Сумма " + k);
            Console.ReadKey();
        }
        
    }
}
