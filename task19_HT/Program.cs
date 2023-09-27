/* Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False. */



//using Internal;

//using Internal;

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


bool IsFifthDigit(int num)
{
    if (num < 10000 || num > 99999)
    {
        Console.WriteLine("Число не пятизначное");
        return false;
    }
    return true;
}


int userNumber = GetUserInput("Введите 5-ти значное число: ");

int firstDigit = userNumber / 10000;
int secondDigit = userNumber / 1000 % 10;
int fourthDigit = userNumber / 10 % 10;
int fifthDigit = userNumber % 10;

if (IsFifthDigit(userNumber))
{
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine("Число палиндром");
    }
    else Console.WriteLine("Число НЕ палиндром");
}
