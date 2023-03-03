int GetNumber(string s)
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int GetBackNumber (int straightNumber)
{
    int backNumber = 0;
    while (straightNumber > 0)
    {
        backNumber = backNumber * 10 + straightNumber % 10;
        straightNumber = straightNumber / 10;
    }

    return backNumber;
}
bool Sravni(int number1, int number2)
{
    if (number1 == number2)
    {
       return true;
    }
    else
    {
        return false;
    }
}
string Outcome(bool resultSravni)
{
    if (resultSravni == true) {return "да";}
    else {
        return "нет";
        }
}
int number = GetNumber("Введите число: ");
int reserve = number;
int newNumber = GetBackNumber(number);
bool result = Sravni(reserve, newNumber);
string text = Outcome(result);
Console.WriteLine(text);



