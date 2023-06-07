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
            int b = 0;
            Console.WriteLine("Количество страниц следущего издания");
            n = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Количество страниц следущего издания");
                n = Convert.ToInt32(Console.ReadLine());

                if (n > 16) 
                    b += n;
            }

            while (n != 0);
            Console.WriteLine("Количество страниц " + b);
            Console.ReadKey();
        }
    }
}
