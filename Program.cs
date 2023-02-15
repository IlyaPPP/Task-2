/* Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int number;
Console.Write("Введите цифру, обозначающую день недели от 1 до 7: ");
int.TryParse(Console.ReadLine()!, out number);
if (number == 6 || number == 7)
    Console.Write("Выходной");
else if (number <= 5 && number >= 1)
    Console.Write("Не выходной");
else
    Console.Write("Нет такого дня недели");