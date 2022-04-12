/*
Задача 62: Заполните спирально массив 4 на 4
*/

int[,] FillingArray(int width, int height)
{
    int[,] array4x4 = new int[width, height];
    int number = 1;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = 1; i < 4; i++)
    {
        for (int j = 3; j < 4; j++)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = 3; i >= 3; i--)
    {
        for (int j = 2; j >= 0; j--)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = 2; i >= 1; i--)
    {
        for (int j = 0; j <= 0; j++)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = 1; i < 2; i++)
    {
        for (int j = 1; j < 3; j++)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = 2; i < 3; i++)
    {
        for (int j = 2; j < 3; j++)
        {
            array4x4[i, j] = number++;
        }
    }
    for (int i = 2; i < 3; i++)
    {
        for (int j = 1; j >= 1; j--)
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

int[,] array = FillingArray(4, 4);
PrintArray(array);
