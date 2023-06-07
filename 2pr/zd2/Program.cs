Console.WriteLine("*************************");
Console.WriteLine("Банк");
Console.WriteLine("*************************");
double x;

Console.WriteLine("Было вложено");
x = double.Parse(Console.ReadLine());
Console.WriteLine("**************************");

x = (x + x * 3 / 100);
Console.WriteLine($"Вклад за год 3% = {x} рублей");
Console.WriteLine("**************************");

x = (x + x * 8 / 100);
Console.WriteLine($"Вклад за два года 8% = {x} рублей");
Console.WriteLine("**************************");
Console.WriteLine($"Денег на вашем счету за два года = {x} рублей");

Console.ReadKey();

//1 Структурное программирование. 2 Одномерные массивы.
//1.Даны натуральные числа n и k. Составить программу вычисления выражения 1k+ 2k +...+ nk.
//Разработать меню программы. Пункты меню: ввод данных, обработка, просмотр результатов, выход. 
// using System;

/* public class SumOfPowers
{
    public static void Main()
    {
        int n = 0, k = 0;
        int choice = 0;
        bool exit = false;

        do
        {
            Console.WriteLine("1. Ввод данных");
            Console.WriteLine("2. Обработка");
            Console.WriteLine("3. Просмотр результатов");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите пункт меню: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введите n: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Введите k: ");
                    k = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    long sum = 0;

                    for (int i = 1; i <= n; i++)
                    {
                        sum += (long)Math.Pow(i, k);
                    }

                    Console.WriteLine("Сумма: " + sum);
                    break;
                case 3:
                    Console.WriteLine("n = " + n);
                    Console.WriteLine("k = " + k);
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

            Console.WriteLine();

        } while (!exit);
    }
}
*/
/* 2 Одномерные массивы.:
Дан целочисленный массив размера N. Проверить, чередуются ли в нем четные
и нечетные числа. Если чередуются, то вывести 0, если нет, то вывести
порядковый номер первого элемента, нарушающего закономерность
using System;

public class CheckArray
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int n = arr.Length;
        int i = 0;

        while (i < n - 1 && ((arr[i] % 2 == 0 && arr[i + 1] % 2 == 1) || (arr[i] % 2 == 1 && arr[i + 1] % 2 == 0)))
        {
            i++;
        }

        if (i == n - 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(i + 1);
        }
    }
}
*/

