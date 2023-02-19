﻿int[,] A = CreateMatrixRndInt(2, 3, 0, 5);
int[,] B = CreateMatrixRndInt(2, 2, 0, 5);
PrintMatrix(A);
Console.WriteLine();
PrintMatrix(B);
Console.WriteLine();
int[,] multiplicationMatrix= MultiplicationMatrix(A,B);
if(СheckMatrix(A,B))
{
    PrintMatrix(MultiplicationMatrix(A,B));
}
else
{
    Console.WriteLine("Невозможно найти произведение матриц");
}

bool СheckMatrix(int[,] arrayA, int[,] arrayB)
{
       return arrayA.GetLength(0) == arrayB.GetLength(1);  
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}


int[,] MultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayA.GetLength(1)];
        for (int i = 0; i <arrayA.GetLength(0); i++)
        {
            for (int j = 0; j <arrayA.GetLength(1); j++)
            {
                for (int k = 0; k < arrayA.GetLength(1); k++)
                {
                    arrayC[i, j] = arrayA[i, k] * arrayB[k, j];
                }
            }
        }
return arrayC;
}

 int[,] NewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i, k] <matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}