/* Дано вещественное число а. Пользуясь только операцией умножения, получить:
а) a4 за две операции;
б) a6  за три операции;
в) a7 за четыре операции;
г) a8  за три операции;
д) a9 за четыре операции;
е) a10  за четыре операции. */

// double a = -10 + new Random().NextDouble() * 20;

double a = 2;
double a2 = a * a;
double a4 = a2 * a2;
double a6 = a2 * a2 * a2;
double a7 = a2 * a2 * a2 * a;
double a8 = a4 * a4;
double a9 = a4 * a4 * a;
double a10 = a4 * a4 * a2;

Console.WriteLine($"a4 = {a4}");
Console.WriteLine($"a6 = {a6}");
Console.WriteLine($"a7 = {a7}");
Console.WriteLine($"a8 = {a8}");
Console.WriteLine($"a9 = {a9}");
Console.WriteLine($"a10 = {a10}");