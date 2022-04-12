/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
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

int[,] ProductOfArrays(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] productArray = new int[arrayOne.GetLength(0), arrayOne.GetLength(1)];
    if (arrayOne.GetLength(0) == arrayTwo.GetLength(0)
    && arrayOne.GetLength(1) == arrayTwo.GetLength(1))
    {
        for (int i = 0; i < arrayOne.GetLength(0); i++)
        {
            for (int j = 0; j < arrayOne.GetLength(1); j++)
            {
                productArray[i, j] = arrayOne[i, j] * arrayTwo[i, j];
            }
        }
    }
    return productArray;
}

int[,] arrayOne = Generate2DArray(3, 4, 10);
Print2DArray(arrayOne, "Первая матрица");

int[,] arrayTwo = Generate2DArray(3, 4, 10);
Print2DArray(arrayTwo, "Вторая матрица");

int[,] productArray = ProductOfArrays(arrayOne, arrayTwo);
Print2DArray(productArray, "Произведение двух матриц");

