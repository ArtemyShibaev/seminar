/* Задача 27: Напишите программу, 
которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


//using Internal;

//using Internal;

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}


int userNumber = GetUserInput("Введите число: ");
int sumOfDigits = SumOfDigits(userNumber);
Console.WriteLine($"{userNumber} -> {sumOfDigits}");


