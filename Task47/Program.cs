/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double [,] CreateArray (int line, int column)
{
    double [,] array = new double [line, column];
    Random randomValue = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(randomValue.NextDouble() * 100 , 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    Console.WriteLine();
    }
}

int ReadInt(string text)
{
    Console.WriteLine($"Введите количество {text}: ");
    return int.Parse(Console.ReadLine());
}

int arraySizeLine = ReadInt("строк");
int arraySizeColumn = ReadInt("столбцов");
PrintArray(CreateArray(arraySizeLine, arraySizeColumn));
