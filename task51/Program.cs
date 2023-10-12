/* адача 51: 
Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)               // Создание двумерного массива с рандомными числами
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}



void PrintMatrix(int[,] matrix)                                                       // Вывод массива в нужном виде
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");    // ,5 <- расстояние между значениями в массиве
        }
        Console.WriteLine("  ]");
    }

}


int SumOfDiagonalElem(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i,j];
            }
        }
    }
    return sum;
}


int[,] matrix = CreateMatrixRndInt(4, 2, 1, 9);
PrintMatrix(matrix);
Console.WriteLine(" ");

int sumOfDiagonalElem = SumOfDiagonalElem(matrix);
Console.WriteLine(sumOfDiagonalElem);