/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

int[,] Generate2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] arrayToReturn = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            arrayToReturn[i, j] = new Random().Next(-deviation, deviation);
        }
    }
    return arrayToReturn;
}

void Print2DArray(int[,] incomingArray, string arrayName)
{
    Console.WriteLine($"{arrayName}");
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            Console.Write($"{incomingArray[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("------------------------------------");
}

int[,] Ordering2DArray(int[,] incomingArray)
{
    int max;
    int rows = incomingArray.GetLength(0);
    int colomns = incomingArray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            for (int k = j+1; k < colomns; k++)
            {
                if (incomingArray[i, k] > incomingArray[i, j])
                {
                    max = incomingArray[i, k];
                    incomingArray[i, k] = incomingArray[i, j];
                    incomingArray[i, j] = max;
                }
            }
        }
    }
    return incomingArray;
}


int[,] array = Generate2DArray(5, 5, 10);
Print2DArray(array, "Изначальный массив");

int[,] ordered2DArray = Ordering2DArray(array);
Print2DArray(array, "Отсортированный массив");
