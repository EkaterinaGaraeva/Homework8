/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
*/

int[,,] Generate3DArray(int width, int height, int depth)
{
    int[,,] array3D = new int[depth, height, width];
    int number = 10;
    for (int i = 0; i < depth; i++)
    {
        for (int j = 0; j < height; j++)
        {
            for (int k = 0; k < width; k++)
            {
                array3D[i, j, k] = number++;
            }
        }
    }
    return array3D;
}

void Print3DArray(int[,,] incomingArray)
{
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            for (int k = 0; k < incomingArray.GetLength(2); k++)
            {
                Console.Write($"{incomingArray[i, j, k]} ({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("----------------------------------------------------------------------------");
    }
}

int[,,] array = Generate3DArray(5, 4, 3);
Print3DArray(array);
