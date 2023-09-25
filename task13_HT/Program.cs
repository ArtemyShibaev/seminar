/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


// using System.Globalization;
// using Internal;

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());                 
    return num;
}

bool IsThreeDigit(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;   
    }
    return true;
}


int TherdDigit(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}


int userNumber = GetUserInput("Enter your number: ");
if (IsThreeDigit(userNumber))
{
    Console.WriteLine($"{userNumber} -> {TherdDigit(userNumber)}");
}




