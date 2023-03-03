public static class Library
{
    public static int GetNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static string GetResult(int numb)
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
}