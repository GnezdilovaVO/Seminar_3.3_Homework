public static class Library
{
    public static int GetNumber(string s)
    {
        Console.WriteLine(s);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int GetBackNumber(int straightNumber)
    {
        int backNumber = 0;
        while (straightNumber > 0)
        {
            backNumber = backNumber * 10 + straightNumber % 10;
            straightNumber = straightNumber / 10;
        }

        return backNumber;
    }
    public static bool Sravni(int number1, int number2)
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
    public static string Outcome(bool resultSravni)
    {
        if (resultSravni == true) 
        {   
            return "да";
        }
        else
        {
            return "нет";
        }
    }
}