
internal class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            if (IsValidPassword(password))
            {
                Console.WriteLine("Password is acceptable.");
                break;
            }
            else
            {
                Console.WriteLine("Password must be at least 8 characters long, contain at least one number, and at least one special character (!, @, #, etc.). Try again.");
            }
        }
    }

    static bool IsValidPassword(string password)
    {
        if (password.Length < 8)
            return false;

        bool hasNumber = password.Any(char.IsDigit);
        bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

        return hasNumber && hasSpecialChar;
    }
}
