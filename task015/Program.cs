// Составить программу обмена значениями двух переменных величин.

string x = "a";
string y = "b";
string temp = x;
x = y;
y = temp;

Console.WriteLine($"x={x}, y={y}");