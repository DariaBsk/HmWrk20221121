// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц. 
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


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

int [,] MultMatr(int[,]mat1,int[,]mat2)
{
    int [,] multMatr = new int [mat1.GetLength(0),mat2.GetLength(1)];
       
    for (int i = 0; i < mat1.GetLength(0); i++)
    {
        for (int j = 0; j < mat2.GetLength(1); j++)
        {
             int sum = 0;
            for (int k = 0; k < mat1.GetLength(1); k++)
            {
               
                sum += mat1[i,k] * mat2[k,j];
            }
            multMatr[i,j] = sum;
        }
    }
    return multMatr;
}
           
                 
Console.WriteLine("Введите количество строк Матрицы 1: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов Матрицы 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение минимум Матрицы 1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение максимум Матрицы 1: ");
int l1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк Матрицы 2: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов Матрицы 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение минимум Матрицы 2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение максимум Матрицы 2: ");
int l2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateMatrixRndInt(m1, n1, k1, l1);
Console.WriteLine("Матрица 1: ");
PrintMatrix(matrix1);
int[,] matrix2 = CreateMatrixRndInt(m2, n2, k2, l2);
Console.WriteLine(" ");
Console.WriteLine("Матрица 2: ");
PrintMatrix(matrix2);

if (matrix1.GetLength(0) != matrix2.GetLength(1) && matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Матрицы перемножать нельзя");
        return;         
    }

Console.WriteLine(" ");

Console.WriteLine("Произведение Матриц: ");
int [,] productMatrices=MultMatr(matrix1, matrix2);
PrintMatrix(productMatrices);