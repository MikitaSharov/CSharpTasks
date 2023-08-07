/* Дано двузначное число. Найти:
а) число десятков в нем;
б) число единиц в нем;
в) сумму его цифр;
г) произведение его цифр. */

int number = new Random().Next(10, 100);
Console.WriteLine($"In {number} {number / 10} tens and {number % 10} ones");
Console.WriteLine($"The sum of the digits of a number {number} = {number / 10 + number % 10}");
Console.WriteLine($"The multiplication of the digits of a number {number} = {number / 10 * (number % 10)}");