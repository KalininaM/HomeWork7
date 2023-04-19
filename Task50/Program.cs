/*Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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
            Console.Write(array[i,j]+" ");
        }
    Console.WriteLine();
    }
}

int ReadInt(string text)
{
    Console.WriteLine($"Введите номер {text}: ");
    return int.Parse(Console.ReadLine());
}

int rowIndex = ReadInt("строки") - 1;
int columnIndex = ReadInt("столбца") - 1;

int[,] array = CreateArray();

PrintArray(array);

//Поиск элемента в массиве по заданой позиции.
if (rowIndex < array.GetLength(0) && columnIndex < array.GetLength(1)) 
    Console.WriteLine($"[{rowIndex + 1}, {columnIndex + 1}] -> {array[rowIndex, columnIndex]}");
else Console.WriteLine($"[{rowIndex + 1}, {columnIndex + 1}] -> такого числа в массиве нет");



