// Задача 3: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

void Chet(int N)
	{
	   int i = 0;
	   double pere;
	   while (i < N )
	   {
	        i += 1;
	        if (i == (N))
	        {
	            pere = Math.Pow(i,3);
	            Console.Write($"{pere}");
	        }
	        else
	        {
	        
	        pere = Math.Pow(i,3);
	        Console.Write($"{pere},");
	        }
	   }    
	}
	Console.WriteLine("Введите число");
	int chislo = int.Parse(Console.ReadLine());
	Chet(chislo);
    Console.WriteLine();