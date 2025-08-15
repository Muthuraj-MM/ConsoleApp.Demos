// Declare Variables

string firstName = string.Empty; 
string lastName = string.Empty;
int age = 0;
int retirementAge = 58; // Example retirement age

// Prompt for User Input
Console.WriteLine("Enter your first name:");
firstName = Console.ReadLine() ?? string.Empty; // Read user input and handle null

Console.WriteLine("Enter your last name:");
lastName = Console.ReadLine() ?? string.Empty; // Read user input and handle null

Console.WriteLine("Enter your age:");

//age = Convert.ToInt32(Console.ReadLine()); // Read user input and convert to integer
string ageInput = Console.ReadLine() ?? "0"; // Read user input and handle null
age = Convert.ToInt32(ageInput); // Convert input to integer


//Process the data
int retirementYearsLeft = retirementAge - age;

// Output the result
Console.WriteLine($"Full Name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"retirementYearsLeft: { retirementYearsLeft }");
