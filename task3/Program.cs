//  Напишите программу, 
//  которая выводит третью цифру заданного числа 
//  или сообщает, что третьей цифры нет. 
//  Выполнить с помощью числовых операций
//   (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(77, 32680);
Console.WriteLine($"Случайное число 77 - 32680 -->{86}");

int firstDigit = number / 100; // 4
int secondDigit = number % 100; //56
int resaut = (secondDigit);
int threeDigit = resaut /10; //5
int fourDigit = resaut % 10; // 6

if (firstDigit < 100) Console.WriteLine($" --> {fourDigit}");

else Console.WriteLine("there is no third number");

