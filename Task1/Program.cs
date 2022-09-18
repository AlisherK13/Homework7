// Найти произведение двух матриц

int[,] array1 = new int[5, 5];
int[,] array2 = new int[5, 5];
int[,] array3 = new int[5, 5];

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void MatrixProduct(int[,] matrix)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write($"{array3[i, j] = array1[i, j] * array2[i, j]} ");
        }
    }
}

FillArray(array1);
FillArray(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
MatrixProduct(array3);
