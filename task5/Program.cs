// Напишите программу, которая 
// принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Введите коордитанты точки ->");
Console.WriteLine("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int y1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("z: ");
int z1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine ("Введите коордитанты точки ->");
Console.WriteLine("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int y2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("z: ");
int z2 = Convert.ToInt32(Console.ReadLine()); 

double Lange(int xa, int ya, int xb, int yb, int xc, int yc)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
}

double res = Math.Round(Lange(x1, y1, x2, y2, z1, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(res); 