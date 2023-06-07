Double a, b;
Console.WriteLine("Введите а: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b: ");
b = double.Parse(Console.ReadLine());
Double x;
if (a > b)
{
    x = a / b + 1;
    Console.WriteLine($"Вычисляем выражение N {x}");
}
else
    if (a < b)
{
    x = (a - b) / a;
    Console.WriteLine($"Вычисляем выражение N {x}");
}
else 
    if (a == b)
{
    x = -2;
    Console.WriteLine($"Вычисляем выражение N {x}");
}
Console.ReadKey();