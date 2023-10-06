/* Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */


double[] CreateArrayRndDouble(int size, int min, int max)               // Создание одномерного ВЕЩЕСТВЕННОГО массива с рандомными числами
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}


void PrintArray(double[] arr)                                       // Вывод массива в нужном виде
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}; ");    //F1 - округление до одного знака
        else Console.Write($"{arr[i]:F1}");
    }
    Console.WriteLine("]");
}


double MaxElemInArray(double[] arr)
{
    double maxElem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElem) maxElem = arr[i];
    }
    return maxElem;
}


double MinElemInArray(double[] arr)
{
    double minElem = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (minElem > arr[i]) minElem = arr[i];
    }
    return minElem;
}


double[] arr = CreateArrayRndDouble(5, 1, 9);
PrintArray(arr);

double maxElement = MaxElemInArray(arr);
double minElement = MinElemInArray(arr);
double difMaxMin = maxElement - minElement;

Console.WriteLine($" max element -> {maxElement:F1}");
Console.WriteLine($" min element -> {minElement:F1}");

Console.WriteLine($"разница между {maxElement:F1} и {minElement:F1} массива = {difMaxMin:F1}");