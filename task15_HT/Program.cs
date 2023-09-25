/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

using System.Reflection.Metadata;

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());                 
    return num;
}


bool From0To7(int num)
{
    return num > 0 && num < 8;
}


bool IsWeekend(int num)
{
    if (num != 6 && num != 7)
    {
        return false;
    }
    return true;
}


int userNumber = GetUserInput("Enter your number from 1 to 7: ");
//bool result = From0To7(userNumber);
//bool isWeekend = IsWeekend(userNumber);


if (From0To7(userNumber))
{
    if(IsWeekend(userNumber))
    {
        Console.WriteLine("ВЫХОДНОЙ!!!");
    }
    else
    {
        Console.WriteLine("Рабочий!!!");
    }
}








// bool IsWeekend(int num)
// {
//     if (num <= 6)
//     {
//         Console.WriteLine("нет");
//         return false;
//     }
//     return true;
// }


// int userNumber = GetUserInput("Введите цифру от 1 до 7: ");

// Console.WriteLine($"{userNumber} -> {IsWeekend(userNumber)}");
