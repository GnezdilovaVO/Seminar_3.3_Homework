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
int number = GetNumber("Введите число: ");
int reserve = number;
int newNumber = GetBackNumber(number);
if (reserve == newNumber)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

