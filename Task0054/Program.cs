// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

int[,] SortColumnsMatrixDescend(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int t = j + 1; t < matrix.GetLength(1); t++)
            {
                if (matrix[i, j] < matrix[i, t])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, t];
                    matrix[i, t] = temp;
                }   
            }         
        }
    }
    return matrix;
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

Console.WriteLine("Расположим элементы на каждой строке по убыванию: ");
int[,] sortarray = SortColumnsMatrixDescend(array2D);
PrintMatrix(sortarray);
Console.WriteLine(" ");

