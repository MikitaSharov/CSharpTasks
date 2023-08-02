/*
Составить программу:
 а) вычисления значения функции y=7x2+3x+6 при любом значении x;
 б) вычисления значения функции x=12a2+7a+12 при любом значении а.
 */

Console.Write("Enter number a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int x = 12 * numberA * numberA + 7 * numberA + 12;
int y = 7 * x * x + 3 * x + 6;
Console.Write($"x={x} y={y}");
