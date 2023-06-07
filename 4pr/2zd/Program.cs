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
            int bak = 1;
            uint min;
            Console.WriteLine("Введите минуты");
            min = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= min; i++)
            {
                bak = bak * 2;
            }
            Console.WriteLine("Количество бактерий " + bak);
            Console.ReadKey();
        }
    }
}
