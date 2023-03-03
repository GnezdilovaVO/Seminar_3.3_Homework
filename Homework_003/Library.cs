public static class Library
{
    public static int GetNumber(string s)
    {
        Console.WriteLine(s);
        return Convert.ToInt32(Console.ReadLine());
    }
}