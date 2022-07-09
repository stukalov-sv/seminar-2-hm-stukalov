/*
Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет
*/

Console.WriteLine("Введите любое целое число:");

int number = Convert.ToInt32(Console.ReadLine());

string str = number.ToString();

int length = str.Length;

if(length > 2) Console.WriteLine($"{number} -> {str[2]}");
else Console.WriteLine($"{number} -> третьей цифры нет");