/*Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
Console.Clear();
int SetNumber(string numberName)
{
    Console.Write($"Введите значение {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

/*double SetNumberDouble(string numberName)
{
    Console.Write($"Введите значение {numberName}: ");
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}*/

double[,] GetMatrix(int rows, int colums)
{
    double[,] matrix = new double[rows, colums];

    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = random.NextDouble();
            matrix[i, j]= Math.Round(matrix[i, j], 2);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
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

int rows = SetNumber("rows");
int colums = SetNumber("columns");

double[,] matrix = GetMatrix(rows, colums);
PrintMatrix(matrix);