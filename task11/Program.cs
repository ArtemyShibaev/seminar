/* 11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98 */

//using System;

int DeleteSecondDigit(int num)
{
int firstDigit = num / 100; 
int therdDigit = num % 10;
return firstDigit * 10 + therdDigit;
}

int number = new Random().Next(100,1000);
Console.WriteLine(number);
Console.WriteLine(DeleteSecondDigit(number));