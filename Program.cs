/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int number;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out number);
string str = number.ToString();

if (number > 99)
    Console.Write($"{number} -> {str[2]}");
else
    Console.Write("Третьей цифры нет");