Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4


System.Console.WriteLine("Введите число N");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;

while( b <= a)
{
    System.Console.WriteLine(Math.Pow(b, 2));
    b++;
}



Через функцию
// void PrintSquares(int x) (
// for (int i = 1; i <= x; i++)
// (
// System.Console.Write(Math.Pow(i, 2)
// System.Console.WriteLine("Введите число N") int a = Convert.ToInt32(Console.ReadLine())
// System.Console.WriteLine();
// PrintSquares(a);