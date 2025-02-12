
internal class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for the graph: ");
        if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
        {
            for (int i = 1; i <= rows; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a positive number.");
        }
    }
}
