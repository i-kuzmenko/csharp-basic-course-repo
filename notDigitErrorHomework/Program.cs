
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine($"You entered: {number}");
        }
        else
        {
            Console.WriteLine("Error: Invalid input! Please enter a valid number.");
        }
    }
}
