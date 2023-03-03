using static Library;
int x1 = GetNumber("Введите значение x1: ");
int y1 = GetNumber("Введите значение y1: ");
int z1 = GetNumber("Введите значение z1: ");
int x2 = GetNumber("Введите значение x2: ");
int y2 = GetNumber("Введите значение y2: ");
int z2 = GetNumber("Введите значение z2: ");
double length = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
Console.WriteLine(length);