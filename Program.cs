Console.Write("Enter number from 1 to 7: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine($"Your day of the week is Monday");
        break;
    case 2:
        Console.WriteLine($"Your day of the week is Thuesday");
        break;
    case 3:
        Console.WriteLine($"Your day of the week is Wednesday");
        break;
    case 4:
        Console.WriteLine($"Your day of the week is Thursday");
        break;
    case 5:
        Console.WriteLine($"Your day of the week is Friday");
        break;
    case 6:
        Console.WriteLine($"Your day of the week is Saturday");
        break;
    case 7:
        Console.WriteLine($"Your day of the week is Sunday");
        break;
    default:
        Console.WriteLine($"Your {dayOfTheWeek} number incorrect");
        break;
}
