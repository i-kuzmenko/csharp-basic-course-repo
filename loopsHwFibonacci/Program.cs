
internal class Program
{
    static void Main()
    {
        Console.Write("Enter the number of Fibonacci numbers to generate: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            long first = 0, second = 1, next;
            Console.WriteLine("Fibonacci Sequence:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(first + " ");
                next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a positive number.");
        }
    }
}