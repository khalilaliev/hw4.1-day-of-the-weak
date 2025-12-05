Console.Write("Enter number from 1 to 7: ");
int dayOfTheWeak = Convert.ToInt32(Console.ReadLine());

if (dayOfTheWeak >= 1 && dayOfTheWeak <= 7)
{
    if (dayOfTheWeak == 1)
    {
        Console.WriteLine($"Your day of the weak is Monday");
    }
    if (dayOfTheWeak == 2)
    {
        Console.WriteLine($"Your day of the weak is Thuesday");
    }
    if (dayOfTheWeak == 3)
    {
        Console.WriteLine($"Your day of the weak is Wednesday");
    }
    if (dayOfTheWeak == 4)
    {
        Console.WriteLine($"Your day of the weak is Thursday");
    }
    if (dayOfTheWeak == 5)
    {
        Console.WriteLine($"Your day of the weak is Friday");
    }
    if (dayOfTheWeak == 6)
    {
        Console.WriteLine($"Your day of the weak is Saturday");
    }
    if (dayOfTheWeak == 7)
    {
        Console.WriteLine($"Your day of the weak is Sunday");
    }

}
else
{
    Console.WriteLine($"Your {dayOfTheWeak} number incorrect");

}