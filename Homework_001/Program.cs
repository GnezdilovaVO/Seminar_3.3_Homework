Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = 0;
int reserve = number;
while (number > 0)
{   
    newNumber = newNumber*10 + number%10;
    number = number/10;
}
if (reserve == newNumber) 
{
     Console.WriteLine("да");
}
else
{
   Console.WriteLine("нет");
}
