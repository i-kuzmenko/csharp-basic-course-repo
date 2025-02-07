internal class Program
{
    static void Main(string[] args)
    {
        double firstNumber, secondNumber, result;
        char sign;
        try
        {
            Console.WriteLine("Hi, user. Please, enter first number.");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, enter second number.");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            if (secondNumber == 0)
            {
                Console.WriteLine("Error. Divider cannot be 0.");
                Console.WriteLine("Press any button to exit.");
                Console.ReadKey();
            }
            else if (secondNumber != 0)
            {
                result = firstNumber / secondNumber;
                Console.WriteLine("The result of your division is: " + result);
                Console.WriteLine("Press any button to exit.");
                Console.ReadKey();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("You entered incorrect value.");
        }
        
        
    }
}