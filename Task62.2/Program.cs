/*
Задача 62: Заполните спирально массив 4 на 4 
(вариант 3 - заполняет по спирали квадратный массив с четной стороной)
*/

int[,] FillingArray(int side)
{
    int[,] array4x4 = new int[side, side];
    int number = 1;
    for (int k = 0; k < side / 2; k++)
    {
        for (int i = side / 2 - k - 1; i < side / 2 - k; i++) // верх
        {
            for (int j = side / 2 - k - 1; j < side / 2 + k + 1; j++)
            {
                array4x4[i, j] = number++;
            }
        }

        for (int i = side / 2 - k; i < side / 2 + k + 1; i++) // право
        {
            for (int j = side / 2 + k; j < side / 2 + 1 + k; j++)
            {
                array4x4[i, j] = number++;
            }
        }

        for (int i = side / 2 + k; i < side / 2 + 1 + k; i++) // низ
        {
            for (int j = side / 2 - 1 + k; j > side / 2 - 2 - k; j--)
            {
                array4x4[i, j] = number++;
            }
        }

        if (k == side / 2 - 1)
        {
            break;
        }
        else
        {
            for (int i = side / 2 + k; i > side / 2 - 2 - k; i--) // лево
            {
                for (int j = side / 2 - 2 - k; j > side / 2 - 3 - k; j--)
                {
                    array4x4[i, j] = number++;
                }
            }
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
