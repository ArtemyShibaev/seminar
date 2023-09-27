// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void SquareNumbers (int num)
{
int count = 1;
while (count <= num) {
Console.WriteLine($"{count, 3} -> {count*count, 5}");
count++;
}
}


Console.WriteLine ("Digit input from user:");
int userNum = Convert.ToInt32(Console.ReadLine());
SquareNumbers(userNum);