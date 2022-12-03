// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


Console.WriteLine("0, 7, 8, -2, -2 ");
Convert.ToInt32(Console.ReadLine());


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    } 
     Console.WriteLine("]");
}

void SumIndexArray(int[] array)
{
    int i = new int ();
    int sum = 0;
    while (i >= 0);
    {
        sum = i++;
        sum++;
    }
    return;
}


Console.WriteLine("0, 7, 8, -2, -2 ");
return;
