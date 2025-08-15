Console.Write("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

/*
 * This program performs basic arithmetic operations on two integers
*/ 

// Perform addition
int sum = firstNumber + secondNumber;

// Perform subtraction
int difference = firstNumber - secondNumber;

// Perform multiplication
int product = firstNumber * secondNumber;

// Perform division
int quotient = firstNumber / secondNumber;

// Perform modulus
int remainder = firstNumber % secondNumber;

// Display results
Console.WriteLine("*************Math Operations*************");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Remainder: {remainder}");

/*
 * This does the logical operations on two integers
*/


Boolean isEqual = firstNumber == secondNumber;
bool isNotEqual = firstNumber != secondNumber;
bool isGreater = firstNumber > secondNumber;
bool isLess = firstNumber < secondNumber;   
bool isGreaterOrEqual = firstNumber >= secondNumber;
bool isLessOrEqual = firstNumber <= secondNumber;

// Display comparison results
Console.WriteLine("*************Comparison Results*************");
Console.WriteLine();
Console.WriteLine($"Is Equal: {isEqual}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine($"Is Greater: {isGreater}");
Console.WriteLine($"Is Less: {isLess}");
Console.WriteLine($"Is Greater or Equal: {isGreaterOrEqual}");
Console.WriteLine($"Is Less or Equal: {isLessOrEqual}");


/*
 * This does the compound assignment operations
*/

Console.WriteLine("Enter random number: ");
int randomNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("*************Compound Assignment Operations*************");
Console.WriteLine();
//firstNumber = firstNumber + randomNumber;
firstNumber += randomNumber; // Increment firstNumber by randomNumber
Console.WriteLine($"After incrementing by {randomNumber}, firstNumber: {firstNumber}");
firstNumber -= randomNumber; // Decrement firstNumber by randomNumber
Console.WriteLine($"After decrementing by {randomNumber}, firstNumber: {firstNumber}");
firstNumber *= randomNumber; // Multiply firstNumber by randomNumber
Console.WriteLine($"After multiplying by {randomNumber}, firstNumber: {firstNumber}");
firstNumber /= randomNumber; // Divide firstNumber by randomNumber
Console.WriteLine($"After dividing by {randomNumber}, firstNumber: {firstNumber}");
firstNumber %= randomNumber; // Modulus of firstNumber by randomNumber
Console.WriteLine($"After modulus by {randomNumber}, firstNumber: {firstNumber}");



