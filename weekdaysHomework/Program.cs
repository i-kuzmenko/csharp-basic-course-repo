
Console.WriteLine("Hi, user. specify number from 1 to 7 and click enter to know a weekday.");
int.TryParse(Console.ReadLine(), out int dayNumber);

    switch (dayNumber)
    {
        case 1:
            Console.WriteLine("Weekday is Monday.");
            break;
        case 2:
            Console.WriteLine("Weekday is Tuesday.");
            break;
        case 3:
            Console.WriteLine("Weekday is Wednesday.");
            break;
        case 4:
            Console.WriteLine("Weekday is Thursday.");
            break;
        case 5:
            Console.WriteLine("Weekday is Friday.");
            break;
        case 6:
            Console.WriteLine("Weekday is Saturday.");
            break;
        case 7:
            Console.WriteLine("Weekday is Sunday");
            break;
        default:
            Console.WriteLine("Incorrect input.");
            break;

    }