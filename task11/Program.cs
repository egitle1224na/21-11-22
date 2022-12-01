// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayDouble(int size, int min, int max) 
{

    double[] array = new double[size];
    Random rnd = new Random();
    
    for (int i = 0; i < size; i++)
    {
        double maximal = array[i];
        double num = rnd.NextDouble() *(max - min);
        array[i] = Math.Round(num, 1 );
        if (maximal < array[i - 1]) maximal = array[i - 1] ;
        else maximal = array[i];
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i += 1)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine("1. размер; 2. мин. число; 3. макс. число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
double[] print = CreateArrayDouble(num1, num2, num3);
PrintArray(print);