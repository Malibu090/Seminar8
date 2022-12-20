// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

const int leftRange = 0;
const int rightRange = 10;
const int rows = 5;
const int columns = 5;

// ввод размера массива
// int rows = EnterNumber("Input number of rows: ");
// int columns = EnterNumber("Input number of columns: ");

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

int[,] matrix = CreateArrayWithRandomNumbers(rows, columns, leftRange, rightRange);

OutputArray(matrix);

// int digit = 0;

// void FindCountNumber(int[,] matrix, out int count, int digit)
// {
//     {
//         count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (digit == matrix[i, j])
//                 {
//                     count++;
//                 }
//             }
//         }

//     }

// }

// FindCountNumber(matrix, out int count, digit);
// System.Console.WriteLine("Number 0 meets " + count + " times");

// digit = 1;
// FindCountNumber(matrix, out count, digit);
// System.Console.WriteLine("Number 1 meets " + count + " times");

// digit = 2;
// FindCountNumber(matrix, out count, digit);
// System.Console.WriteLine("Number 2 meets " + count + " times");

// digit = 3;
// FindCountNumber(matrix, out count, digit);
// System.Console.WriteLine("Number 3 meets " + count + " times");

// digit = 4;
// FindCountNumber(matrix, out count, digit);
// System.Console.WriteLine("Number 4 meets " + count + " times");

// digit = 5;
// FindCountNumber(matrix, out count, digit);
// System.Console.WriteLine("Number 5 meets " + count + " times");

// digit = 6;
// FindCountNumber(matrix, out count, digit);
// System.Console.WriteLine("Number 6 meets " + count + " times");

// digit = 7;
// FindCountNumber(matrix, out count, digit);
// System.Console.WriteLine("Number 7 meets " + count + " times");

// digit = 8;
// FindCountNumber(matrix, out count, digit);
// System.Console.WriteLine("Number 8 meets " + count + " times");

// digit = 9;
// FindCountNumber(matrix, out count, digit);
// System.Console.WriteLine("Number 9 meets " + count + " times");

void FindCountNumber(int[,] matrix)
{
    for (int number = 0; number < 10; number++)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                {
                    if (number == matrix[i, j])
                    {
                        count++;
                    }
                }    
            }
        }
        if (count > 0) System.Console.WriteLine(number + " meets " + count + " times");



    }
}

FindCountNumber(matrix);
