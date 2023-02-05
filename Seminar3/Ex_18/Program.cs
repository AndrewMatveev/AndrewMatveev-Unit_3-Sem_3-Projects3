// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).





// ____________РЕШЕНИЕ ЧЕРЕЗ ФОРМУЛУ_______________________________________


void Diapazon(int a) // формула определение принадлежности к диапазону
{
    if (a == 1)
    {
        System.Console.WriteLine("Диапазон x ∈ (0;+∞], y ∈ (0;+∞]");
    }
    else if (a == 2)
    {
        System.Console.WriteLine("Диапазон x ∈ (0;-∞], y ∈ (0;+∞]");
    }
    else if (a == 3)
    {
        System.Console.WriteLine("Диапазон x ∈ (0;-∞], y ∈ (0;-∞]");
    }
    else if (a == 4)
    {
        System.Console.WriteLine("Диапазон x ∈ (0;+∞], y ∈ (0;-∞]");
    }
    else
    {
        System.Console.WriteLine("Диапазон не существует");
    }
}


System.Console.Write("Введите четверть: ");
int x = Convert.ToInt32(Console.ReadLine());
Diapazon(x);