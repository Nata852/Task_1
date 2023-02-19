int sentr2(int number)
{
    int  numberFirst = number /10;
    int resalt = numberFirst % 10;
    return resalt;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{sentr2(number)}");

