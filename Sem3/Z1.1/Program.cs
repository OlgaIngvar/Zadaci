﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int reverseDigits(int num)
{
    int rev = 0;
    while (num > 0)
    {
        rev = rev * 10 + num % 10;
        num = num / 10;
    }
    return rev;
}
int number = InputInt("Введите число: ");
int reverse = reverseDigits(number);
if (number == reverse)
{
    System.Console.WriteLine("Палиндром");
}
else
{
    System.Console.WriteLine("Не палиндром");
}
if(number > 9999 && number < 10000)
{
    System.Console.WriteLine("Число не пятизначное");
}

