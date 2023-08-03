//Известны количество жителей в государстве и площадь его территории.
//Определить плотность населения в этом государстве.

int S = new Random().Next(1, 100);
int peoples = new Random().Next(1, 100);
float p = (float)peoples / S;
Console.WriteLine($"S = {S}, peoples = {peoples}, p = {p}");