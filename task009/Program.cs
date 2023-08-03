/*
Известна стоимость 1 кг конфет, печенья и яблок.
Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
*/

double cost_candies = new Random().NextDouble() * 10;
double cost_cookies = new Random().NextDouble() * 5;
double cost_apples = new Random().NextDouble() * 20;

Console.WriteLine($"cost candies = {cost_candies:N3}, cost cookies = {cost_cookies:N3}, cost apples = {cost_apples:N3}");

Console.Write("Enter candies: ");
double candies = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter cookies: ");
double cookies = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter apples: ");
double apples = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"candies = {candies:N3}, cookies = {cookies:N3}, apples = {apples:N3}");

Console.WriteLine($"Amount price: {cost_candies * candies + cost_cookies * cookies + cost_apples * apples:N3}");