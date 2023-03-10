/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int PromptInt(string message)
{
    System.Console.Write($"{message} : ");
    return Convert.ToInt32(Console.ReadLine());
}
double[,] CreationRandomMatrix(
    int rows,
    int columns,
    double minVal = 0,
    double maxVal = 10)
{
    double[,] result = new double[rows, columns];
    double B = maxVal - minVal;
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = minVal + B * rnd.NextDouble();
        }
    }
    return result;
}
void PrintMatrixDouble(//F округления
    double[,] matrix,
    int numberRound = 2)    //сколько цифр после запятой 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{Math.Round(matrix[i, j], numberRound)} ");
        }
        System.Console.WriteLine();
    }
}
int m = PromptInt("Введите число строк");
int n = PromptInt("Введите число столбцов");
if (m < 1){ System.Console.WriteLine($"Некорректное число строк: {m}"); return; }
if (n < 1){ System.Console.WriteLine($"Некорректное число столбцов: {n}"); return; }

PrintMatrixDouble(CreationRandomMatrix(m, n));
