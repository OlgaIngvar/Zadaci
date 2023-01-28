// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> даn
System.Console.WriteLine("Ведите число");
int reverseDigits(int num);
    rev = 0;
    while (num > 0) {
        rev = rev * 10 + num % 10;
        num = num / 10;}
    return rev;

System.Console.WriteLine($"{rev} Полиндром");