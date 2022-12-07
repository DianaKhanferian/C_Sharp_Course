// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int NumbCount(int num)
	{
        if (n==0)
        {
            return (1); 
        }
	    int count = 0;
	    while (num > 0)
	    {
	        num = num / 10;
	        count++;
	        return count;
	    }
	}
	
	Console.Write("Введите число: ");
	
	Console.WriteLine(NumbCount(int.Parse(Console.ReadLine())));