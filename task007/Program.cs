//Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности.

Console.WriteLine("Enter length: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"V = {length * length * length}");
Console.WriteLine($"S = {length * length}");