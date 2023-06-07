Console.WriteLine("Выбирите единицу измерения ");
Console.WriteLine("1 - Килограмм");
Console.WriteLine("2 - Миллиграмм");
Console.WriteLine("3 - Грамм");
Console.WriteLine("4 - Тонна");
Console.WriteLine("5 - Центнер");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите массу обьекта ");
int y = int.Parse(Console.ReadLine());

switch (x)
{
    case 1:
        Console.WriteLine("Килограмм " + y);
        break;
    case 2:
        Console.WriteLine("Миллиграмм " + y * 1000000);
        break;
    case 3:
        Console.WriteLine("Грамм " + y * 1000);
        break;
    case 4:
        Console.WriteLine("Тонна " + y / 1000);
        break;
    case 5:
        Console.WriteLine("Центнер " + y * 100);
        break;
}
Console.ReadKey();



