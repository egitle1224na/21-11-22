// Задача 23

// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число  ->");
int number = Convert.ToInt32(Console.ReadLine());

void answer(int num)
{
    int num1 = 1;
    while (num1 <= num)
    {
        int square = num1 * num1 * num1;
        Console.WriteLine($"{num1, 4} {square}");
        num1++;
    }
}
if (number > 0)
 answer(number);
 else Console.WriteLine("Число не является натуральным");

