// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

int[] SumRowsMatrix(int[,] matrix)
{
    int[] SumRowsMat = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = default;
        int num;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            num = matrix[i, j];         
            sum += num;
        }
        SumRowsMat[i] = sum;
    }
    return SumRowsMat;
}

void PrintArray(int[] array)
{
    //Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (i < array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
        }
    }
    //Console.Write("] ");
}

int NumberSmall(int[] array)
{
    int min = array[0];
    int row = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            row = i+1;
        }

    }
    return row;
}


Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение минимум: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение максимум: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(m, n, k, l);
PrintMatrix(array2D);
Console.WriteLine(" ");

Console.Write("Суммы строк массива: ");
int[] sumRowsMatrix = SumRowsMatrix(array2D);
PrintArray(sumRowsMatrix);
Console.WriteLine(" ");

int numberSmall = NumberSmall(sumRowsMatrix);
Console.Write($"Cтрока с наименьшей суммой элементов: {numberSmall}");
