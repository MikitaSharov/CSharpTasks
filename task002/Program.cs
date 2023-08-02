/*
Вывести на одной строке три числа от пользователя с одним пробелом между ними.
*/

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number1} {number2} {number3}");