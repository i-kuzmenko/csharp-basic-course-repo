
internal class Program
{
    static void Main()
    {
        Console.Write("Enter the number of months: ");
        if (int.TryParse(Console.ReadLine(), out int months) && months > 0)
        {
            double totalSalary = 0;
            for (int i = 1; i <= months; i++)
            {
                Console.Write($"Enter salary for month {i}: ");
                if (double.TryParse(Console.ReadLine(), out double salary))
                {
                    totalSalary += salary;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid salary.");
                    i--; // Repeat the iteration for invalid input
                }
            }
            double averageSalary = totalSalary / months;
            Console.WriteLine($"The average monthly salary is: {averageSalary:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a positive number of months.");
        }
    }
}
