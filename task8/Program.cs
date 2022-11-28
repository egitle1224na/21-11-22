// Задача 27: Напишите программу, 
// 1. которая принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int num)
{
    int sum = 0; 
    for (int i = 0; i <= num;  i++)
       
    {
        sum += i;
    }
     return sum;
}
if (number > 0 )
{
int sumNumbtrs = SumNumbers(number);
Console.WriteLine($"{number} -> {SumNumbers(number)}");
}
else Console.WriteLine("Введите натуральное число");
