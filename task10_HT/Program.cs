/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */


//using Internal;

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());                  // Запрос на ввод числа
    return num;
}


bool IsThreeDigit(int num)
{
    return num > 99 && num < 1000;                               // проверка на трехзначность
}

int SecondDigit(int num)
{
    int secondDigit = num / 10 % 10;                               // нахождение второй цифры в трехзначном числе
    return secondDigit;
}


int userNumber = GetUserInput("Enter your number: ");
bool isThreeDigit = IsThreeDigit(userNumber);

if (isThreeDigit)
{
    int result = SecondDigit(userNumber);
    Console.WriteLine($"{userNumber} ->  {result}");
}
else
{
    Console.WriteLine("Ошибка ввода!");
}









