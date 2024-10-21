using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        // Call the Divide method to handle conversion and division
        Divide(input1, input2);
    }

    static void Divide(string strNum1, string strNum2)
    {
        try
        {
            // Convert the strings to integers
            int num1 = Convert.ToInt32(strNum1);
            int num2 = Convert.ToInt32(strNum2);

            // Perform the division
            int result = num1 / num2;

            // Print the result if successful
            Console.WriteLine($"Result: {num1} / {num2} = {result}");
        }
        catch (FormatException)
        {
            // Handle invalid format for conversion
            Console.WriteLine("Error: Please enter valid numbers.");
        }
        catch (DivideByZeroException)
        {
            // Handle division by zero
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (OverflowException)
        {
            // Handle cases where the number is too large
            Console.WriteLine("Error: The number is too large or too small for an Int32.");
        }
        catch (Exception ex)
        {
            // Catch any other unexpected exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}
