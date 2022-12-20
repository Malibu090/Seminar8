// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

// задать двумерный массив

const int leftRange = 0;
const int rightRange = 10;
// const int rows = 3;
// const int columns = 4;

// ввод размера массива
int rows = EnterNumber("Input number of rows: ");
int columns = EnterNumber("Input number of columns: ");

int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreateArrayWithRandomNumbers(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}


// вывести массив в консоль

void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// меняем первую и последнюю строчку массива

int[,] ReplacingStrings(int[,] matrix)
{
    int buffer;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        buffer = matrix[0, i];
        matrix[0, i] = matrix[rows - 1, i];
        matrix[rows - 1, i] = buffer;
    }
    return matrix;
}


// выводим массив 

int[,] matrix = CreateArrayWithRandomNumbers(rows, columns, leftRange, rightRange);

OutputArray(matrix);

ReplacingStrings(matrix);
System.Console.WriteLine();
OutputArray(matrix);