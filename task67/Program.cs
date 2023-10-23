/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */


Console.WriteLine("Введите натуральное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());



int SumOfDigits(int n)
{
    if (n == 0) return 0;
    return n % 10 + SumOfDigits(n / 10);
}


Console.WriteLine($" {userNumber} -> {SumOfDigits(userNumber)}");

