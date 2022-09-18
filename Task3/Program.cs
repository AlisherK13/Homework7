// Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента

int[,,] array = new int[2, 3, 4];

void FillArray(int[,,] matrix)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 4; k++)
            {
                matrix[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 4; k++)
            {
                Console.Write($"{matrix[i, j, k]}[{i}, {j}, {k}] ");
            }
        }
    }
}


FillArray(array);
PrintArray(array);