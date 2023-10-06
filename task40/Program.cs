/* Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник со сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */

// A + B < (A + C) + (B + C)


int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


/* bool IsTriangle(int A, int B, int C)
{
    if ((A < B + C) && (B < A + C) && (C < A + B))
    {
        Console.WriteLine("Треугольник существет");
        return true;
    }
    Console.WriteLine("Треугольник НЕ существет");
    return false;
}

int userNumber1 = GetUserInput("Введите 1-ое число: ");
int userNumber2 = GetUserInput("Введите 2-ое число: ");
int userNumber3 = GetUserInput("Введите 3-е число: ");

bool result = IsTriangle(userNumber1, userNumber2, userNumber3); */



bool IsTriangle(int A, int B, int C)
{
    return (A < B + C) && (B < A + C) && (C < A + B);
}

int userNumber1 = GetUserInput("Введите 1-ое число: ");
int userNumber2 = GetUserInput("Введите 2-ое число: ");
int userNumber3 = GetUserInput("Введите 3-е число: ");

bool result = IsTriangle(userNumber1, userNumber2, userNumber3);

Console.WriteLine(result ? "Треугольник существет" : "Треугольник НЕ существет");