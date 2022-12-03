// Задача 2: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

float ReadNumber(string message)	
		{
		    Console.Write(message);
		    var s = Console.ReadLine();
		    float a = s == null ? 0 : float.Parse(s);
		    return a;
		}
		double Line3D(float x1, float y1, float z1, float x2, float y2, float z2)
		{
		    double result;
		    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
		    return result;
		}
		float x1 = ReadNumber("Введите x1:");
		float y1 = ReadNumber("Введите y1:");
        float z1 = ReadNumber("Введите z1:");
		float x2 = ReadNumber("Введите X2:");
		float y2 = ReadNumber("Введите y2:");
        float z2 = ReadNumber("Введите z2:");
	
		Console.WriteLine(Math.Round(Line3D(x1, y1, z1, x2, y2, z2), 2));