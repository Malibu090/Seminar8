// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя

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

int[,] ReplacingRowsWithColumns(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < i; j++)
        {
            int buffer;
            buffer = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = buffer;
        }
    }
    return matrix;
}



int[,] matrix = CreateArrayWithRandomNumbers(rows, columns, leftRange, rightRange);

if (rows != columns)
{
    Console.WriteLine("Сообщение для пользователя");
}
else
{
    OutputArray(matrix);
    ReplacingRowsWithColumns(matrix);
    Console.WriteLine();
    OutputArray(matrix);
}