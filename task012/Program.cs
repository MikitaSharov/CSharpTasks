/* Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/час.
Определить, через какое время автомобили встретятся, если расстояние между ними было S км. */

double v1 = new Random().NextDouble()*300;
double v2 = new Random().NextDouble()*300;
double S = new Random().NextDouble()*3000;

Console.WriteLine($"Cars will meet in {S/(v1+v2):N0} hours {(S*60/(v1+v2))%60:N0} minutes");