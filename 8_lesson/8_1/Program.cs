// Задача 1: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)        
            Console.Write($" {arr[i, j], 6} ");        
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)    
        for (int j = 0; j < column; j++)        
            arr[i, j] = Math.Round(n_new.NextDouble() * -10, 2);          
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

double[,] arr_1 = MassNums(row, column,
                           int.Parse(Console.ReadLine()),
                           int.Parse(Console.ReadLine()));
Print(arr_1);

void NewStr(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i=0; i<column; i++)
    (arr_1[0, i], arr_1 [row-1, i])  = (arr_1 [row-1, i], arr_1[0, i]); 
}

NewStr(arr_1);
Print(arr_1);