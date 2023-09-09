/*Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Clear();
int SetNumber(string numberName)
{
    Console.Write($"Введите значение {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int colums, int mixValue, int maxValue)
{
    int[,] matrix = new int[rows, colums];

    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = random.Next(mixValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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
void FindNum(int[,] array, int find)
{
    int count = 0;
    string r = "Такой позиции в массиве нет";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            count = count + 1;
            if (count == find)
            r = "Такая позиция в массиве есть";
        }
    }
    Console.WriteLine($"{find} -> {r}");
}

int rows = SetNumber("rows");
int colums = SetNumber("columns");
int minValue = SetNumber("min");
int maxValue = SetNumber("max");
int find = SetNumber("позиции, которое надо найти в массиве");

int[,] matrix = GetMatrix(rows, colums, minValue, maxValue);
PrintMatrix(matrix);
Console.WriteLine();
FindNum(matrix, find);