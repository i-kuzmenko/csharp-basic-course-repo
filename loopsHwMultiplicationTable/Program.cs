
internal class Program
{
    static void Main()
    {
        Console.Write("Enter a number to generate its multiplication table: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine($"Multiplication Table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}