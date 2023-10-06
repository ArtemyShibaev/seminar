/* Задача 42: 
Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
46 -> 101110
13 -> 1101
2 -> 10 */



int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


string DecimalToBinary(int number)
{
    string result = String.Empty;
    while (number != 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}


int userNumber = GetUserInput("Введите число: ");
string res = DecimalToBinary(userNumber);
Console.WriteLine($"{userNumber} -> {res}");