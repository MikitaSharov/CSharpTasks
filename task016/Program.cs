/* Cоставить программу обмена значениями трех переменных величин а, b, c по
следующим двум схемам: 
    а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
    б) b присвоить значение а, с присвоить значение b, а присвоить значение с. */

int a = new Random().Next(-10, 10);
int b = new Random().Next(-10, 10);
int c = new Random().Next(-10, 10);

Console.WriteLine($"a = {a}, b = {b}, c = {c}");

char choice = Convert.ToChar("0");
int number_choice = 0;

while (number_choice == 0)
{
    Console.WriteLine("Для выбора схемы нажмите на клавиатуре a или b");
    choice = Console.ReadKey(true).KeyChar;
    if (choice == Convert.ToChar("a")) number_choice = 1;
    else if (choice == Convert.ToChar("b")) number_choice = 2;
    else Console.WriteLine("Неверный ввод");
}
int temp = 0;
if (number_choice == 1)
{
    temp = b;
    b = c;
    c = a;
    a = temp;
}
else if (number_choice == 2)
{
    temp = b;
    b = a;
    a = c;
    c = temp;
}
Console.WriteLine($"a = {a}, b = {b}, c = {c}");
