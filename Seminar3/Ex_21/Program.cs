// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double DotsDistance(double ax, double ay, double bx, double by)
{
    double Distance = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
    Console.WriteLine("Расстояние между точками на плоскости: " + Distance);
    return Distance;
} 



System.Console.Write("Введите координаты по X точки А: ");
int ax = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите координаты по Y точки А: ");
int ay = Convert.ToInt32(System.Console.ReadLine());


System.Console.Write("Введите координаты по X точки B: ");
int bx = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите координаты по Y точки B: ");
int by = Convert.ToInt32(System.Console.ReadLine());

DotsDistance(ax, ay, bx, by);