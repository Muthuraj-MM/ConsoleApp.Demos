Console.WriteLine("Welcome to the Sample Calculator Console Application!");

//Get user input for the operation
Console.Write("Enter operation (+, -, *, /): ");
char operation = Console.ReadKey().KeyChar;

//Get user input for two numbers
Console.WriteLine(); // Move to the next line after reading the operation
Console.Write("Enter first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(); // Move to the next line after reading the operation

//Perform the calculation based on the operation
double result;
switch (operation)
{
    case '+':
        result = firstNumber + secondNumber;
        Console.WriteLine($"Result: {firstNumber} + {secondNumber} = {result}");
        break;
    case '-':
        result = firstNumber - secondNumber;
        Console.WriteLine($"Result: {firstNumber} - {secondNumber} = {result}");
        break;
    case '*':
        result = firstNumber * secondNumber;
        Console.WriteLine($"Result: {firstNumber} * {secondNumber} = {result}");
        break;
    case '/':
        if (secondNumber != 0)
        {
            result = firstNumber / secondNumber;
            Console.WriteLine($"Result: {firstNumber} / {secondNumber} = {result}");
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        break;
    default:
        Console.WriteLine("Error: Invalid operation. Please enter one of +, -, *, /.");
        break;
}