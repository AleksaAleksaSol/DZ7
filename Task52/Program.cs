/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

double[] GetArrithmeticMean(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
       for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
            result[j] = Math.Round(sum / arr.GetLength(0), 2);
        }

    }
    Console.WriteLine($"Среднее арифметическое  столбцов");
    return result;
}

void PrintArray(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",  ");
        else Console.Write(arr[i] + "]\n");
    }
}
Console.WriteLine();

int rows = SetNumber("rows");
int colums = SetNumber("columns");
int minValue = SetNumber("min");
int maxValue = SetNumber("max");

int[,] matrix = GetMatrix(rows, colums, minValue, maxValue);
PrintMatrix(matrix);

Console.WriteLine();

double[] getArrithmeticMean = GetArrithmeticMean(matrix);
PrintArray(getArrithmeticMean);