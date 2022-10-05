/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int ferst = int.Parse(Console.ReadLine());
int second = (int)Math.Log10(ferst)-2;
Console.WriteLine(second < 0 ? "Третий цыфры нет" : (ferst % (int)Math.Pow(10, second + 1) / (int)Math.Pow(10, second)).ToString());
Console.ReadLine();