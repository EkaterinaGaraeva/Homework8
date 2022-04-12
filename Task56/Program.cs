/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[] SumArray(int[,] incomingArray)
{
    int[] sumArray = new int[incomingArray.GetLength(0)];
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            sumArray[i] += incomingArray[i, j];
        }
    }
    return sumArray;
}

void PrintArray(int[] incomingArray)
{
    
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i != incomingArray.Length - 1)
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("------------------------------------");
}

int SmallestSum(int[] incomingArray)
{
    int min = incomingArray[0];
    int minIndex = 0;
    for (int i = 1; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] < min)
        {
            min = incomingArray[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int[,] array = Generate2DArray(4, 5, 10);
Print2DArray(array, "Изначальный массив");

int[] newArray = SumArray(array);
Console.Write("Сумма по строкам: ");
PrintArray(newArray);

int min = SmallestSum(newArray);
Console.WriteLine($"Строка наименьшей суммой элементов (нумерация строк с 0): {min}");
