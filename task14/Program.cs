/* 
14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

//using Internal;

int GetUserInput(string str)
{
Console.Write($"{str}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

bool DivisionTo7And23(int num) 
{
    return num % 7 == 0 && num % 23 == 0;
}

int number = GetUserInput("Введите число: ");

bool result = DivisionTo7And23(number);
Console.WriteLine(result ? "да" : "нет");
