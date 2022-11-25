// Задача №1. Напишите программу, которая на вход
// принимает два числа и проверяет, является ли первое
// число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число 1");
	
		int num1 = int.Parse(Console.ReadLine());
	
		Console.WriteLine("Введите число 2");
	
		int num2 = int.Parse(Console.ReadLine());
	
		if(num2 == num1*num1)
	
		{
		    Console.WriteLine("да");
		}
	
		else 
		    Console.WriteLine("нет");



