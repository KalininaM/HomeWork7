/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Двумерный массив из целых чисел.:");
int[,] array = CreateArray();
PrintArray(array);
AverageColumns(array);

//Создание и заполнение массива.
int [,] CreateArray ()
{
    int [,] array = new int [3, 4];
    Random randomValue = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = randomValue.Next(0, 20);
        }
    }
    return array;
}

//Вывод массива на экран.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
    Console.WriteLine();
    }
}

//Вычисление среднее арифметическое элементов в каждом столбце.
void AverageColumns(int[,] array)
{
    double averageColumns = 0;
    int sumValueColumns = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sumValueColumns = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumValueColumns += array[j,i];
        }
        averageColumns = (double) sumValueColumns / array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца = {Math.Round(averageColumns, 2)}");
    }
}