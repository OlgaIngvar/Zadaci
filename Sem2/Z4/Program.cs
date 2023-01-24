// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.
int RandomInt()
{    
    Random rnd = new Random();
    return rnd.Next(100, 1000);
}
int number = RandomInt();
int rank1 = number % 10;
int rank2 = number / 100;
int result = rank2 * 10 + rank1;
System.Console.WriteLine($"Изначальное число {number}, результат {result} ");