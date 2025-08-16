int operation = 0;
int firstNumber = 0;
int secondNumber = 0;


while (operation != -1)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Sample Calculator Console Application!");
        Console.WriteLine("Enter operation (-1 to exit program) : ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci Series");
        operation = Convert.ToInt32(Console.ReadLine());

        if (operation == -1)
        {
            Console.WriteLine("Exiting the program...");
            break; // Exit the loop if user chooses to exit
        }
        Console.Write("Enter first number: ");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        secondNumber = Convert.ToInt32(Console.ReadLine());

        //Perform the calculation based on the operation
        int result = 0;
        switch (operation)
        {
            case 1:
                result = firstNumber + secondNumber;
                Console.WriteLine($"Result: {firstNumber} + {secondNumber} = {result}");
                break;
            case 2:
                result = firstNumber - secondNumber;
                Console.WriteLine($"Result: {firstNumber} - {secondNumber} = {result}");
                break;
            case 3:
                result = firstNumber * secondNumber;
                Console.WriteLine($"Result: {firstNumber} * {secondNumber} = {result}");
                break;
            case 4:
                result = firstNumber / secondNumber;
                Console.WriteLine($"Result: {firstNumber} / {secondNumber} = {result}");                
                break;
            case 5:
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    result += i;
                }
                Console.WriteLine($"Fibonacci Series from {firstNumber} to {secondNumber}:{result}");
                break;
            default:
                throw new Exception("Invalid operation selected. Please choose a valid operation.");                     
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Please enter a valid number for the operation.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Error: The number entered is too large or too small.");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");      
    }
    finally
    {
        Console.WriteLine("Press Enter To Continue");
        Console.ReadLine();
    }
}
Console.WriteLine("Thank you for using the Sample Calculator Console Application!");
// Exit the program
