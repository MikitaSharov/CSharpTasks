// Дано расстояние в сантиметрах. Найти число полных метров в нем.

int santi = new Random().Next(0, 1000);

if (santi >= 100) Console.WriteLine($"{santi} cm = {santi / 100} meter(s)");
else Console.WriteLine($"{santi} cm = 0 meters");