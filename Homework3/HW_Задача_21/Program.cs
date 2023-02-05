// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// Например:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// ____________________________РЕШЕНИЕ ЧЕРЕЗ МАССИВ С ФОРМУЛАМИ:___________________________________________

double DotsDistance(double[] A, double[] B)
{
    double Distance
    =
    Math.Sqrt
    (
        Math.Pow((B[0] - A[0]), 2)
        +
        Math.Pow((B[1] - A[1]), 2)
        +
        Math.Pow((B[2] - A[2]), 2)
    );
return Distance;
}

System.Console.Write("Последовательно введите коорданаты (X,Y,Z) первой точки через запятую: ");
double[] FirstDot = Console.ReadLine().Split(",").Select(double.Parse).ToArray();

System.Console.Write("Последовательно введите коорданаты (X,Y,Z) второй точки через запятую: ");
// double[] SecondDot = Console.ReadLine().Split(",").Select(double.Parse).ToArray();

double[] SecondDot = Console.ReadLine().Split(",").Select(double.Parse).ToArray();

System.Console.WriteLine("Расстояние между двумя точками в пространстве: " + DotsDistance(FirstDot, SecondDot));

// __________________________________________________________________________________________________________