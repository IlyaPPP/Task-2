/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int number;
Console.Write("Введите трехзначное число: ");
int.TryParse(Console.ReadLine()!, out number);

int result = number / 10 % 10;

Console.Write($"{number} -> {result}");