/* Возраст Тани — X лет, а возраст Мити — Y лет.
Найти их средний возраст, а также определить,
на сколько отличается возраст каждого ребенка от среднего значения. */

int ageT = new Random().Next(0, 50);
int ageM = new Random().Next(0, 50);

Console.WriteLine($"average age of children {(float)(ageT + ageM) / 2} years");
if (ageM > ageT)
    Console.WriteLine($"children's age differs from their average by {(float)(ageM - ageT) / 2} years");
else Console.WriteLine($"children's age differs from their average by {(float)(ageT - ageM) / 2} years");