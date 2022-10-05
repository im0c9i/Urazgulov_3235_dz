 /*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
System.Console.WriteLine("Введите день недели");
string DayOfTheWeek = Console.ReadLine();
if (DayOfTheWeek == "1")
    Console.Write(" 1 -> не выходной");
else if(DayOfTheWeek == "2")
    Console.Write("2 -> не выходной");
else if (DayOfTheWeek == "3")
    Console.Write("3 -> не выходной");
else  if(DayOfTheWeek == "4")
    Console.Write("4 -> не выходной");
else if(DayOfTheWeek == "5")
    Console.Write("5 -> не выходной");
else if(DayOfTheWeek == "6")
    Console.Write("6 -> Выходной");
else if(DayOfTheWeek == "7")
    Console.Write("7 -> Выходной");
else
Console.WriteLine("Вы ввели неверный днь недели");
