// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
System.Console.WriteLine("Введите первое число"); //запрос у юзера первого числа, сохранение в пер.1
string? valueString1 = Console.ReadLine();
System.Console.WriteLine("Введите второе число"); //запрос у юзера второго числа, сохранение в пер.2
string? valueString2 = Console.ReadLine();
int value1 = Convert.ToInt32(valueString1);//перевод обоих чисел в int
int value2 = Convert.ToInt32(valueString2);
//сравнение значений в двух пер. 
//если  1 >, вывод: Max - пер. 1, Min - пер. 2
//иначе 2 >, вывод: Max - пер. 2, Min - пер. 1
if (value1 > value2){
    System.Console.WriteLine($"Max = {value1} Min = {value2}");
}
else {
    System.Console.WriteLine($"Max = {value2} Min = {value1}");
}