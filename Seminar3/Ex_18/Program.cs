System.Console.WriteLine("Введите четверть");
int x = Convert.ToInt32(Console.ReadLine());
Diapazon(x);
void Diapazon(int a)
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

// дорешать