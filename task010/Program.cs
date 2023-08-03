/*
Известна стоимость монитора, системного блока, клавиатуры и мыши.
Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?
*/

double monitor = new Random().NextDouble() * 10;
double box = new Random().NextDouble() * 10;
double keyboard = new Random().NextDouble() * 10;
double mouse = new Random().NextDouble() * 10;

Console.Write("How much PC you want: ");
int qtyPC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{qtyPC} PC will be cost: {qtyPC * (monitor + box + keyboard + mouse):N3}");