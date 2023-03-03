Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
string result = String.Empty;
while (i <= N)
{
    result = result + i*i*i + ", ";
    i++;
}
Console.WriteLine(result);
