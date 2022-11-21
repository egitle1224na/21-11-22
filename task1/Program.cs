// Задача 10: Напишите программу,
//  которая принимает на вход трёхзначное число 
//  и на выходе показывает вторую цифру этого числа. 
//  Выполнить с помощью числовых операций 
//  (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(455, 919);
int firstDigit = number / 100; // 4
int secondDigit = number % 100; //56
int resaut = (secondDigit);
int threeDigit = resaut /10; //5
int fourDigit = resaut % 10; // 6
Console.WriteLine($"{threeDigit}");
