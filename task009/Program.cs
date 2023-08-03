/*
Известна стоимость 1 кг конфет, печенья и яблок.
Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
*/

double cost_candies = new Random().NextDouble() * 10;
double cost_cookies = new Random().NextDouble() * 5;
double cost_apples = new Random().NextDouble() * 20;
double candies = new Random().NextDouble();
double cookies = new Random().NextDouble();
double apples = new Random().NextDouble();

Console.WriteLine($"cost candies = {cost_candies:N3}, cost cookies = {cost_cookies:N3}, cost apples = {cost_apples:N3}");
Console.WriteLine($"candies = {candies:N3}, cookies = {cookies:N3}, apples = {apples:N3}");

Console.WriteLine($"Amount = {cost_candies * candies + cost_cookies * cookies + cost_apples * apples:N3}");