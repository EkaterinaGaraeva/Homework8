/*
Задача 62: Заполните спирально массив 4 на 4 (вариант 2)
*/

int[,] FillingArray(int side)
{
    int[,] array4x4 = new int[side, side];
    int number = 1;
    for (int i = side/2-1; i < side/2; i++)
    {
        for (int j = side/2-1; j < side/2+1; j++)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = side/2; i < side/2+1; i++)
    {
        for (int j = side/2; j < side/2+1; j++)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = side/2; i < side/2+1; i++)
    {
        for (int j = side/2-1; j > side/2-3; j--)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = side/2-1; i > side/2-3; i--)
    {
        for (int j = side/2-2; j > side/2-3; j--)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = side/2-2; i > side/2-3; i--)
    {
        for (int j = side/2-1; j < side/2+2; j++)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = side/2-1; i < side/2+2; i++)
    {
        for (int j = side/2+1; j < side/2+2; j++)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = side/2+1; i < side/2+2; i++)
    {
        for (int j = side/2; j > side/2-3; j--)
        {
            array4x4[i, j] = number++;
        }
    }
    return array4x4;
}

void PrintArray(int[,] incomingArray)
{
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            Console.Write($"{incomingArray[i, j]} ({i}, {j})\t");
        }
        Console.WriteLine();
    }
}

int[,] array = FillingArray(4);
PrintArray(array);

