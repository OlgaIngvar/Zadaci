/* Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные 
числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/

void EvenNambers(int m, int n)
{
    if (m <= n)
    {
        if (m % 2 == 0 & m != 0)
        {
        System.Console.Write($"{m}\t");
        }
        EvenNambers(m + 1, n);
    }
}
System.Console.WriteLine(EvenNambers(4, 8));

