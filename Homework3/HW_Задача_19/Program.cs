// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Пример:
// 14212 -> нет
// 12821 -> да
// 23432 -> да



// ____________________________РЕШЕНИЕ ЧЕРЕЗ МАТЕМАТИКУ БЕЗ ФОРМУЛ:___________________________________________

// System.Console.Write("Введите пятизначное число: ");
// int num = int.Parse(System.Console.ReadLine());

// if (Math.Abs(num) < 10000 || Math.Abs(num) > 99999) System.Console.WriteLine("Введено не пятизначное число");
// else
// {
//     int firstnum = num / 10000;
//     int secondnum = (num / 1000) % 10;
//     int fourthnum = (num / 10) % 10;
//     int fifthnum = num % 10;

//     if (firstnum == fifthnum && secondnum == fourthnum) System.Console.WriteLine("Число является палиндромом");
//     else System.Console.WriteLine("Число не является палиндромом");
// }

// ____________________________________________________________________________________________________________




// ____________________________РЕШЕНИЕ ЧЕРЕЗ МАТЕМАТИКУ С ФОРМУЛАМИ:___________________________________________

// int InputNumber(string str) // Формула для запроса ввода числа (метод)
// {  
//     System.Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void palindromecheck(int a) // Формула для определения палиндрома (метод)
// {
//     if (Math.Abs(a) < 10000 || Math.Abs(a) > 99999) System.Console.WriteLine("Введено не пятизначное число");
//     else
//     {
//         int firstnum = a / 10000;
//         int secondnum = (a / 1000) % 10;
//         int fourthnum = (a / 10) % 10;
//         int fifthnum = a % 10;

//         if (firstnum == fifthnum && secondnum == fourthnum) System.Console.WriteLine("Число является палиндромом");
//         else System.Console.WriteLine("Число не является палиндромом");
//     }
// }

// int num = InputNumber("Введите пятизначное число: "); // Обращение для запроса числа
// palindromecheck (num); // Обращение для определения палиндрома

// _____________________________________________________________________________________________________________



// _________________________________РЕШЕНИЕ ЧЕРЕЗ СТРОКУ (МАССИВ):___________________________________________

System.Console.Write("Введите число: ");
string num = System.Console.ReadLine();

if (num.Length != 5) System.Console.WriteLine("Введено не пятизначное число");
else if (num [0] != num [4] && num [1] != num [3]) System.Console.WriteLine("Число не является палиндромом");
else System.Console.WriteLine("Число является палиндромом");

// __________________________________________________________________________________________________________