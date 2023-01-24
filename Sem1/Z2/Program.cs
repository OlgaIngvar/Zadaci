// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
System.Console.WriteLine("Введите первое число"); //запрос у юзера первого числа, сохранение в пер.1
string? valueString1 = Console.ReadLine();
System.Console.WriteLine("Введите второе число"); //запрос у юзера второго числа, сохранение в пер.2
string? valueString2 = Console.ReadLine();
System.Console.WriteLine("Введите третье число"); //запрос у юзера третьего числа, сохранение в пер.3
string valueString3 = Console.ReadLine();
int value1 = Convert.ToInt32(valueString1);//перевод трех чисел в int
int value2 = Convert.ToInt32(valueString2);
int value3 = Convert.ToInt32(valueString3);
int Max = value1; //создание пер. Max, присвоение ей значения пер. 1
if (value2 > Max){ //если значение пер. 2 >, чем Max, то запись в Max пер. 2
    Max = value2;
}
if (value3 > Max){ //если значение пер. 3 >, чем Max, то запись в Max пер. 3
    Max = value3;
}
System.Console.WriteLine($"Max = {Max}"); // вывод Max