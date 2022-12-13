// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}
void SelectionSort(int[,] matrix)
{
     int[,] array = new int[i, j];
     Random rnd = new Random();
        for (int i = 0; i < array.Length - 1; i++)
        {
             int maxPosition = i;
            for (int j = i + 1; j < array.Length; j ++)
            {
                if (array[j, i] < maxPosition)
                {
                    maxPosition = j;
                }
            }
            int temporary=array[i,i];
            array[i,i]=maxPosition;
            maxPosition=temporary;
        }

}
 int[,] array = CreateMatrixRndInt(4, 3, 1, 10);
 PrintMatrix(array);

 int [,] resultMatrix = SelectionSort(new);
 Console.WriteLine();
 PrintMatrix(resultMatrix);

