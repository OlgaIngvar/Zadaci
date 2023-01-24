// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число"); //запрос у юзера числа, сохранение в пер.
string? valueString = Console.ReadLine();
int number = Convert.ToInt32(valueString); //перевод числа в int
int remainder = number % 2; //получается ли остаток после деления на 2
string NumberType = "нечетное";
if (remainder == 0)
{ //если остаток = 0, то значение четное
    NumberType = "четное";
}
System.Console.WriteLine($"Число {NumberType}"); // вывод - четное или нет