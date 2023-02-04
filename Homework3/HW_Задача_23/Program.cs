// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Например:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("");
System.Console.WriteLine("");


System.Console.Write("Введите число: ");
double num = Convert.ToDouble(System.Console.ReadLine());


System.Console.WriteLine("");

if (num >= 1)
{
Console.WriteLine("┌───────┬───────┐");
Console.WriteLine("│ Число\t│ Куб\t│"); // \t -табуляция, пишется в "\t"
Console.WriteLine("├───────┼───────┤");

for (double i = 1; i <= num; i++)
{
    if (i < num)
    {
        Console.WriteLine("│ " + i + "\t│ " + Math.Pow(i, 3) + "\t│");
        Console.WriteLine("├───────┼───────┤");
    }
    else if (i == num)
    {
        Console.WriteLine("│ " + i + "\t│ " + Math.Pow(i, 3) + "\t│");
        Console.WriteLine("└───────┴───────┘");
    }
}
}
else System.Console.WriteLine("Введено число меньше 1");
System.Console.WriteLine("");
System.Console.WriteLine("");