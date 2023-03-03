int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
string GetResult(int numb)
{
    int i = 1;
    string result = String.Empty;
    while (i <= numb)
    {
        result = result + i * i * i + ", ";
        i++;
    }
    return result;
}
int N = GetNumber("Введите число N: ");
Console.WriteLine(GetResult(N));

