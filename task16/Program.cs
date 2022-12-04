// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(double rows, double columns, double min, double max)

{
   double[,]  = InvalidTimeZoneException.ReferenceEquals;
   double[,] matrix = new double[rows,columns]; //0, 1
   int rows = Convert.ToInt32(Console.ReadLine());
   Random rnd = new Random();
   int columns = Convert.ToInt32(Console.ReadLine());
   
   for (double i = 0; i < matrix.GetLength(0); i++)
   {
    for (double j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(min, max + 1);
    }
   }
   return matrix; 
}
void PrintMatrix(double[,] matrix)
{
    for (double i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (double j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix},");
            else Console.Write($"{matrix}");
        }
        Console.Write("]");
    }
}

double[,] array2D = CreateMatrixRndDouble(3, 4, -1, 9);
PrintMatrix(array2D);
