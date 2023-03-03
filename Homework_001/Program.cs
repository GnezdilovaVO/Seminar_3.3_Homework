using static Library;
int number = GetNumber("Введите число: ");
int reserve = number;
int newNumber = GetBackNumber(number);
bool result = Sravni(reserve, newNumber);
Console.WriteLine(Outcome(result));



