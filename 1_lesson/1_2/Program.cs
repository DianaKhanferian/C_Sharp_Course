﻿// // Задача №2. Напишите программу, которая будет
// выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.WriteLine("Введите число");
	int y = int.Parse(Console.ReadLine());
	if ( y == 1) 
	{
	    Console.WriteLine("Понедельник");
	}
	else if (y == 2)
	{
	    Console.WriteLine("Вторник");
	}
	else if (y == 3)
	{
	    Console.WriteLine("Среда");
	}
	else if (y == 4)
	{
	    Console.WriteLine("Четверг");
	}
	else if (y == 5)
	{
	    Console.WriteLine("Пятница");
	}
	else if (y == 6)
	{
	    Console.WriteLine("Суббота");
	}
	else if (y == 7)
	{
	    Console.WriteLine("Воскресенье");
	}
	else
	{
	    Console.WriteLine("error");
	}
