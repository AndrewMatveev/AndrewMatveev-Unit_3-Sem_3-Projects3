// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.WriteLine("");
System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());


int b = 1;


System.Console.Write("Соответствующие квадраты последовательности от 1 до " + a + ": ");
while (b <= a)
{
    System.Console.Write(Math.Pow(b, 2) + " ");
    b++;
}
System.Console.WriteLine("");