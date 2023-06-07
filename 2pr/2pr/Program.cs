Console.WriteLine("******************************");
Console.WriteLine("Нахождение квадратных корней");
Console.WriteLine("******************************");
int a, b, c;
Console.WriteLine("Введите a");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c");
c = int.Parse(Console.ReadLine());
Double d;
d = b * b - 4 * a * c;
if (d > 0)
{
    Double x1 = (-b - Math.Sqrt(d) / (2 * a));
    Double x2 = (-b + Math.Sqrt(d) / (2 * a));
    Console.WriteLine("Дискриминант = " + d);
    Console.WriteLine("Первый корень = " + x1);
    Console.WriteLine("Второй корень = " + x2);
}
if (d < 0)
{
    Console.WriteLine("Корней нет");
}
if (d == 0)
{
    Double x1 = -b / (2 * a);
    Console.WriteLine("Дискриминант = 0 " + x1);
}
Console.ReadKey();