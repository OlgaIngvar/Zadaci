//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Введите последнее число"); //запрос у юзера конечного числа, сохранение в пер.
string? valueString = Console.ReadLine();
int N = Convert.ToInt32(valueString); //перевод числа в int
string Numbers = ""; //проверка чисел от 1 до N, если четное, то добавляем к строке 
int count = 2;
string separator = "";
while(count <= N){
    if (count > 2){
    separator = ", ";
    }
    Numbers = Numbers + separator + count;
    count +=2;
}
System.Console.WriteLine($"Четные числа: {Numbers}"); // вывод всех четных чисел в заданном числе