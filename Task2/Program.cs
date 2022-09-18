// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.WriteLine("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int a = 0;
int b = 0;

int[,] array = new int[m, n];

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

void FindMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < matrix[a, b])
            {
                a = i;
                b = j;
            }
        }
    }
}

int[,] array2 = new int[m-1, n-1];

void NewArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(a <= i) a = i + 1;
        else a = i;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(b <= j) b = j + 1;
            else b = j;
            array2[i, j] = array[a, b];
            Console.Write($"{array2[i, j]} ");
        }
    }
}


FillArray(array);
PrintArray(array);
FindMin(array);
Console.WriteLine();
NewArray(array2);