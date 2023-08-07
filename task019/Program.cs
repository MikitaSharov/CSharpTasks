// С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?

int days = new Random().Next(0, 1000);
int weeks = days / 7;
Console.WriteLine($"{days} days = {weeks} weeks");