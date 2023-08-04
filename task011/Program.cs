/*
Возраст Тани — X лет, а возраст Мити — Y лет.
Найти их средний возраст, а также определить,
на сколько отличается возраст каждого ребенка от среднего значения.
*/

int ageT = new Random().Next(0, 50);
int ageM = new Random().Next(0, 50);
float ageAvg = (float)(ageT + ageM) / 2;

Console.WriteLine($"Average age of children: {ageAvg:N1} years");

/* if (ageT<ageAvg)
{
    Console.WriteLine($"Tanya is {ageAvg-ageT:N1} years younger than average");
    Console.WriteLine($"Mitya is {-ageAvg+ageM:N1} years older than average");
}
else
{
    Console.WriteLine($"Mitya is {-ageAvg+ageT:N1} years younger than average");
    Console.WriteLine($"Tanya is {ageAvg-ageM:N1} years older than average");
} */

if (ageT<ageM)
{
    Console.WriteLine($"The age of the children differs by {(ageM-ageT)/2} years from their average")
}
else
{
    Console.
}
