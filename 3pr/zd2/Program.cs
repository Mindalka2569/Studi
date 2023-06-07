int x, y;
Console.WriteLine("Введите x ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y ");
y = int.Parse(Console.ReadLine());
if (((x >= 0) & (y >= 0) & (x * x + y * y <= 36)) | ((x >= 0 ) & (y >= 0) & (x <= 6 - y)))
{
    Console.WriteLine("Принадлежит");
}
else
{
    Console.WriteLine("Не принадлежит");
}
Console.ReadKey();